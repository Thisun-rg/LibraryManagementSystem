namespace LibraryManagement
{
    partial class ReturnHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnHistoryForm));
            label1 = new Label();
            dgvReturningHistory = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReturningHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(194, 32);
            label1.Name = "label1";
            label1.Size = new Size(487, 46);
            label1.TabIndex = 0;
            label1.Text = "View Returning History Form";
            // 
            // dgvReturningHistory
            // 
            dgvReturningHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturningHistory.Location = new Point(101, 171);
            dgvReturningHistory.Name = "dgvReturningHistory";
            dgvReturningHistory.RowHeadersWidth = 51;
            dgvReturningHistory.Size = new Size(690, 361);
            dgvReturningHistory.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.IndianRed;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(619, 109);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(172, 42);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ReturnHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 570);
            Controls.Add(btnBack);
            Controls.Add(dgvReturningHistory);
            Controls.Add(label1);
            Name = "ReturnHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewReturningHistoryForm";
            Load += ViewReturningHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturningHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReturningHistory;
        private Button btnBack;
    }
}