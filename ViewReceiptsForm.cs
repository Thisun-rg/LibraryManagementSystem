using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagement
{
    public partial class ViewReceiptsForm : Form
    {
        // Folder where receipt files are stored
        string receiptsFolder = @"C:\Users\User\Desktop\projects\LibraryManagement\Receipts";

        public ViewReceiptsForm()
        {
            InitializeComponent();
        }

        private void ViewReturnReceiptsForm_Load(object sender, EventArgs e)
        {
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            try
            {
                if (Directory.Exists(receiptsFolder))
                {
                    var files = Directory.GetFiles(receiptsFolder, "Receipt_*.txt");
                    if (files.Length > 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var file in files)
                        {
                            sb.AppendLine(File.ReadAllText(file));
                            sb.AppendLine("--------------------------------------------------");
                        }
                        txtReceipts.Text = sb.ToString();
                    }
                    else
                    {
                        txtReceipts.Text = "No return receipts found.";
                    }
                }
                else
                {
                    txtReceipts.Text = "Receipts folder not found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading receipts: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
