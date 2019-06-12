using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p001_gerenciador_servicos
{
    class Crud
    {

        public static string[] infoTabela(string tabela)
        {
            string atributos = "";

            switch (tabela)
            {
                case "CLIENTES":
                    atributos = "FUNC_COD,  CLI_NOME, CLI_SNOME, CLI_CPF, CLI_EMAIL, CLI_TELEFONE, CLI_CELULAR, CLI_CIDADE, CLI_ENDERECO, CLI_CASA, CLI_COMPLEMENTO, CLI_ESTADO ";
                    break;
            }
            return new string[] {atributos, "CLI"};
        }

        public static bool cadastrar(string tabela, string[] dados)
        {
            bool estado = true;
            string s_dados = "";
            s_dados = Apoio.construirDados(dados);
            Conexao con = new Conexao();
            try
            {
                SqlCommand cursor = new SqlCommand("INSERT INTO " + tabela + "(" + infoTabela(tabela)[0] + ") VALUES ( '" + Login.cod_login + "' , " + s_dados + ", 'REGISTRADO')", con.conectar());
                cursor.ExecuteNonQuery();
            
            }
            catch { estado = false; }

            con.desconectar();
            return estado;
        }

        public static SqlDataReader listar(string tabela, int codigo)
        {
            Conexao con = new Conexao();
            SqlCommand cursor = new SqlCommand("SELECT * FROM " + tabela +" WHERE "+ infoTabela(tabela)[1] +"_COD = " + codigo, con.conectar());
            SqlDataReader result = cursor.ExecuteReader();
            con.desconectar();
            return result;
        }

        public static bool deletar(string tabela, int codigo)
        {
            bool estado = false;

            Conexao con = new Conexao();
            SqlCommand cursor = new SqlCommand("DELETE FROM " + tabela + " WHERE " + infoTabela(tabela)[1] + "_COD = " + codigo, con.conectar());

            con.desconectar();
            return estado;
        }
    }
}
