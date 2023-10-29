namespace StudentInfo
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
            label2 = new Label();
            txtNumber = new TextBox();
            label3 = new Label();
            txtDepartment = new TextBox();
            btnTransfer = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            txtSearch1 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 99);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "Student No";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(154, 91);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(142, 23);
            txtNumber.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 154);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Department";
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(154, 146);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(142, 23);
            txtDepartment.TabIndex = 5;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(351, 22);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(75, 23);
            btnTransfer.TabIndex = 7;
            btnTransfer.Text = "Transfer";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(408, 311);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 30);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(408, 389);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 30);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(154, 213);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(180, 30);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(190, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(293, 23);
            comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 48);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Name and Suename";
            // 
            // txtName
            // 
            txtName.Location = new Point(154, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(142, 23);
            txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDepartment);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(95, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 272);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Add Screen ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(listBox1);
            groupBox2.Controls.Add(txtSearch1);
            groupBox2.Controls.Add(btnTransfer);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Location = new Point(610, 34);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 475);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Student Info";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(190, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(291, 184);
            listBox1.TabIndex = 14;
            // 
            // txtSearch1
            // 
            txtSearch1.Location = new Point(208, 394);
            txtSearch1.Name = "txtSearch1";
            txtSearch1.Size = new Size(183, 23);
            txtSearch1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1515, 787);
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
        private Label label2;
        private TextBox txtNumber;
        private Label label3;
        private TextBox txtDepartment;
        private Button btnTransfer;
        private Button btnClear;
        private Button btnSearch;
        private Button btnAdd;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox txtName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtSearch1;
        private ListBox listBox1;
    }
}