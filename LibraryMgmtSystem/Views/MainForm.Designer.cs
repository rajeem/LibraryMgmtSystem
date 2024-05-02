namespace LibraryMgmtSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            btnReturn = new Button();
            btnCheckout = new Button();
            btnBorrowers = new Button();
            btnBookAdd = new Button();
            btnBookDelete = new Button();
            btnBookEdit = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            dgvBooks = new DataGridView();
            colBookId = new DataGridViewTextBoxColumn();
            colBookTitle = new DataGridViewTextBoxColumn();
            colBookAuthor = new DataGridViewTextBoxColumn();
            colBookIsbn = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colTransactionId = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(btnBorrowers);
            panel1.Controls.Add(btnBookAdd);
            panel1.Controls.Add(btnBookDelete);
            panel1.Controls.Add(btnBookEdit);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1216, 46);
            panel1.TabIndex = 1;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(336, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(255, 12);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnBorrowers
            // 
            btnBorrowers.Location = new Point(684, 11);
            btnBorrowers.Name = "btnBorrowers";
            btnBorrowers.Size = new Size(100, 23);
            btnBorrowers.TabIndex = 3;
            btnBorrowers.Text = "Borrowers...";
            btnBorrowers.UseVisualStyleBackColor = true;
            // 
            // btnBookAdd
            // 
            btnBookAdd.Location = new Point(12, 12);
            btnBookAdd.Name = "btnBookAdd";
            btnBookAdd.Size = new Size(75, 23);
            btnBookAdd.TabIndex = 0;
            btnBookAdd.Text = "Add...";
            btnBookAdd.UseVisualStyleBackColor = true;
            // 
            // btnBookDelete
            // 
            btnBookDelete.Location = new Point(174, 12);
            btnBookDelete.Name = "btnBookDelete";
            btnBookDelete.Size = new Size(75, 23);
            btnBookDelete.TabIndex = 2;
            btnBookDelete.Text = "Delete";
            btnBookDelete.UseVisualStyleBackColor = true;
            // 
            // btnBookEdit
            // 
            btnBookEdit.Location = new Point(93, 12);
            btnBookEdit.Name = "btnBookEdit";
            btnBookEdit.Size = new Size(75, 23);
            btnBookEdit.TabIndex = 1;
            btnBookEdit.Text = "Edit...";
            btnBookEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(861, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(942, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 23);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1201, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(15, 596);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(18, 596);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(18, 624);
            panel4.Name = "panel4";
            panel4.Size = new Size(1183, 18);
            panel4.TabIndex = 0;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { colBookId, colBookTitle, colBookAuthor, colBookIsbn, colStatus, colTransactionId });
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(18, 46);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1183, 578);
            dgvBooks.TabIndex = 3;
            // 
            // colBookId
            // 
            colBookId.DataPropertyName = "Id";
            colBookId.HeaderText = "Book ID";
            colBookId.Name = "colBookId";
            colBookId.ReadOnly = true;
            // 
            // colBookTitle
            // 
            colBookTitle.DataPropertyName = "Title";
            colBookTitle.HeaderText = "Title";
            colBookTitle.Name = "colBookTitle";
            colBookTitle.ReadOnly = true;
            // 
            // colBookAuthor
            // 
            colBookAuthor.DataPropertyName = "Author";
            colBookAuthor.HeaderText = "Author";
            colBookAuthor.Name = "colBookAuthor";
            colBookAuthor.ReadOnly = true;
            // 
            // colBookIsbn
            // 
            colBookIsbn.DataPropertyName = "Isbn";
            colBookIsbn.HeaderText = "ISBN";
            colBookIsbn.Name = "colBookIsbn";
            colBookIsbn.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colTransactionId
            // 
            colTransactionId.DataPropertyName = "TransactionId";
            colTransactionId.HeaderText = "TransactionId";
            colTransactionId.Name = "colTransactionId";
            colTransactionId.ReadOnly = true;
            colTransactionId.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 642);
            Controls.Add(dgvBooks);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Library Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dgvBooks;
        private Button btnBookDelete;
        private Button btnBookEdit;
        private Button btnBookAdd;
        private TextBox textBox1;
        private Button button1;
        private Button btnBorrowers;
        private Button btnCheckout;
        private Button btnReturn;
        private DataGridViewTextBoxColumn colBookId;
        private DataGridViewTextBoxColumn colBookTitle;
        private DataGridViewTextBoxColumn colBookAuthor;
        private DataGridViewTextBoxColumn colBookIsbn;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colTransactionId;
    }
}
