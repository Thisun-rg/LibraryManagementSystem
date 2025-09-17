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
    public partial class ReturnHistoryForm : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";

        public ReturnHistoryForm()
        {
            InitializeComponent();
        }

        private void ViewReturningHistoryForm_Load(object sender, EventArgs e)
        {
            LoadReturningHistory();
        }

        private void LoadReturningHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        bh.BorrowID, 
                        m.FullName AS MemberName, 
                        b.Title AS BookTitle, 
                        bh.BorrowDate, 
                        bh.ReturnDate
                    FROM BorrowHistory bh
                    JOIN Members m ON bh.MemberID = m.MemberID
                    JOIN Books b ON bh.BookID = b.BookID
                    WHERE bh.Returned = 1
                    ORDER BY bh.ReturnDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReturningHistory.DataSource = dt;
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
