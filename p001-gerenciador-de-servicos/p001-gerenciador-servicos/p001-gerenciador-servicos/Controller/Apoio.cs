using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p001_gerenciador_servicos
{
    class Apoio
    {
        public static Array construirArray(params string[] values)
        {
            return values;
        }

        public static string construirDados(string[] a_dados)
        {
            string s_dados = "";

            for (int i = 0; i < a_dados.Length; i++)
            {
                if (i == 0)
                {
                    s_dados = "'" + Convert.ToString(a_dados[i]) + "'";
                }
                else
                {
                    s_dados = s_dados + ", " + " '" + Convert.ToString(a_dados[i]) + "'";
                }
            }

            return s_dados;
        }

        public static int validarEmail(string email)
        {
            int cod = 0;
            Conexao con = new Conexao();
            SqlCommand cursor;
            cursor = new SqlCommand("SELECT FUNC_COD, FUNC_EMAIL FROM FUNCIONARIOS WHERE FUNC_EMAIL = @email", con.conectar());
			cursor.Parameters.AddWithValue("email", email );
            SqlDataReader result = cursor.ExecuteReader();
            if (result.Read())
            {
                cod = Convert.ToInt32(result[0]);
            }
            return cod;

        }

        public static bool validarSenha(int cod,string senha)
        {
            bool estado = false;
            Conexao con = new Conexao();
            SqlCommand cursor;
            cursor = new SqlCommand("SELECT FUNC_SENHA FROM FUNCIONARIOS WHERE FUNC_COD = @cod", con.conectar());
            cursor.Parameters.AddWithValue("cod", cod);
            SqlDataReader result = cursor.ExecuteReader();
            if (result.Read()) {
                if (senha == result[0].ToString())
                {
                    estado = true;
                }
            }
            return estado;
        }

        public static string campo_obrigatorio()
        {
            return "Campo obrigatorio não preenchido!";
        }

        


    }
}
