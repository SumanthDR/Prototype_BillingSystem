namespace project.cs
{
    partial class Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxregno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboboxpaytype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboboxcourse = new System.Windows.Forms.ComboBox();
            this.comboboxyear = new System.Windows.Forms.ComboBox();
            this.btnsort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxregno
            // 
            this.txtboxregno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxregno.Location = new System.Drawing.Point(102, 52);
            this.txtboxregno.Name = "txtboxregno";
            this.txtboxregno.Size = new System.Drawing.Size(141, 21);
            this.txtboxregno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RegNo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datagrid1);
            this.groupBox2.Location = new System.Drawing.Point(21, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1317, 492);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtboxregno);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(33, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 141);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search Box";
            // 
            // datagrid1
            // 
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(12, 0);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(1305, 481);
            this.datagrid1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboboxyear);
            this.groupBox4.Controls.Add(this.btnsort);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboboxpaytype);
            this.groupBox4.Controls.Add(this.comboboxcourse);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(474, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(864, 100);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sort By";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payment Type";
            // 
            // comboboxpaytype
            // 
            this.comboboxpaytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxpaytype.FormattingEnabled = true;
            this.comboboxpaytype.Items.AddRange(new object[] {
            "Cash",
            "Credit/Debit  Card",
            "DD",
            "Cheque",
            "Net Banking"});
            this.comboboxpaytype.Location = new System.Drawing.Point(187, 38);
            this.comboboxpaytype.Name = "comboboxpaytype";
            this.comboboxpaytype.Size = new System.Drawing.Size(121, 23);
            this.comboboxpaytype.TabIndex = 5;
            this.comboboxpaytype.SelectedIndexChanged += new System.EventHandler(this.comboboxpaytype_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course";
            // 
            // comboboxcourse
            // 
            this.comboboxcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxcourse.FormattingEnabled = true;
            this.comboboxcourse.Items.AddRange(new object[] {
            "BCA",
            "BCom",
            "BBM",
            "BA",
            "BSc",
            "BBA"});
            this.comboboxcourse.Location = new System.Drawing.Point(390, 39);
            this.comboboxcourse.Name = "comboboxcourse";
            this.comboboxcourse.Size = new System.Drawing.Size(121, 23);
            this.comboboxcourse.TabIndex = 7;
            this.comboboxcourse.SelectedIndexChanged += new System.EventHandler(this.comboboxcourse_SelectedIndexChanged);
            // 
            // comboboxyear
            // 
            this.comboboxyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxyear.FormattingEnabled = true;
            this.comboboxyear.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year"});
            this.comboboxyear.Location = new System.Drawing.Point(576, 38);
            this.comboboxyear.Name = "comboboxyear";
            this.comboboxyear.Size = new System.Drawing.Size(121, 23);
            this.comboboxyear.TabIndex = 11;
            this.comboboxyear.SelectedIndexChanged += new System.EventHandler(this.comboboxyear_SelectedIndexChanged);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(732, 37);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(82, 25);
            this.btnsort.TabIndex = 12;
            this.btnsort.Text = "Sort";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Year";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistics";
            this.ShowInTaskbar = false;
            this.Text = "Statistics";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxregno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.ComboBox comboboxyear;
        private System.Windows.Forms.ComboBox comboboxcourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboboxpaytype;
        private System.Windows.Forms.Label label3;

    }
}