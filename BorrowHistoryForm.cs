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
    public partial class BorrowHistoryForm : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";

        public BorrowHistoryForm()
        {
            InitializeComponent();
        }

        private void BorrowHistoryForm_Load(object sender, EventArgs e)
        {
            LoadBorrowHistory();
        }

        private void LoadBorrowHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        bh.BorrowID, 
                        m.FullName AS MemberName, 
                        b.Title AS BookTitle, 
                        bh.BorrowDate, 
                        bh.ReturnDate, 
                        CASE WHEN bh.Returned = 1 THEN 'Yes' ELSE 'No' END AS Returned
                    FROM BorrowHistory bh
                    JOIN Members m ON bh.MemberID = m.MemberID
                    JOIN Books b ON bh.BookID = b.BookID
                    ORDER BY bh.BorrowDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBorrowHistory.DataSource = dt;
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
