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
    public partial class ReturnBookForm : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";
        string receiptsFolder = @"C:\Users\User\Desktop\LibraryManagement\Receipts"; // folder for receipts

        public ReturnBookForm()
        {
            InitializeComponent();
        }

        private void ReturnBookForm_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
            if (!Directory.Exists(receiptsFolder))
            {
                Directory.CreateDirectory(receiptsFolder);
            }
        }

        private void LoadBorrowedBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT bh.BorrowID, m.FullName AS MemberName, b.Title AS BookTitle, bh.BorrowDate
                                 FROM BorrowHistory bh
                                 JOIN Members m ON bh.MemberID = m.MemberID
                                 JOIN Books b ON bh.BookID = b.BookID
                                 WHERE bh.Returned = 0";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBorrowedBooks.DataSource = dt;
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dgvBorrowedBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a borrow record to return.");
                return;
            }

            int borrowId = Convert.ToInt32(dgvBorrowedBooks.SelectedRows[0].Cells["BorrowID"].Value);
            string memberName = dgvBorrowedBooks.SelectedRows[0].Cells["MemberName"].Value.ToString();
            string bookTitle = dgvBorrowedBooks.SelectedRows[0].Cells["BookTitle"].Value.ToString();
            DateTime borrowDate = Convert.ToDateTime(dgvBorrowedBooks.SelectedRows[0].Cells["BorrowDate"].Value);
            DateTime returnDate = dtpReturnDate.Value;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Mark as returned
                string updateQuery = "UPDATE BorrowHistory SET Returned = 1, ReturnDate = @ReturnDate WHERE BorrowID = @BorrowID";
                SqlCommand cmdUpdate = new SqlCommand(updateQuery, con);
                cmdUpdate.Parameters.AddWithValue("@ReturnDate", returnDate);
                cmdUpdate.Parameters.AddWithValue("@BorrowID", borrowId);
                cmdUpdate.ExecuteNonQuery();

                // Make book available again
                string updateBook = @"UPDATE Books 
                                      SET Available = 1
                                      WHERE BookID = (SELECT BookID FROM BorrowHistory WHERE BorrowID = @BorrowID)";
                SqlCommand cmdBook = new SqlCommand(updateBook, con);
                cmdBook.Parameters.AddWithValue("@BorrowID", borrowId);
                cmdBook.ExecuteNonQuery();

                con.Close();
            }

            // Create receipt text file
            string receiptText = $"{memberName} borrowed \"{bookTitle}\" on {borrowDate:yyyy-MM-dd} and returned on {returnDate:yyyy-MM-dd}.";
            string fileName = Path.Combine(receiptsFolder, $"Receipt_{borrowId}.txt");
            File.WriteAllText(fileName, receiptText);

            MessageBox.Show("Book returned successfully! Receipt saved.");

            LoadBorrowedBooks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
