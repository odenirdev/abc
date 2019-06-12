using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p001_gerenciador_servicos
{
    public partial class Login : Form
    {
        public static int cod_login = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.login(tb_email.Text, tb_senha.Text);
        }

        private void login(string email, string senha)
        {
            Menu TelaMenu = new Menu();
            
            if (cod_login != Apoio.validarEmail(email))
            {
                cod_login = Apoio.validarEmail(email);
                if (Apoio.validarSenha(cod_login ,senha))
                {
                    TelaMenu.Show();
                    this.Hide();
                }
                else
                {
                    erro_login.Visible = true;
                }

            }
            else
            {
                erro_login.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_senha.PasswordChar = '\0';
            }
            else
            {
                tb_senha.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_senha.PasswordChar = '*';
        }

        private void bttn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
