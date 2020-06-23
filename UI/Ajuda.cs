using BLL;
using DAL;
using MODELO;
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
    public partial class Ajuda : Form
    {
        public MODELOPessoa modelpessoa;
        public Ajuda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
