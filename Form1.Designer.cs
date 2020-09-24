namespace ParallelCompulsory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblParaResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblSeqResult = new System.Windows.Forms.Label();
            this.listviewParaResult = new System.Windows.Forms.ListView();
            this.listviewSeqResult = new System.Windows.Forms.ListView();
            this.paraWaiting = new System.Windows.Forms.Label();
            this.seqWaiting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(250, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Parallel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Location = new System.Drawing.Point(35, 41);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(430, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Location = new System.Drawing.Point(35, 101);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(430, 20);
            this.txtTo.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(32, 25);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Enter From";
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(32, 85);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(48, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Enter To";
            // 
            // lblParaResult
            // 
            this.lblParaResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParaResult.Location = new System.Drawing.Point(250, 205);
            this.lblParaResult.Name = "lblParaResult";
            this.lblParaResult.Size = new System.Drawing.Size(215, 51);
            this.lblParaResult.TabIndex = 6;
            this.lblParaResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(35, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Get Seqential";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblSeqResult
            // 
            this.lblSeqResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSeqResult.Location = new System.Drawing.Point(35, 205);
            this.lblSeqResult.Name = "lblSeqResult";
            this.lblSeqResult.Size = new System.Drawing.Size(215, 51);
            this.lblSeqResult.TabIndex = 8;
            this.lblSeqResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeqResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // listviewParaResult
            // 
            this.listviewParaResult.HideSelection = false;
            this.listviewParaResult.Location = new System.Drawing.Point(250, 314);
            this.listviewParaResult.Name = "listviewParaResult";
            this.listviewParaResult.Size = new System.Drawing.Size(215, 321);
            this.listviewParaResult.TabIndex = 9;
            this.listviewParaResult.UseCompatibleStateImageBehavior = false;
            // 
            // listviewSeqResult
            // 
            this.listviewSeqResult.HideSelection = false;
            this.listviewSeqResult.Location = new System.Drawing.Point(35, 314);
            this.listviewSeqResult.Name = "listviewSeqResult";
            this.listviewSeqResult.Size = new System.Drawing.Size(215, 321);
            this.listviewSeqResult.TabIndex = 10;
            this.listviewSeqResult.UseCompatibleStateImageBehavior = false;
            // 
            // paraWaiting
            // 
            this.paraWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.paraWaiting.Location = new System.Drawing.Point(250, 154);
            this.paraWaiting.Name = "paraWaiting";
            this.paraWaiting.Size = new System.Drawing.Size(215, 23);
            this.paraWaiting.TabIndex = 11;
            this.paraWaiting.Text = "Calculating";
            this.paraWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paraWaiting.Visible = false;
            // 
            // seqWaiting
            // 
            this.seqWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.seqWaiting.Location = new System.Drawing.Point(35, 154);
            this.seqWaiting.Name = "seqWaiting";
            this.seqWaiting.Size = new System.Drawing.Size(215, 23);
            this.seqWaiting.TabIndex = 12;
            this.seqWaiting.Text = "Calculating";
            this.seqWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.seqWaiting.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 647);
            this.Controls.Add(this.seqWaiting);
            this.Controls.Add(this.paraWaiting);
            this.Controls.Add(this.listviewSeqResult);
            this.Controls.Add(this.listviewParaResult);
            this.Controls.Add(this.lblSeqResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblParaResult);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblParaResult;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSeqResult;
        private System.Windows.Forms.ListView listviewParaResult;
        private System.Windows.Forms.ListView listviewSeqResult;
        private System.Windows.Forms.Label paraWaiting;
        private System.Windows.Forms.Label seqWaiting;
    }
}

