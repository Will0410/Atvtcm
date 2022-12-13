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
    public partial class telacadclient : Form
    {
        public telacadclient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new();
            string conexao = @"Persist Security Info = False; Server = localhost; Database = casadebolos ; Uid = 'root'; Pwd = 'etec'";
            MySqlConnection mySqlConnection = new(conexao);
            //mySqlConnection.ConnectionString = conexao;
            mySqlConnection.Open();
            MySqlCommand inserir = new MySqlCommand();
            inserir.CommandText = "INSERT INTO clientes VALUES (" + txtcod.Text + ",'" + txtnm.Text + "','" + txtcont.Text + "','" +txtendereco.Text + "','" + txtpedido.Text + "');";
            inserir.Connection = mySqlConnection;
            inserir.ExecuteNonQuery();
            inserir.CommandText = "Select * FROM clientes;";
            MySqlDataAdapter mySqlDataAdapter = new(inserir);
            mySqlDataAdapter.Fill(dt);
            dgtcad.DataSource = dt;
            mySqlConnection.Close();
            MessageBox.Show("Cliente Cadastrado com sucesso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 menu = new();
            menu.Show();
            this.Visible = false;
        }

        private void txtpedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
