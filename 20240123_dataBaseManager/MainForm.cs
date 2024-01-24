using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _20240123_dataBaseManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadGrid();
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=adatbazis";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM auto";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            gridSettings();

            connection.Close();

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                query = "SELECT AVG(ar) FROM auto";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Read();
                label1.Text = "Átlagár: " + reader[0].ToString();

                connection.Close();
            }

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                query = "SELECT COUNT(*) FROM auto";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Read();
                label2.Text = "Autók száma: " + reader[0].ToString();

                connection.Close();
            }
        }

        private void button_better_Click(object sender, EventArgs e)
        {
            Form newForm = new CleaingForm();
            newForm.ShowDialog();
        }
    }
}
