using BLL;
using DAL;
using Microsoft.Reporting.WinForms;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class Relatorio : Form
    {
        public MODELOPessoa modelpessoa;
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            string connstr = "server=remotemysql.com;port=3306;user=nPq2IsXovm;password=CHRDAMjPRh;database=nPq2IsXovm";
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                string sql = "SELECT id, Nome, Sexo, Nascimento, Endereco, Email, CPF, Telefone, Descricao  FROM Pessoa";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<MODELOPessoa> lrp = new List<MODELOPessoa>();
                while (rdr.Read())
                {
                    MODELOPessoa rt = new MODELOPessoa();
                    rt.Id = Convert.ToInt32(rdr[0].ToString());
                    rt.Nome = rdr[1].ToString();
                    rt.Sexo = rdr[2].ToString();
                    DateTime data = Convert.ToDateTime(rdr[3].ToString());
                    rt.DataNascimento = data;
                    rt.Endereco = rdr[4].ToString();
                    rt.Email = rdr[5].ToString();
                    rt.Cpf = rdr[6].ToString();
                    rt.Telefone = rdr[7].ToString();
                    rt.Descricao = rdr[8].ToString();


                    lrp.Add(rt);


                }
                rdr.Close();
                ReportDataSource rds = new ReportDataSource("DataSet1", lrp);
                this.reportViewer1.LocalReport.ReportEmbeddedResource = "PadraoDeProjetoEmCamadas.Relatorio.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
