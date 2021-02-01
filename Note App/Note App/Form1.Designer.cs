namespace Note_App
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.desTxt = new System.Windows.Forms.TextBox();
            this.solTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.newBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.solutionList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.solutionList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(13, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Solution";
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(80, 24);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(294, 20);
            this.titleTxt.TabIndex = 3;
            // 
            // desTxt
            // 
            this.desTxt.Location = new System.Drawing.Point(79, 59);
            this.desTxt.Multiline = true;
            this.desTxt.Name = "desTxt";
            this.desTxt.Size = new System.Drawing.Size(396, 117);
            this.desTxt.TabIndex = 4;
            // 
            // solTxt
            // 
            this.solTxt.Location = new System.Drawing.Point(79, 194);
            this.solTxt.Multiline = true;
            this.solTxt.Name = "solTxt";
            this.solTxt.Size = new System.Drawing.Size(396, 207);
            this.solTxt.TabIndex = 5;
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveBtn.Location = new System.Drawing.Point(160, 407);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 7;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newBtn
            // 
            this.newBtn.Location = new System.Drawing.Point(79, 407);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(75, 23);
            this.newBtn.TabIndex = 8;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(667, 407);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 9;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // solutionList
            // 
            this.solutionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.solutionList.Location = new System.Drawing.Point(502, 24);
            this.solutionList.Name = "solutionList";
            this.solutionList.Size = new System.Drawing.Size(240, 377);
            this.solutionList.TabIndex = 6;
            this.solutionList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.solutionList_CellClick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(754, 479);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.solutionList);
            this.Controls.Add(this.solTxt);
            this.Controls.Add(this.desTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solutionList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox desTxt;
        private System.Windows.Forms.TextBox solTxt;
        private System.Windows.Forms.DataGridView solutionList;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}

