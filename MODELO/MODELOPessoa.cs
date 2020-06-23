using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MODELO
{
    public class MODELOPessoa
    {
        /*Atributos da tabela Pessoa*/
        private Int32 id;
        private string nome;
        private string sexo;
        private DateTime dataNascimento;
        private string endereco;
        private string email;
        private string cpf;
        private string telefone;
        private string descricao;
       
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }
        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }
        public string Descricao
        {
            get
            {
                return descricao;
            }


            set
            {
                descricao = value;
            }
        }
    }
}
