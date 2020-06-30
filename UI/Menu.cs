using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PadraoDeProjetoEmCamadas
{
    public partial class Menu : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Menu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNRestaurar.Visible = false;
            BTNMaximizar.Visible = true;
        }
        private void BTNMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNRestaurar.Visible = true;
        }
        
        private void BTNCadastro_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Cadastro>();
        }

        private void BTNAjuda_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Ajuda>();
        }

        private void BTNContato_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Contato>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<SobreNos>();
        }

        private void Relatorios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Relatorio>();
        }
    } 
}
