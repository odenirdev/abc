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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadCliente TelaCadastro = new CadCliente();
            TelaCadastro.Show();
            this.Close();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            SqlDataReader result = Relatorios.listarTodos("CLIENTES");
            while (result.Read()) {
                ListViewItem item = new ListViewItem(Convert.ToString(result[0]));
                item.SubItems.Add(Convert.ToString(result[2]));
                item.SubItems.Add(Convert.ToString(result[3]));
                item.SubItems.Add(Convert.ToString(result[4]));
                item.SubItems.Add(Convert.ToString(result[5]));
                item.SubItems.Add(Convert.ToString(result[7]));
                listViewCLI.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bttn_listar_cliente_Click(object sender, EventArgs e)
        {
            
            try
            {
                ListarCliente TelaListarCliente = new ListarCliente(Convert.ToInt32(tb_listar_cliente_cod.Text));
                TelaListarCliente.Show();
            }
            catch (Exception ERR) { MessageBox.Show(ERR.ToString(), "ERRO DE ENTRADA" ); }

        }


    }
}
