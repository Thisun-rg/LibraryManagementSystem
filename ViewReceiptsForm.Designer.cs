﻿namespace LibraryManagement
{
    partial class ViewReceiptsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReceiptsForm));
            label1 = new Label();
            txtReceipts = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(201, 30);
            label1.Name = "label1";
            label1.Size = new Size(449, 46);
            label1.TabIndex = 0;
            label1.Text = "View Return Receipts Form";
            // 
            // txtReceipts
            // 
            txtReceipts.Location = new Point(89, 174);
            txtReceipts.Multiline = true;
            txtReceipts.Name = "txtReceipts";
            txtReceipts.ReadOnly = true;
            txtReceipts.ScrollBars = ScrollBars.Vertical;
            txtReceipts.Size = new Size(706, 358);
            txtReceipts.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tan;
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.Transparent;
            btnBack.Location = new Point(642, 108);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 44);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ViewReceiptsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(887, 585);
            Controls.Add(btnBack);
            Controls.Add(txtReceipts);
            Controls.Add(label1);
            Name = "ViewReceiptsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewReturnReceiptsForm";
            Load += ViewReturnReceiptsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtReceipts;
        private Button btnBack;
    }
}