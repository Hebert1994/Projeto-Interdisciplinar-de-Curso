using BLL;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PadraoDeProjetoEmCamadas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            Alterarbnt(1);
        }

        private void BTNFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Alterarbnt(int a)
        {
            //1= Cadastrar || Buscar
            //2= Cadastrar || Alterar
            //3= Alterar || Excluir
            BTNInserir.Enabled = false;
            BTNAlterar.Enabled = false;
            BTNBuscar.Enabled = false;
            BTNDeletar.Enabled = false;
            BTNLimpar.Enabled = false;

            switch (a)
            {

                case 1:

                    BTNInserir.Enabled = true;
                    BTNBuscar.Enabled = true;
                    break;

                case 2:

                    BTNAlterar.Enabled = true;
                    BTNLimpar.Enabled = true;
                    BTNDeletar.Enabled = true;
                    break;

                case 3:

                    
                    break;
            }

        }
        
        public void Popularcampos(MODELOPessoa p)
        {
            if (p != null)
            {
                TXTNome.Text = p.Nome;
                switch (p.Sexo)
                {
                    case "M":
                        CB_Sexo.SelectedItem = "Masculino";
                        break;
                    case "F":
                        CB_Sexo.SelectedItem = "Feminino";
                        break;
                    case "O":
                        CB_Sexo.SelectedItem = "Outro";
                        break;

                }

                DTPNascimento.Text = Convert.ToString(p.DataNascimento);
                TXTEND.Text = p.Endereco;
                TXTEmail.Text = p.Email;
                TXTCPF.Text = p.Cpf;
                TXTTEL.Text = p.Telefone;
                TXTDescricao.Text = p.Descricao;
                TXTID.Text = p.Id.ToString();
            }
            else
            {
                Alterarbnt(1);
            }
        }

        public void LimparCampos()
        {
            TXTNome.Clear();
            CB_Sexo.SelectedItem = null;
            DTPNascimento.Text = "";
            TXTEND.Clear();
            TXTEmail.Clear();
            TXTCPF.Clear();
            TXTTEL.Clear();
            TXTID.Clear();
            TXTDescricao.Clear();
        }

        private void BTNInserir_Click(object sender, EventArgs e)
        {
            try
            {

                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPessoa p = new MODELOPessoa();
                p.Nome = TXTNome.Text;
                p.Descricao = TXTDescricao.Text;
                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);
                p.Endereco = TXTEND.Text;
                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;
                p.Telefone = TXTTEL.Text;


                bllpessoa.Incluir(p);
                TXTID.Text = p.Id.ToString();

                MessageBox.Show("Usuario inserido com sucesso id:" + p.Id);

                if (p != null)
                {
                    try
                    {
                        Enviar enviar = new Enviar();
                        enviar.Envio(TXTNome.Text, TXTTEL.Text, TXTEND.Text, TXTDescricao.Text);
                        MessageBox.Show("certo ao enviar");
                    }
                    catch
                    {
                        MessageBox.Show("erro ao enviar");
                    }
                }

                LimparCampos();

            }

            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
            Alterarbnt(1);
        }

        private void FRMPessoa_Load(object sender, EventArgs e)
        {
            CB_Sexo.Items.Add("Masculino");
            CB_Sexo.Items.Add("Feminino");
            CB_Sexo.Items.Add("Outros");
        }

        public void BTNBuscar_Click(object sender, EventArgs e)
        {
            Localizar L = new Localizar();
            L.BringToFront();
            L.ShowDialog();
            Popularcampos(L.modelpessoa);
                
            Alterarbnt(2);
        }

        private void BTNAlterar_Click(object sender, EventArgs e)
        {

            try
            {

                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);

                BLLPessoa bllpessoa = new BLLPessoa(cx);

                MODELOPessoa p = new MODELOPessoa();
                p.Nome = TXTNome.Text;
                p.Descricao = TXTDescricao.Text;
                switch (CB_Sexo.SelectedItem.ToString())
                {
                    case "Masculino":
                        p.Sexo = "M";
                        break;
                    case "Feminino":
                        p.Sexo = "F";
                        break;
                    case "Outro":
                        p.Sexo = "O";
                        break;
                }
                p.DataNascimento = new DateTime(DTPNascimento.Value.Year,
                    DTPNascimento.Value.Month,
                    DTPNascimento.Value.Day);
                p.Endereco = TXTEND.Text;
                p.Email = TXTEmail.Text;
                p.Cpf = TXTCPF.Text;
                p.Telefone = TXTTEL.Text;
                p.Id = Convert.ToInt32(TXTID.Text);

                bllpessoa.Alterar(p);


                MessageBox.Show("Usuario alterado com sucesso");

                if (p!= null)
                {
                    try
                    {
                        Enviar enviar = new Enviar();
                        enviar.Envio(TXTNome.Text, TXTTEL.Text, TXTEND.Text, TXTDescricao.Text);
                        MessageBox.Show("Certo ao enviar");
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao enviar");
                    }
                }

                LimparCampos();

            }

            catch (MySqlException ex)
            {
                if (ex.Message.Contains("Duplicate"))
                {
                    MessageBox.Show("Registro já existe no banco de dados");
                }
                else
                {
                    MessageBox.Show("Falha ao alterar errro:" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao alterar errro geral:" + ex.Message);
            }
            Alterarbnt(1);
        }

        private void BTNDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao dc = new DadosDaConexao();
                DALConexao cx = new DALConexao(dc.StringDeConexao);
                BLLPessoa bllpessoa = new BLLPessoa(cx);
                bllpessoa.Excluir(Convert.ToInt32(TXTID.Text));
                MessageBox.Show("Usuario excluido com sucesso.");

                LimparCampos();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Falha ao excluir erro:" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir erro geral:" + ex.Message);
            }

            Alterarbnt(1);
        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Alterarbnt(1);
        }

        private void TXTCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            //verificar se a tecla precionada é número
            //ref = https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                // 111.222.333-11
                t.SelectionStart = t.Text.Length + 1;
                if (t.Text.Length == 3 || t.Text.Length == 7)
                    t.Text += ".";
                else if (t.Text.Length == 11)
                    t.Text += "-";

                t.SelectionStart = t.Text.Length + 1;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TXTTEL_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            //verificar se a tecla precionada é número
            //ref = https://web.fe.up.pt/~ee96100/projecto/Tabela%20ascii.htm
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                // (00) 99999-9999
                t.SelectionStart = t.Text.Length + 1;
                if (t.Text.Length == 0)
                    t.Text += "(";
                else if (t.Text.Length == 3)
                    t.Text += ") ";
                else if (t.Text.Length == 10)
                    t.Text += "-";

                t.SelectionStart = t.Text.Length + 1;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BTNLimpaCPF_Click(object sender, EventArgs e)
        {
            TXTCPF.Clear();
        }

        private void BTNLimpaTel_Click(object sender, EventArgs e)
        {
            TXTTEL.Clear();
        }
    }
}
