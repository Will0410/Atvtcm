using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interdisciplinar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntConsulta_Click(object sender, EventArgs e)
        {
            {
                Telaconsulta consulta = new();
                consulta.Show();
                this.Visible = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            {
                Telacad cadastro = new();
                cadastro.Show();
                this.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            telacadclient cadcliente = new();
            cadcliente.Show();
            this.Visible = false;
        }
    }
}
