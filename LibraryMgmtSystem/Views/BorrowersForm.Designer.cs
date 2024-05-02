namespace LibraryMgmtSystem.Views
{
    partial class BorrowersForm
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
            dgvBorrowers = new DataGridView();
            colBorrowerId = new DataGridViewTextBoxColumn();
            colBorrowerName = new DataGridViewTextBoxColumn();
            btnAddBorrower = new Button();
            btnEditBorrower = new Button();
            btnDeleteBorrower = new Button();
            btnSelect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowers
            // 
            dgvBorrowers.Columns.AddRange(new DataGridViewColumn[] { colBorrowerId, colBorrowerName });
            dgvBorrowers.Location = new Point(12, 12);
            dgvBorrowers.MultiSelect = false;
            dgvBorrowers.Name = "dgvBorrowers";
            dgvBorrowers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowers.Size = new Size(776, 397);
            dgvBorrowers.TabIndex = 0;
            // 
            // colBorrowerId
            // 
            colBorrowerId.DataPropertyName = "Id";
            colBorrowerId.HeaderText = "Borrower ID";
            colBorrowerId.Name = "colBorrowerId";
            // 
            // colBorrowerName
            // 
            colBorrowerName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colBorrowerName.DataPropertyName = "Name";
            colBorrowerName.HeaderText = "Name";
            colBorrowerName.Name = "colBorrowerName";
            // 
            // btnAddBorrower
            // 
            btnAddBorrower.Location = new Point(12, 415);
            btnAddBorrower.Name = "btnAddBorrower";
            btnAddBorrower.Size = new Size(75, 23);
            btnAddBorrower.TabIndex = 1;
            btnAddBorrower.Text = "Add..";
            btnAddBorrower.UseVisualStyleBackColor = true;
            // 
            // btnEditBorrower
            // 
            btnEditBorrower.Location = new Point(93, 415);
            btnEditBorrower.Name = "btnEditBorrower";
            btnEditBorrower.Size = new Size(75, 23);
            btnEditBorrower.TabIndex = 2;
            btnEditBorrower.Text = "Edit...";
            btnEditBorrower.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBorrower
            // 
            btnDeleteBorrower.Location = new Point(174, 415);
            btnDeleteBorrower.Name = "btnDeleteBorrower";
            btnDeleteBorrower.Size = new Size(75, 23);
            btnDeleteBorrower.TabIndex = 3;
            btnDeleteBorrower.Text = "Delete";
            btnDeleteBorrower.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            btnSelect.DialogResult = DialogResult.OK;
            btnSelect.Location = new Point(370, 415);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            // 
            // BorrowersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSelect);
            Controls.Add(btnDeleteBorrower);
            Controls.Add(btnEditBorrower);
            Controls.Add(btnAddBorrower);
            Controls.Add(dgvBorrowers);
            Name = "BorrowersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrowers";
            ((System.ComponentModel.ISupportInitialize)dgvBorrowers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBorrowers;
        private Button btnAddBorrower;
        private Button btnEditBorrower;
        private Button btnDeleteBorrower;
        private DataGridViewTextBoxColumn colBorrowerId;
        private DataGridViewTextBoxColumn colBorrowerName;
        private Button btnSelect;
    }
}