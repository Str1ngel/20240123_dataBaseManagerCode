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

namespace _20240123_dataBaseManager
{
    public partial class CleaingForm : Form
    {
        string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=adatbazis";
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string query;
        public CleaingForm()
        {
            InitializeComponent();
        }

        private void CleaingForm_Load(object sender, EventArgs e)
        {   
            LoadGrid();
            LoadSql();
        }

        private void LoadSql()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            query = "SELECT * FROM auto";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            gridSettings();

            connection.Close();
        }

        private void LoadGrid()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Rendszám", typeof(string));
            dt.Columns.Add("Tipus", typeof(string));
            dt.Columns.Add("Tulajdonos", typeof(string));
            dt.Columns.Add("Ár", typeof(int));
            dataGridView1.DataSource = dt;
            gridSettings();
        }

        private void gridSettings()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }
    }
}
