namespace LibraryManagement
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            dgvBorrowedBooks = new DataGridView();
            label1 = new Label();
            dtpReturnDate = new DateTimePicker();
            btnReturnBook = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(80, 94);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(742, 396);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(275, 19);
            label1.Name = "label1";
            label1.Size = new Size(328, 46);
            label1.TabIndex = 1;
            label1.Text = "Return Books Form";
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(80, 520);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(265, 27);
            dtpReturnDate.TabIndex = 2;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.RoyalBlue;
            btnReturnBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.ForeColor = Color.Transparent;
            btnReturnBook.Location = new Point(375, 519);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(228, 41);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.RoyalBlue;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(682, 520);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(140, 40);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ReturnBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(937, 599);
            Controls.Add(btnBack);
            Controls.Add(btnReturnBook);
            Controls.Add(dtpReturnDate);
            Controls.Add(label1);
            Controls.Add(dgvBorrowedBooks);
            Name = "ReturnBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBookForm";
            Load += ReturnBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Label label1;
        private DateTimePicker dtpReturnDate;
        private Button btnReturnBook;
        private Button btnBack;
    }
}