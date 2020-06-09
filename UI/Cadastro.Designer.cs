namespace PadraoDeProjetoEmCamadas
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.TXTNome = new System.Windows.Forms.TextBox();
            this.DTPNascimento = new System.Windows.Forms.DateTimePicker();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.TXTCPF = new System.Windows.Forms.TextBox();
            this.BTNInserir = new System.Windows.Forms.Button();
            this.CB_Sexo = new System.Windows.Forms.ComboBox();
            this.TXTEND = new System.Windows.Forms.TextBox();
            this.TXTTEL = new System.Windows.Forms.TextBox();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.BTNFechar = new System.Windows.Forms.Button();
            this.TXTDescricao = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNAlterar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.BTNDeletar = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BTNLimpaCPF = new System.Windows.Forms.Button();
            this.BTNLimpaTel = new System.Windows.Forms.Button();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTNome
            // 
            this.TXTNome.BackColor = System.Drawing.Color.White;
            this.TXTNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TXTNome.Location = new System.Drawing.Point(135, 46);
            this.TXTNome.Name = "TXTNome";
            this.TXTNome.Size = new System.Drawing.Size(284, 23);
            this.TXTNome.TabIndex = 0;
            // 
            // DTPNascimento
            // 
            this.DTPNascimento.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNascimento.Location = new System.Drawing.Point(135, 104);
            this.DTPNascimento.Name = "DTPNascimento";
            this.DTPNascimento.Size = new System.Drawing.Size(284, 24);
            this.DTPNascimento.TabIndex = 2;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(135, 163);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(284, 23);
            this.TXTEmail.TabIndex = 3;
            // 
            // TXTCPF
            // 
            this.TXTCPF.Location = new System.Drawing.Point(135, 192);
            this.TXTCPF.MaxLength = 14;
            this.TXTCPF.Name = "TXTCPF";
            this.TXTCPF.Size = new System.Drawing.Size(179, 23);
            this.TXTCPF.TabIndex = 4;
            this.TXTCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCPF_KeyPress);
            // 
            // BTNInserir
            // 
            this.BTNInserir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNInserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTNInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNInserir.Location = new System.Drawing.Point(8, 466);
            this.BTNInserir.Name = "BTNInserir";
            this.BTNInserir.Size = new System.Drawing.Size(87, 27);
            this.BTNInserir.TabIndex = 10;
            this.BTNInserir.Text = "Cadastrar";
            this.BTNInserir.UseVisualStyleBackColor = false;
            this.BTNInserir.Click += new System.EventHandler(this.BTNInserir_Click);
            // 
            // CB_Sexo
            // 
            this.CB_Sexo.FormattingEnabled = true;
            this.CB_Sexo.Location = new System.Drawing.Point(135, 75);
            this.CB_Sexo.Name = "CB_Sexo";
            this.CB_Sexo.Size = new System.Drawing.Size(122, 23);
            this.CB_Sexo.TabIndex = 11;
            this.CB_Sexo.Text = "Genero";
            // 
            // TXTEND
            // 
            this.TXTEND.Location = new System.Drawing.Point(135, 134);
            this.TXTEND.Name = "TXTEND";
            this.TXTEND.Size = new System.Drawing.Size(284, 23);
            this.TXTEND.TabIndex = 15;
            // 
            // TXTTEL
            // 
            this.TXTTEL.Location = new System.Drawing.Point(135, 221);
            this.TXTTEL.MaxLength = 14;
            this.TXTTEL.Name = "TXTTEL";
            this.TXTTEL.Size = new System.Drawing.Size(179, 23);
            this.TXTTEL.TabIndex = 16;
            this.TXTTEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTTEL_KeyPress);
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelCabecalho.Controls.Add(this.BTNFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(478, 40);
            this.panelCabecalho.TabIndex = 17;
            // 
            // BTNFechar
            // 
            this.BTNFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNFechar.FlatAppearance.BorderSize = 0;
            this.BTNFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BTNFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNFechar.Image = ((System.Drawing.Image)(resources.GetObject("BTNFechar.Image")));
            this.BTNFechar.Location = new System.Drawing.Point(435, 3);
            this.BTNFechar.Name = "BTNFechar";
            this.BTNFechar.Size = new System.Drawing.Size(40, 34);
            this.BTNFechar.TabIndex = 0;
            this.BTNFechar.UseVisualStyleBackColor = true;
            this.BTNFechar.Click += new System.EventHandler(this.BTNFechar_Click);
            // 
            // TXTDescricao
            // 
            this.TXTDescricao.BackColor = System.Drawing.Color.White;
            this.TXTDescricao.Location = new System.Drawing.Point(8, 301);
            this.TXTDescricao.Name = "TXTDescricao";
            this.TXTDescricao.Size = new System.Drawing.Size(458, 145);
            this.TXTDescricao.TabIndex = 18;
            this.TXTDescricao.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fale um pouco da pessoa que necessita de ajuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Telefone";
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTNBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNBuscar.Location = new System.Drawing.Point(101, 466);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(87, 27);
            this.BTNBuscar.TabIndex = 27;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = false;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNAlterar
            // 
            this.BTNAlterar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTNAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAlterar.Location = new System.Drawing.Point(194, 466);
            this.BTNAlterar.Name = "BTNAlterar";
            this.BTNAlterar.Size = new System.Drawing.Size(87, 27);
            this.BTNAlterar.TabIndex = 28;
            this.BTNAlterar.Text = "Alterar";
            this.BTNAlterar.UseVisualStyleBackColor = false;
            this.BTNAlterar.Click += new System.EventHandler(this.BTNAlterar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Codigo";
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(135, 250);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 23);
            this.TXTID.TabIndex = 30;
            // 
            // BTNDeletar
            // 
            this.BTNDeletar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.BTNDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeletar.Location = new System.Drawing.Point(379, 466);
            this.BTNDeletar.Name = "BTNDeletar";
            this.BTNDeletar.Size = new System.Drawing.Size(87, 27);
            this.BTNDeletar.TabIndex = 31;
            this.BTNDeletar.Text = "Deletar";
            this.BTNDeletar.UseVisualStyleBackColor = false;
            this.BTNDeletar.Click += new System.EventHandler(this.BTNDeletar_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpar.Location = new System.Drawing.Point(287, 466);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(87, 27);
            this.BTNLimpar.TabIndex = 32;
            this.BTNLimpar.Text = "Cancelar";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(135, 250);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.Visible = false;
            // 
            // BTNLimpaCPF
            // 
            this.BTNLimpaCPF.Location = new System.Drawing.Point(320, 192);
            this.BTNLimpaCPF.Name = "BTNLimpaCPF";
            this.BTNLimpaCPF.Size = new System.Drawing.Size(22, 23);
            this.BTNLimpaCPF.TabIndex = 33;
            this.BTNLimpaCPF.Text = "L";
            this.BTNLimpaCPF.UseVisualStyleBackColor = true;
            this.BTNLimpaCPF.Click += new System.EventHandler(this.BTNLimpaCPF_Click);
            // 
            // BTNLimpaTel
            // 
            this.BTNLimpaTel.Location = new System.Drawing.Point(320, 221);
            this.BTNLimpaTel.Name = "BTNLimpaTel";
            this.BTNLimpaTel.Size = new System.Drawing.Size(22, 23);
            this.BTNLimpaTel.TabIndex = 34;
            this.BTNLimpaTel.Text = "L";
            this.BTNLimpaTel.UseVisualStyleBackColor = true;
            this.BTNLimpaTel.Click += new System.EventHandler(this.BTNLimpaTel_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(478, 505);
            this.Controls.Add(this.BTNLimpaTel);
            this.Controls.Add(this.BTNLimpaCPF);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNDeletar);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BTNAlterar);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTDescricao);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.TXTTEL);
            this.Controls.Add(this.TXTEND);
            this.Controls.Add(this.CB_Sexo);
            this.Controls.Add(this.BTNInserir);
            this.Controls.Add(this.TXTCPF);
            this.Controls.Add(this.TXTEmail);
            this.Controls.Add(this.DTPNascimento);
            this.Controls.Add(this.TXTNome);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cadastro";
            this.Text = "Cadasrtro de Pessoa";
            this.Load += new System.EventHandler(this.FRMPessoa_Load);
            this.panelCabecalho.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox TXTNome;
        protected System.Windows.Forms.DateTimePicker DTPNascimento;
        protected System.Windows.Forms.TextBox TXTEmail;
        protected System.Windows.Forms.TextBox TXTCPF;
        protected System.Windows.Forms.Button BTNInserir;
        protected System.Windows.Forms.ComboBox CB_Sexo;
        protected System.Windows.Forms.TextBox TXTEND;
        protected System.Windows.Forms.TextBox TXTTEL;
        protected System.Windows.Forms.Panel panelCabecalho;
        protected System.Windows.Forms.Button BTNFechar;
        protected System.Windows.Forms.RichTextBox TXTDescricao;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Button BTNBuscar;
        protected System.Windows.Forms.Button BTNAlterar;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.TextBox TXTID;
        protected System.Windows.Forms.Button BTNDeletar;
        protected System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BTNLimpaCPF;
        private System.Windows.Forms.Button BTNLimpaTel;
    }
}

