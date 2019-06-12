using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p001_gerenciador_servicos
{
    class Cliente
    {
        private int     codigo;
        private string  nome;
        private string  snome;
        private string  cpf;
        private string  email;
        private string  telefone;
        private string  celular;
        private string  cidade;
        private string  endereco;
        private string  numero;
        private string  complemento;

        public Cliente(int codigo, string[] dados) {
            this.nome = dados[0];
            this.snome = dados[1];
            this.cpf = dados[2];
            this.email = dados[3];
            this.telefone = dados[4];
            this.celular = dados[5];
            this.cidade = dados[6];
            this.endereco = dados[7];
            this.numero = dados[8];
            this.complemento = dados[9];
        }


    }
}
