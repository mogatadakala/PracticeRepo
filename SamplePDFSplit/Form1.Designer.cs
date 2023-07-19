namespace SamplePDFSplit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label lblsplit;
            btnsplit = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnbrowse = new Button();
            txtfilebrowse = new TextBox();
            txttotalnoofpages = new TextBox();
            lblnoofpages = new Label();
            lblsplitinterval = new Label();
            txtsplitinterval = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            txtfolderbrowse = new TextBox();
            btnbrowsefolder = new Button();
            lblfilebrowse = new Label();
            lblbrowse = new Label();
            lblsplit = new Label();
            SuspendLayout();
            // 
            // lblsplit
            // 
            lblsplit.AutoSize = true;
            lblsplit.ForeColor = Color.Red;
            lblsplit.Location = new Point(35, 174);
            lblsplit.Name = "lblsplit";
            lblsplit.Size = new Size(15, 20);
            lblsplit.TabIndex = 9;
            lblsplit.Text = "*";
            // 
            // btnsplit
            // 
            btnsplit.Location = new Point(165, 304);
            btnsplit.Name = "btnsplit";
            btnsplit.Size = new Size(179, 29);
            btnsplit.TabIndex = 0;
            btnsplit.Text = "Split Document";
            btnsplit.UseVisualStyleBackColor = true;
            btnsplit.Click += btnsplit_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowse
            // 
            btnbrowse.Location = new Point(493, 76);
            btnbrowse.Name = "btnbrowse";
            btnbrowse.Size = new Size(94, 29);
            btnbrowse.TabIndex = 1;
            btnbrowse.Text = "Browse";
            btnbrowse.UseVisualStyleBackColor = true;
            btnbrowse.Click += btnbrowse_Click;
            // 
            // txtfilebrowse
            // 
            txtfilebrowse.Location = new Point(35, 76);
            txtfilebrowse.Name = "txtfilebrowse";
            txtfilebrowse.ReadOnly = true;
            txtfilebrowse.Size = new Size(441, 27);
            txtfilebrowse.TabIndex = 2;
            // 
            // txttotalnoofpages
            // 
            txttotalnoofpages.Location = new Point(197, 120);
            txttotalnoofpages.Name = "txttotalnoofpages";
            txttotalnoofpages.ReadOnly = true;
            txttotalnoofpages.Size = new Size(125, 27);
            txttotalnoofpages.TabIndex = 3;
            // 
            // lblnoofpages
            // 
            lblnoofpages.AutoSize = true;
            lblnoofpages.Location = new Point(46, 123);
            lblnoofpages.Name = "lblnoofpages";
            lblnoofpages.Size = new Size(128, 20);
            lblnoofpages.TabIndex = 4;
            lblnoofpages.Text = "Total No Of Pages";
            // 
            // lblsplitinterval
            // 
            lblsplitinterval.AutoSize = true;
            lblsplitinterval.Location = new Point(46, 174);
            lblsplitinterval.Name = "lblsplitinterval";
            lblsplitinterval.Size = new Size(92, 20);
            lblsplitinterval.TabIndex = 5;
            lblsplitinterval.Text = "Split Interval";
            // 
            // txtsplitinterval
            // 
            txtsplitinterval.Location = new Point(200, 174);
            txtsplitinterval.Name = "txtsplitinterval";
            txtsplitinterval.Size = new Size(125, 27);
            txtsplitinterval.TabIndex = 6;
            // 
            // txtfolderbrowse
            // 
            txtfolderbrowse.Location = new Point(35, 235);
            txtfolderbrowse.Name = "txtfolderbrowse";
            txtfolderbrowse.ReadOnly = true;
            txtfolderbrowse.Size = new Size(441, 27);
            txtfolderbrowse.TabIndex = 7;
            // 
            // btnbrowsefolder
            // 
            btnbrowsefolder.Location = new Point(493, 233);
            btnbrowsefolder.Name = "btnbrowsefolder";
            btnbrowsefolder.Size = new Size(94, 29);
            btnbrowsefolder.TabIndex = 8;
            btnbrowsefolder.Text = "Browse";
            btnbrowsefolder.UseVisualStyleBackColor = true;
            btnbrowsefolder.Click += btnbrowsefolder_Click;
            // 
            // lblfilebrowse
            // 
            lblfilebrowse.AutoSize = true;
            lblfilebrowse.ForeColor = Color.Red;
            lblfilebrowse.Location = new Point(583, 80);
            lblfilebrowse.Name = "lblfilebrowse";
            lblfilebrowse.Size = new Size(15, 20);
            lblfilebrowse.TabIndex = 10;
            lblfilebrowse.Text = "*";
            // 
            // lblbrowse
            // 
            lblbrowse.AutoSize = true;
            lblbrowse.ForeColor = Color.Red;
            lblbrowse.Location = new Point(583, 238);
            lblbrowse.Name = "lblbrowse";
            lblbrowse.Size = new Size(15, 20);
            lblbrowse.TabIndex = 11;
            lblbrowse.Text = "*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 576);
            Controls.Add(lblbrowse);
            Controls.Add(lblfilebrowse);
            Controls.Add(lblsplit);
            Controls.Add(btnbrowsefolder);
            Controls.Add(txtfolderbrowse);
            Controls.Add(txtsplitinterval);
            Controls.Add(lblsplitinterval);
            Controls.Add(lblnoofpages);
            Controls.Add(txttotalnoofpages);
            Controls.Add(txtfilebrowse);
            Controls.Add(btnbrowse);
            Controls.Add(btnsplit);
            Name = "Form1";
            Text = "SplitPDFForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsplit;
        private OpenFileDialog openFileDialog1;
        private Button btnbrowse;
        private TextBox txtfilebrowse;
        private TextBox txttotalnoofpages;
        private Label lblnoofpages;
        private Label lblsplitinterval;
        private TextBox txtsplitinterval;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox txtfolderbrowse;
        private Button btnbrowsefolder;
        private Label lblfilebrowse;
        private Label lblbrowse;
    }
}