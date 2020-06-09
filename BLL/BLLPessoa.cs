using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Net.Mail;

/* Business Logic Layer*/
namespace BLL
{
    public class BLLPessoa
    {
        private DALPessoa DALpessoa;

        public BLLPessoa( DALConexao cx)
        {
            this.DALpessoa = new DALPessoa(cx);
        }

        public void Incluir(MODELOPessoa modelo)
        {
            try
            {
                string strPadrao = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(modelo.Email, strPadrao))
                {
                    throw new ArgumentNullException("Email", "E-mail Invalido");
                }
                string strPadraoCpf = "([0-9]{2}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[\\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[-]?[0-9]{2})";
                if (!System.Text.RegularExpressions.Regex.IsMatch(modelo.Cpf, strPadraoCpf))
                {
                    throw new ArgumentNullException("CPF", "CPF Invalido");
                }
                if (modelo.Nome == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.Sexo == "")
                {
                    throw new ArgumentNullException("Sexo", "Entrada deve ser apenas M ou F.");
                }
                if (modelo.Endereco == "")
                {
                    throw new ArgumentNullException("Endereco", "Entrada não pode ser vazia.");
                }
                if (modelo.Telefone == "")
                {
                    throw new ArgumentNullException("Telefone", "Entrada não pode ser vazia.");
                }
                int anos = (int)modelo.DataNascimento.Subtract(DateTime.Today).TotalDays / 365;
                if ((-1 * anos) < 18)
                {
                    throw new ArgumentNullException("Idade", "Idade deve ser maior que 18 anos");
                }

                DALpessoa.Incluir(modelo);
                
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(MODELOPessoa modelo)
        {

            try
            {
                string strPadrao = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(modelo.Email, strPadrao))
                {
                    throw new ArgumentNullException("Email", "E-mail Invalido");
                }
                string strPadraoCpf = "([0-9]{2}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[\\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\\.]?[0-9]{3}[\\.]?[0-9]{3}[-]?[0-9]{2})";
                if (!System.Text.RegularExpressions.Regex.IsMatch(modelo.Cpf, strPadraoCpf))
                {
                    throw new ArgumentNullException("CPF", "CPF Invalido");
                }
                if (modelo.Nome == "")
                {
                    throw new ArgumentNullException("Nome", "Nao pode ser vazio.");
                }
                if (modelo.Sexo == "")
                {
                    throw new ArgumentNullException("Sexo", "Entrada deve ser apenas M ou F.");
                }
                if (modelo.Endereco == "")
                {
                    throw new ArgumentNullException("Endereco", "Entrada não pode ser vazia.");
                }
                if (modelo.Telefone == "")
                {
                    throw new ArgumentNullException("Telefone", "Entrada não pode ser vazia.");
                }
                int anos = (int)modelo.DataNascimento.Subtract(DateTime.Today).TotalDays / 365;
                if ((-1 * anos) < 18)
                {
                    throw new ArgumentNullException("Idade", "Idade deve ser maior que 18 anos");
                }

                DALpessoa.Alterar(modelo);
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(int codigo)
        {
            if (codigo <= 0)
            {
                throw new ArgumentNullException("ID", "Para deletar código, não pode estar zerado!");
            }
            DALpessoa.Excluir(codigo);
           
        }

        public DataTable Localizar(string texto)
        {
            return DALpessoa.Localizar(texto);
        }

    }
}
