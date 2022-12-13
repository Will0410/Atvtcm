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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            {
                if (txtboxlogin.Text == "")
                {
                    MessageBox.Show("Usuario deve ser preenchido!");
                }
                if(txtboxlogin.Text != "Casadebolos")
                {
                    MessageBox.Show("Usuario incorreto");
                }
                if (txtboxsenha.Text == "")
                {
                    MessageBox.Show("Senha deve ser preenchido!");
                }
                if(txtboxsenha.Text != "123")
                {
                    MessageBox.Show("Senha incorreta!");
                }
                else
                {

                    if (txtboxlogin.Text == "Casadebolos" && txtboxsenha.Text == "123")
                    {
                        Form1 TelaMenu = new Form1();
                        TelaMenu.Show();
                    }
                   
                }
            }

        }
        
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
