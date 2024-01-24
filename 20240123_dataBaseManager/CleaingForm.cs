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

        private void LoadSql(string specs)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            query = (specs == null) ? "SELECT * FROM auto" : specs;
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            gridSettings();

            connection.Close();
        }

        private void LoadSql()
            => LoadSql(null!);

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

        private void textBox_Kereses_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Kereses.Text.Length == 0)
            {
                LoadSql();
                return;
            }

            LoadSql($"SELECT * FROM auto WHERE tulajdonos LIKE '%{textBox_Kereses.Text}%' ");
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_userPlate.Text.Length == 0 || textBox_userType.Text.Length == 0 || textBox_userOwner.Text.Length == 0 || textBox_userPrice.Text.Length == 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
                return;
            }

            string rendszam = textBox_userPlate.Text;
            string tipus = textBox_userType.Text;
            string tulajdonos = textBox_userOwner.Text;
            int ar = Convert.ToInt32(textBox_userPrice.Text);

            connection.Open();

            query = $"INSERT INTO auto (rendszam, tipus, tulajdonos, ar) VALUES ('{rendszam}', '{tipus}', '{tulajdonos}', {ar})";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            connection.Close();

            Clear();
            LoadSql();
            MessageBox.Show("Sikeres mentés!");
        }

        private void Clear()
        {
            textBox_userPlate.Text = "";
            textBox_userType.Text = "";
            textBox_userOwner.Text = "";
            textBox_userPrice.Text = "";
            textBox_Kereses.Text = "";
        }
    }
}
