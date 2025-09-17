namespace LibraryManagement
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            btnManageMembers = new Button();
            btnBorrowBook = new Button();
            btnBorrowHistory = new Button();
            btnViewReceipts = new Button();
            btnManageBooks = new Button();
            btnReturnBook = new Button();
            btnReturnHistory = new Button();
            btnLogout = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnManageMembers
            // 
            btnManageMembers.BackColor = Color.LightCoral;
            btnManageMembers.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageMembers.ForeColor = Color.Transparent;
            btnManageMembers.Location = new Point(172, 149);
            btnManageMembers.Name = "btnManageMembers";
            btnManageMembers.Size = new Size(279, 72);
            btnManageMembers.TabIndex = 0;
            btnManageMembers.Text = "Manage Members";
            btnManageMembers.UseVisualStyleBackColor = false;
            btnManageMembers.Click += btnManageMembers_Click;
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.BackColor = Color.LightCoral;
            btnBorrowBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowBook.ForeColor = Color.Transparent;
            btnBorrowBook.Location = new Point(172, 279);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(279, 72);
            btnBorrowBook.TabIndex = 1;
            btnBorrowBook.Text = "Borrow Book";
            btnBorrowBook.UseVisualStyleBackColor = false;
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // btnBorrowHistory
            // 
            btnBorrowHistory.BackColor = Color.LightCoral;
            btnBorrowHistory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrowHistory.ForeColor = Color.Transparent;
            btnBorrowHistory.Location = new Point(172, 411);
            btnBorrowHistory.Name = "btnBorrowHistory";
            btnBorrowHistory.Size = new Size(279, 72);
            btnBorrowHistory.TabIndex = 2;
            btnBorrowHistory.Text = "View Borrowing History";
            btnBorrowHistory.UseVisualStyleBackColor = false;
            btnBorrowHistory.Click += btnBorrowHistory_Click;
            // 
            // btnViewReceipts
            // 
            btnViewReceipts.BackColor = Color.LightCoral;
            btnViewReceipts.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewReceipts.ForeColor = Color.Transparent;
            btnViewReceipts.Location = new Point(172, 548);
            btnViewReceipts.Name = "btnViewReceipts";
            btnViewReceipts.Size = new Size(279, 72);
            btnViewReceipts.TabIndex = 3;
            btnViewReceipts.Text = "View Return Receipts";
            btnViewReceipts.UseVisualStyleBackColor = false;
            btnViewReceipts.Click += btnViewReceipts_Click;
            // 
            // btnManageBooks
            // 
            btnManageBooks.BackColor = Color.LightCoral;
            btnManageBooks.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageBooks.ForeColor = Color.Transparent;
            btnManageBooks.Location = new Point(715, 149);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(279, 72);
            btnManageBooks.TabIndex = 4;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.UseVisualStyleBackColor = false;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.BackColor = Color.LightCoral;
            btnReturnBook.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnBook.ForeColor = Color.Transparent;
            btnReturnBook.Location = new Point(715, 279);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(279, 72);
            btnReturnBook.TabIndex = 5;
            btnReturnBook.Text = "Return Book";
            btnReturnBook.UseVisualStyleBackColor = false;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnReturnHistory
            // 
            btnReturnHistory.BackColor = Color.LightCoral;
            btnReturnHistory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturnHistory.ForeColor = Color.Transparent;
            btnReturnHistory.Location = new Point(715, 411);
            btnReturnHistory.Name = "btnReturnHistory";
            btnReturnHistory.Size = new Size(279, 72);
            btnReturnHistory.TabIndex = 6;
            btnReturnHistory.Text = "View Returning History";
            btnReturnHistory.UseVisualStyleBackColor = false;
            btnReturnHistory.Click += btnReturnHistory_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightCoral;
            btnLogout.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Transparent;
            btnLogout.Location = new Point(715, 548);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(279, 72);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "LogOut";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(212, 55);
            label1.Name = "label1";
            label1.Size = new Size(746, 46);
            label1.TabIndex = 8;
            label1.Text = "Welcome To The Library Management System";
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1160, 670);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(btnReturnHistory);
            Controls.Add(btnReturnBook);
            Controls.Add(btnManageBooks);
            Controls.Add(btnViewReceipts);
            Controls.Add(btnBorrowHistory);
            Controls.Add(btnBorrowBook);
            Controls.Add(btnManageMembers);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageMembers;
        private Button btnBorrowBook;
        private Button btnBorrowHistory;
        private Button btnViewReceipts;
        private Button btnManageBooks;
        private Button btnReturnBook;
        private Button btnReturnHistory;
        private Button btnLogout;
        private Label label1;
    }
}