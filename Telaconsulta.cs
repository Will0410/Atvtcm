using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Interdisciplinar
{
    public partial class Telaconsulta : Form
    {
        public Telaconsulta()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1 menu = new();
            menu.Show();
            this.Visible = false;
        }

        private void Telaconsulta_Load(object sender, EventArgs e)
        {
  
            consultabolo();
            consulcliente();
        }




        private void combox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void consultabolo()
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT DISTINCT tipo FROM produtos";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            combox.DataSource = dt;
            combox.DisplayMember = "tipo";
            combox.ValueMember = "tipo";
            mySqlConnection.Close();

        }
        private void consulcliente()
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT DISTINCT nome FROM clientes";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "nome";
            mySqlConnection.Close();

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT * FROM produtos WHERE tipos= '" + combox.Text + "' AND tamanho= '" + "';";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            mySqlConnection.Close();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = true;
            string tipo = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT codproduto as 'Cod' , tipo as 'Tipo' , tamanho 'Tamanho' FROM tamanhos WHERE Produtos = '";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            mySqlConnection.Close();

        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT DISTINCT * FROM  produtos WHERE  tipo= '" + combox.Text +   "';";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            mySqlConnection.Close();
        }

        private void btnpesquicliente_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = root; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new();
            mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new();
            mySqlCommand.CommandText = "SELECT DISTINCT * FROM  clientes WHERE  nome= '" + comboBox1.Text + "';";
            mySqlCommand.Connection = mySqlConnection;
            MySqlDataAdapter mySqlDataAdapter = new(mySqlCommand);
            mySqlDataAdapter.Fill(dt);
            dataGridcliente.DataSource = dt;
            mySqlConnection.Close();
        }
    }
}
