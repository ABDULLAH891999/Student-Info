namespace StudentInfo1
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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDepartement = new TextBox();
            txtNo = new TextBox();
            txtName = new TextBox();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            comboBox1 = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            btnTransfer = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.HotTrack;
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDepartement);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(txtName);
            groupBox1.Location = new Point(29, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Add Screen";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(260, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 46);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 109);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 5;
            label3.Text = "Departement";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 49);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Student No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 48);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Name Surname";
            // 
            // txtDepartement
            // 
            txtDepartement.Location = new Point(100, 104);
            txtDepartement.Name = "txtDepartement";
            txtDepartement.Size = new Size(100, 23);
            txtDepartement.TabIndex = 2;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(305, 45);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(100, 23);
            txtNo.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(112, 23);
            txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Highlight;
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnTransfer);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(508, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(343, 366);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(40, 305);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(149, 23);
            txtSearch.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(144, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 10;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(195, 292);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(128, 46);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(128, 46);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.Honeydew;
            btnTransfer.Location = new Point(12, 48);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(128, 43);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(146, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(191, 199);
            listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDepartement;
        private TextBox txtNo;
        private TextBox txtName;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private TextBox txtSearch;
        private ComboBox comboBox1;
        private Button btnSearch;
        private Button btnClear;
        private Button btnTransfer;
    }
}