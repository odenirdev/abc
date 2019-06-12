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
    public partial class CadCliente : Form
    {
        public CadCliente()
        {
            InitializeComponent();
        }

        private void bttn_cadcliente_Click(object sender, EventArgs e)
        {

            if (validarCamposClientes())
            {
                try
                {
                    string[] dados = new string[] { mtb_nome.Text, mtb_snome.Text, mtb_cpf.Text, mtb_email.Text, mtb_telefone.Text, mtb_celular.Text, mtb_cidade.Text, mtb_endereco.Text, mtb_numero.Text, mtb_complemento.Text };


                if (Crud.cadastrar("CLIENTES", dados))
                    {
                        MessageBox.Show("Cadastro de cliente efetuado!", "CADASTRO DE CLIENTE");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ERR)
                {
                    MessageBox.Show("Erro no cadastro de cliente! Tente novamente!", "CADASTRO DE CLIENTE");
                }

                this.Close();
            }

           
        }

        private void tb_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private bool validarCamposClientes()
        {
            bool estado = false; 

            if (mtb_nome.Text == "")
            {
                lb_nome_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_nome_err.Text = "*";
            }

            if (mtb_snome.Text == "")
            {
                lb_snome_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_snome_err.Text = "*";
            }

            if (mtb_cpf.Text == "   ,   ,   -")
            {
                lb_cpf_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_cpf_err.Text = "*";
            }

            if (mtb_email.Text == "")
            {
                lb_email_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_email_err.Text = "*";
            }

            if (mtb_celular.Text == "(  )       -")
            {
                lb_celular_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_celular_err.Text = "*";
            }

            if (mtb_cidade.Text == "")
            {
                lb_cidade_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_cidade_err.Text = "*";
            }

            if (mtb_endereco.Text == "")
            {
                lb_endereco_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_endereco_err.Text = "*";
            }

            if (mtb_numero.Text == "")
            {
                lb_numero_err.Text = Apoio.campo_obrigatorio();
            }
            else
            {
                lb_numero_err.Text = "*";
            }

            if (lb_nome_err.Text != Apoio.campo_obrigatorio())
            {
                if (lb_snome_err.Text != Apoio.campo_obrigatorio())
                {
                    if (lb_cpf_err.Text != Apoio.campo_obrigatorio())
                    {
                        if (lb_email_err.Text != Apoio.campo_obrigatorio())
                        {
                            if (lb_celular_err.Text != Apoio.campo_obrigatorio())
                            {
                                if (lb_cidade_err.Text != Apoio.campo_obrigatorio())
                                {
                                    if (lb_endereco_err.Text != Apoio.campo_obrigatorio())
                                    {
                                        if (lb_numero_err.Text != Apoio.campo_obrigatorio())
                                        {
                                            estado = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return estado;
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            mtb_cpf.Mask = "999.999.999-99";
            mtb_telefone.Mask = "(99) 9 0000-0000";
            mtb_celular.Mask = "(99) 9 0000-0000";
        }
    }
}
