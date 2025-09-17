namespace LibraryManagement
{
    partial class BorrowBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBookForm));
            label1 = new Label();
            cmbMembers = new ComboBox();
            cmbBooks = new ComboBox();
            dtpBorrowDate = new DateTimePicker();
            btnBorrow = new Button();
            btnClear = new Button();
            dgvBorrowList = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(276, 37);
            label1.Name = "label1";
            label1.Size = new Size(339, 46);
            label1.TabIndex = 0;
            label1.Text = "Burrow Books Form";
            // 
            // cmbMembers
            // 
            cmbMembers.FormattingEnabled = true;
            cmbMembers.Location = new Point(326, 113);
            cmbMembers.Name = "cmbMembers";
            cmbMembers.Size = new Size(478, 28);
            cmbMembers.TabIndex = 1;
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(326, 171);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(478, 28);
            cmbBooks.TabIndex = 2;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(326, 222);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(290, 27);
            dtpBorrowDate.TabIndex = 3;
            // 
            // btnBorrow
            // 
            btnBorrow.BackColor = Color.SlateBlue;
            btnBorrow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrow.ForeColor = Color.Transparent;
            btnBorrow.Location = new Point(326, 275);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(155, 42);
            btnBorrow.TabIndex = 4;
            btnBorrow.Text = "Burrow";
            btnBorrow.UseVisualStyleBackColor = false;
            btnBorrow.Click += btnBorrow_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SlateBlue;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Transparent;
            btnClear.Location = new Point(510, 275);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 42);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBorrowList
            // 
            dgvBorrowList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowList.Location = new Point(107, 332);
            dgvBorrowList.Name = "dgvBorrowList";
            dgvBorrowList.RowHeadersWidth = 51;
            dgvBorrowList.Size = new Size(706, 234);
            dgvBorrowList.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(80, 113);
            label2.Name = "label2";
            label2.Size = new Size(228, 28);
            label2.TabIndex = 7;
            label2.Text = "Select member name : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(80, 167);
            label3.Name = "label3";
            label3.Size = new Size(184, 28);
            label3.TabIndex = 8;
            label3.Text = "Select book title : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(80, 220);
            label4.Name = "label4";
            label4.Size = new Size(208, 28);
            label4.TabIndex = 9;
            label4.Text = "Select burrow date : ";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.SlateBlue;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(696, 275);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(149, 42);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 597);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvBorrowList);
            Controls.Add(btnClear);
            Controls.Add(btnBorrow);
            Controls.Add(dtpBorrowDate);
            Controls.Add(cmbBooks);
            Controls.Add(cmbMembers);
            Controls.Add(label1);
            Name = "BorrowBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowBooksForm";
            Load += BorrowBookForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbMembers;
        private ComboBox cmbBooks;
        private DateTimePicker dtpBorrowDate;
        private Button btnBorrow;
        private Button btnClear;
        private DataGridView dgvBorrowList;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBack;
    }
}