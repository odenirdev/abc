using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace p001_gerenciador_servicos
{
    class Relatorios
    {

        public static SqlDataReader listarTodos(string tabela)
        {
            Conexao conexao = new Conexao();
            SqlCommand cursor = new SqlCommand("SELECT * FROM " + tabela, conexao.conectar());
            SqlDataReader result = cursor.ExecuteReader();
            return result;
        }

    }
}
