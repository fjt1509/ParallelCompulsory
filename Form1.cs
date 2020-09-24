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
        PrimeGenerator pg = new PrimeGenerator();

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
            List<long> result = await Task.Run(() => pg.GetPrimesParallel(from, to));
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
            listviewSeqResult.Items.Clear();
            long from = Convert.ToInt64(txtFrom.Text);
            long to = Convert.ToInt64(txtTo.Text);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<long> result = await Task.Run(() => pg.GetPrimesSequential(from, to));
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string timestamp = ts.ToString("mm\\:ss\\.ff");

            string displayResult = "Time: " + timestamp + " sec" + "\nAmount of Primes: " + result.Count.ToString();
            lblSeqResult.Text = displayResult;

            await Task.Run(() => PopulateSeqListview(result));


            seqWaiting.Visible = false;
            button2.Visible = true;
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
