using BLL;
using DAL;
using MODELO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PadraoDeProjetoEmCamadas
{
    public partial class Localizar : Form
    {

        public MODELOPessoa modelpessoa;
        public Localizar()
        {
            InitializeComponent();
        }

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao cx = new DALConexao(dc.StringDeConexao);

            BLLPessoa bllpessoa = new BLLPessoa(cx);
            DataTable tabela = bllpessoa.Localizar(TXTBuscar.Text);
            DGVDados.DataSource = tabela;
        }

        private void DGVDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            this.modelpessoa = new MODELOPessoa();

            this.modelpessoa.Id = Convert.ToInt32(DGVDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.modelpessoa.Nome = DGVDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.modelpessoa.Sexo = DGVDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            DateTime data = Convert.ToDateTime(DGVDados.Rows[e.RowIndex].Cells[3].Value.ToString());
            this.modelpessoa.DataNascimento = data;
            this.modelpessoa.Endereco = DGVDados.Rows[e.RowIndex].Cells[4].Value.ToString();
            this.modelpessoa.Email = DGVDados.Rows[e.RowIndex].Cells[5].Value.ToString();
            this.modelpessoa.Cpf = DGVDados.Rows[e.RowIndex].Cells[6].Value.ToString();
            this.modelpessoa.Telefone = DGVDados.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.modelpessoa.Descricao = DGVDados.Rows[e.RowIndex].Cells[8].Value.ToString();

            this.Close();

        }

        
    }
}
