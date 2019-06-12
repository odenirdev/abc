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

namespace p001_gerenciador_servicos
{
    public partial class ListarCliente : Form
    {
        private int cli_cod;

        public ListarCliente(int cli_cod)
        {
            InitializeComponent();
            this.cli_cod = cli_cod;
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            SqlDataReader result = Crud.listar("CLIENTES", this.cli_cod);
            if (result.Read())
            {
                tb_nome.Text = result[2].ToString();
                tb_snome.Text = result[3].ToString();
                tb_cpf.Text = result[4].ToString();
                tb_email.Text = result[5].ToString();
                tb_telefone.Text = result[6].ToString();
                tb_celular.Text = result[7].ToString();
                tb_cidade.Text = result[8].ToString();
                tb_endereco.Text = result[9].ToString();
                tb_numero.Text = result[10].ToString();
                tb_complemento.Text = result[11].ToString();
                lb_estado.Text = result[12].ToString();
            }
        }

        private void bttn_deletar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja deletar esse registro ?", "DELETAR REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
