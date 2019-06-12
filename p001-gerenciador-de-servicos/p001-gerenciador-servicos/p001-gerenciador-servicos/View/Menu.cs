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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cLIENTESToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pROFISSIONAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                ActiveMdiChild.Close();
            }

            Profissionais TelaProfissionais = new Profissionais();
            TelaProfissionais.MdiParent = this;
            TelaProfissionais.Show();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                ActiveMdiChild.Close();
            }

            CadCliente TelaCadCliente = new CadCliente();
            TelaCadCliente.MdiParent = this;
            TelaCadCliente.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void lISTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 0)
            {
                ActiveMdiChild.Close();
            }

            ListarClientes TelaListarClientes = new ListarClientes();
            TelaListarClientes.MdiParent = this;
            TelaListarClientes.Show();

        }

        public void listarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
