using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelCompulsory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            paraWaiting.Visible = true;
            lblParaResult.Text = "";
            listviewParaResult.Items.Clear();
            long from = Convert.ToInt64(txtFrom.Text);
            long to = Convert.ToInt64(txtTo.Text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> result = await Task.Run(() => GetPrimesParallel(from, to));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string timestamp = ts.ToString("mm\\:ss\\.ff");

            

            string displayResult = "Time: " + timestamp + " sec" + "\nAmount of Primes: " + result.Count.ToString();
            lblParaResult.Text = displayResult;

            await Task.Run(() => PopulateParaListview(result));
            paraWaiting.Visible = false;
            button1.Visible = true;
        }

    

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            seqWaiting.Visible = true;
            lblSeqResult.Text = "";
            long from = Convert.ToInt64(txtFrom.Text);
            long to = Convert.ToInt64(txtTo.Text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> result = await Task.Run(() => GetPrimesSequential(from, to));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string timestamp = ts.ToString("mm\\:ss\\.ff");

            string displayResult = "Time: " + timestamp + " sec" + "\nAmount of Primes: " + result.Count.ToString();
            lblSeqResult.Text = displayResult;

            await Task.Run(() => PopulateSeqListview(result));


            seqWaiting.Visible = false;
            button2.Visible = true;
        }



        private List<long> GetPrimesParallel(long from, long to)
        {
            Object sync = new Object();
            List<List<long>> partitionedPrimes = new List<List<long>>();

            var partition = Partitioner.Create(from, to);

            Parallel.ForEach(partition, (range) =>
            {
                List<long> localPrimes = new List<long>();

                for (long i = range.Item1; i < range.Item2; i++)
                {
                    if (IsPrime(i))
                    {
                        localPrimes.Add(i);
                    }
                }

                lock (sync)
                {
                    partitionedPrimes.Add(localPrimes);
                }
            });



            partitionedPrimes.RemoveAll(list => list.Count == 0);
            List<long> sortedList = new List<long>();

            List<List<long>> sortedContainer = partitionedPrimes.OrderBy(list => list[0]).ToList();
            sortedContainer.ForEach(list => sortedList.AddRange(list));


            return sortedList;

        }

        private List<long> GetPrimesSequential(long from, long to)
        {
            List<long> numbers = new List<long>();

            for (long i = from; i <= to; i++)
            {
                if (IsPrime(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        private Boolean IsPrime(long num)
        {
            int occourances = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    occourances++;
                }
            }

            if (occourances == 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateParaListview(List<long> data)
        {

            List<ListViewItem> items = new List<ListViewItem>();
            data.ForEach(num =>
            {
                items.Add(new ListViewItem(new[] {num.ToString()}));
            });

            if (listviewParaResult.InvokeRequired)
            {
                listviewParaResult.Invoke((MethodInvoker)delegate ()
                {

                    listviewParaResult.Items.AddRange(items.ToArray());
                });
            }
        }

        private void PopulateSeqListview(List<long> data)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            data.ForEach(num =>
            {
                items.Add(new ListViewItem(new[] { num.ToString() }));
            });

            if (listviewSeqResult.InvokeRequired)
            {
                listviewSeqResult.Invoke((MethodInvoker)delegate ()
                {

                    listviewSeqResult.Items.AddRange(items.ToArray());
                });
            }
        }

    }
}
