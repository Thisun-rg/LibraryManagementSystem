namespace LibraryManagement
{
    partial class BorrowHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowHistoryForm));
            label1 = new Label();
            dgvBorrowHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(214, 25);
            label1.Name = "label1";
            label1.Size = new Size(498, 46);
            label1.TabIndex = 0;
            label1.Text = "View Borrowing History Form";
            // 
            // dgvBorrowHistory
            // 
            dgvBorrowHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowHistory.Location = new Point(76, 167);
            dgvBorrowHistory.Name = "dgvBorrowHistory";
            dgvBorrowHistory.RowHeadersWidth = 51;
            dgvBorrowHistory.Size = new Size(784, 391);
            dgvBorrowHistory.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Salmon;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(685, 100);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 48);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // BorrowHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(933, 613);
            Controls.Add(btnBack);
            Controls.Add(dgvBorrowHistory);
            Controls.Add(label1);
            Name = "BorrowHistoryForm";
            Text = "ViewBorrowHistoryForm";
            Load += BorrowHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvBorrowHistory;
        private Button btnBack;
    }
}