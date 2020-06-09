using System;using System.Collections.Generic;using System.Linq;using System.Text;using System.Threading.Tasks;using MODELO;using MySql.Data.MySqlClient;using System.Data;namespace DAL{    /* Data Access Layer para a tabela pessoa*/    public class DALPessoa    {        private DALConexao conexao;        public DALPessoa (DALConexao cx)        {            conexao = cx;        }        public void Incluir (MODELOPessoa modelo)        {            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO Pessoa (id, Nome, Sexo, Nascimento, Endereco, Email, CPF, Telefone, Descricao)" +
                    "VALUES (NULL , @nome, @sexo, @dt, @endereco, @email, @cpf, @telefone, @descricao);" +
                    "SELECT MAX(ID) FROM Pessoa;";
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
                cmd.Parameters.AddWithValue("@dt", modelo.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);

                conexao.Conectar();
                int idInserido = Convert.ToInt32(cmd.ExecuteScalar());
                modelo.Id = idInserido;
            }            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }        }        public void Alterar(MODELOPessoa modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE Pessoa SET Nome = @nome," +
                                  " Sexo = @sexo," +
                                  " Nascimento = @dt," +
                                  " Endereco = @endereco," +
                                  " Email = @email," +
                                  " CPF = @cpf," +
                                  " Telefone = @telefone," +
                                  " Descricao = @descricao" +
                                  " WHERE " +
                                  " id = @id";
                string data = modelo.DataNascimento.ToString("yyyy-MM-dd HH:mm:ss");
                cmd.Parameters.AddWithValue("@nome", modelo.Nome);
                cmd.Parameters.AddWithValue("@sexo", modelo.Sexo);
                cmd.Parameters.AddWithValue("@dt", data);
                cmd.Parameters.AddWithValue("@endereco", modelo.Endereco);
                cmd.Parameters.AddWithValue("@email", modelo.Email);
                cmd.Parameters.AddWithValue("@cpf", modelo.Cpf);
                cmd.Parameters.AddWithValue("@telefone", modelo.Telefone);
                cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
                cmd.Parameters.AddWithValue("@id", modelo.Id);


                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = this.conexao.ObjetoConexao;

                cmd.CommandText = "DELETE FROM Pessoa WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", codigo);
                this.conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.conexao.Desconectar();
            }
        }        public DataTable Localizar(string texto)
        {
            DataTable tabela = new DataTable();
            string SQL = "SELECT * FROM Pessoa WHERE nome LIKE '%" + texto + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(SQL, this.conexao.ObjetoConexao);
            adapter.Fill(tabela);

            return tabela;
        }    }}