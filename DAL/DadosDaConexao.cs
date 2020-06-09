using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
/* Data Access Layer*/
namespace DAL
{
    public class DadosDaConexao
    {
        private string server = "remotemysql.com";
        private string port = "3306";
        private string user = "nPq2IsXovm";
        private string pass = "CHRDAMjPRh";
        private string database = "nPq2IsXovm";

        public string StringDeConexao
        {
            get
            {
                return "server=" + this.server + ";" +
                       "port=" + this.port + ";" +
                       "User Id=" + this.user + ";" +
                       "Password=" + this.pass + ";" +
                       "database=" + this.database + ";";
            }
        }
        
    }
}
