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
    public partial class ManageBooksForm : Form
    {
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True";

        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Books", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;

                // Make Available column a checkbox
                if (dgvBooks.Columns.Contains("Available"))
                {
                    dgvBooks.Columns["Available"].ReadOnly = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtGenre.Text == "" || txtYear.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Books (Title, Author, Genre, YearPublished, Available) VALUES (@Title, @Author, @Genre, @YearPublished, @Available)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@YearPublished", txtYear.Text);
                cmd.Parameters.AddWithValue("@Available", 1); // default new book as available

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Book added successfully!");
            LoadBooks();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, YearPublished=@YearPublished, Available=@Available WHERE BookID=@BookID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", id);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                cmd.Parameters.AddWithValue("@YearPublished", txtYear.Text);
                cmd.Parameters.AddWithValue("@Available", Convert.ToBoolean(dgvBooks.SelectedRows[0].Cells["Available"].Value));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Book updated successfully!");
            LoadBooks();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE BookID=@BookID", con);
                cmd.Parameters.AddWithValue("@BookID", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Book deleted successfully!");
            LoadBooks();
            ClearFields();
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTitle.Text = dgvBooks.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtAuthor.Text = dgvBooks.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                txtGenre.Text = dgvBooks.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                txtYear.Text = dgvBooks.Rows[e.RowIndex].Cells["YearPublished"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtYear.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            dashboard.Show();
            this.Close();
        }
    }
}
