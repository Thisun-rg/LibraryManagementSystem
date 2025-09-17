using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            ManageMembersForm membersForm = new ManageMembersForm();
            membersForm.Show();
            this.Hide();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            ManageBooksForm booksForm = new ManageBooksForm();
            booksForm.Show();
            this.Hide();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowForm = new BorrowBookForm();
            borrowForm.Show();
            this.Hide();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm returnForm = new ReturnBookForm();
            returnForm.Show();
            this.Hide();
        }

        private void btnBorrowHistory_Click(object sender, EventArgs e)
        {
            BorrowHistoryForm historyForm = new BorrowHistoryForm();
            historyForm.Show();
            this.Hide();
        }

        private void btnReturnHistory_Click(object sender, EventArgs e)
        {
            ReturnHistoryForm returnHistoryForm = new ReturnHistoryForm();
            returnHistoryForm.Show();
            this.Hide();
        }

        private void btnViewReceipts_Click(object sender, EventArgs e)
        {
            ViewReceiptsForm receiptsForm = new ViewReceiptsForm();
            receiptsForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to logout?",
                                                  "Confirm Logout",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}
