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

namespace LibraryManagement
{
    public partial class BorrowBookForm : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";

        public BorrowBookForm()
        {
            InitializeComponent();
        }

        private void BorrowBookForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadBooks();
            LoadBorrowList();
        }

        private void LoadMembers()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MemberID, FullName FROM Members";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbMembers.DataSource = dt;
                cmbMembers.DisplayMember = "FullName";
                cmbMembers.ValueMember = "MemberID";
            }
        }

        private void LoadBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT BookID, Title FROM Books WHERE Available = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbBooks.DataSource = dt;
                cmbBooks.DisplayMember = "Title";
                cmbBooks.ValueMember = "BookID";
            }
        }

        private void LoadBorrowList()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT bh.BorrowID, m.FullName AS MemberName, b.Title AS BookTitle, 
                                 bh.BorrowDate, bh.Returned
                                 FROM BorrowHistory bh
                                 JOIN Members m ON bh.MemberID = m.MemberID
                                 JOIN Books b ON bh.BookID = b.BookID
                                 WHERE bh.Returned = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBorrowList.DataSource = dt;
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cmbMembers.SelectedValue == null || cmbBooks.SelectedValue == null)
            {
                MessageBox.Show("Please select both member and book.");
                return;
            }

            int memberId = Convert.ToInt32(cmbMembers.SelectedValue);
            int bookId = Convert.ToInt32(cmbBooks.SelectedValue);
            DateTime borrowDate = dtpBorrowDate.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Insert borrow record
                string insertQuery = "INSERT INTO BorrowHistory (MemberID, BookID, BorrowDate, Returned) VALUES (@MemberID, @BookID, @BorrowDate, 0)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                cmd.ExecuteNonQuery();

                // Mark book unavailable
                string updateBook = "UPDATE Books SET Available = 0 WHERE BookID = @BookID";
                SqlCommand cmdBook = new SqlCommand(updateBook, con);
                cmdBook.Parameters.AddWithValue("@BookID", bookId);
                cmdBook.ExecuteNonQuery();

                con.Close();
            }

            MessageBox.Show("Book borrowed successfully!");
            LoadBooks();      // refresh available books
            LoadBorrowList(); // refresh borrow list
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMembers.SelectedIndex = -1;
            cmbBooks.SelectedIndex = -1;
            dtpBorrowDate.Value = DateTime.Now;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
