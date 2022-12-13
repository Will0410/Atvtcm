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
using System.Data.SqlClient;

namespace Interdisciplinar
{
    public partial class Telacad : Form
    {
        public Telacad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = 'root'; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new(conexao);
            //mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand insert = new MySqlCommand();
            insert.CommandText = "INSERT INTO produtos VALUES (" + txtnmproduto.Text + ",'" + tipproduto.Text + "','" + tmnhopro.Text + "');";
            insert.Connection = mySqlConnection;
            insert.ExecuteNonQuery();
            insert.CommandText = "Select * FROM produtos;";
            MySqlDataAdapter mySqlDataAdapter = new(insert);
            mySqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            mySqlConnection.Close();
            MessageBox.Show("Produto Cadastrado com sucesso!");

        }

        private void tmnhopro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new();
            menu.Show();
            this.Visible = false;
        }

        private void Telacad_Load(object sender, EventArgs e)
        {

        }
    }
}
