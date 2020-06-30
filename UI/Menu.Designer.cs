namespace PadraoDeProjetoEmCamadas
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNRestaurar = new System.Windows.Forms.Button();
            this.BTNMaximizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Relatorios = new System.Windows.Forms.Button();
            this.BTNLocalizar = new System.Windows.Forms.Button();
            this.BTNDeletar = new System.Windows.Forms.Button();
            this.BTNAlterar = new System.Windows.Forms.Button();
            this.BTNCadastro = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCabecalho.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Controls.Add(this.BTNRestaurar);
            this.panelCabecalho.Controls.Add(this.BTNMaximizar);
            this.panelCabecalho.Controls.Add(this.btnFechar);
            this.panelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(800, 40);
            this.panelCabecalho.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(51, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sistema de Cadastro";
            // 
            // BTNRestaurar
            // 
            this.BTNRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNRestaurar.FlatAppearance.BorderSize = 0;
            this.BTNRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BTNRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BTNRestaurar.Image")));
            this.BTNRestaurar.Location = new System.Drawing.Point(665, 3);
            this.BTNRestaurar.Name = "BTNRestaurar";
            this.BTNRestaurar.Size = new System.Drawing.Size(40, 34);
            this.BTNRestaurar.TabIndex = 0;
            this.BTNRestaurar.UseVisualStyleBackColor = true;
            this.BTNRestaurar.Click += new System.EventHandler(this.BTNRestaurar_Click);
            // 
            // BTNMaximizar
            // 
            this.BTNMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNMaximizar.FlatAppearance.BorderSize = 0;
            this.BTNMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTNMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BTNMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BTNMaximizar.Image")));
            this.BTNMaximizar.Location = new System.Drawing.Point(711, 3);
            this.BTNMaximizar.Name = "BTNMaximizar";
            this.BTNMaximizar.Size = new System.Drawing.Size(40, 34);
            this.BTNMaximizar.TabIndex = 0;
            this.BTNMaximizar.UseVisualStyleBackColor = true;
            this.BTNMaximizar.Click += new System.EventHandler(this.BTNMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(757, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 34);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelMenu.Controls.Add(this.Relatorios);
            this.panelMenu.Controls.Add(this.BTNLocalizar);
            this.panelMenu.Controls.Add(this.BTNDeletar);
            this.panelMenu.Controls.Add(this.BTNAlterar);
            this.panelMenu.Controls.Add(this.BTNCadastro);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(136, 505);
            this.panelMenu.TabIndex = 2;
            // 
            // Relatorios
            // 
            this.Relatorios.FlatAppearance.BorderSize = 0;
            this.Relatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.Relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Relatorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Relatorios.ForeColor = System.Drawing.Color.White;
            this.Relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Relatorios.Location = new System.Drawing.Point(3, 399);
            this.Relatorios.Name = "Relatorios";
            this.Relatorios.Size = new System.Drawing.Size(130, 39);
            this.Relatorios.TabIndex = 5;
            this.Relatorios.Text = "Relatorios";
            this.Relatorios.UseVisualStyleBackColor = true;
            this.Relatorios.Click += new System.EventHandler(this.Relatorios_Click);
            // 
            // BTNLocalizar
            // 
            this.BTNLocalizar.FlatAppearance.BorderSize = 0;
            this.BTNLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLocalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLocalizar.ForeColor = System.Drawing.Color.White;
            this.BTNLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNLocalizar.Location = new System.Drawing.Point(3, 162);
            this.BTNLocalizar.Name = "BTNLocalizar";
            this.BTNLocalizar.Size = new System.Drawing.Size(130, 39);
            this.BTNLocalizar.TabIndex = 4;
            this.BTNLocalizar.Text = "Sobre nós";
            this.BTNLocalizar.UseVisualStyleBackColor = true;
            this.BTNLocalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTNDeletar
            // 
            this.BTNDeletar.FlatAppearance.BorderSize = 0;
            this.BTNDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeletar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDeletar.ForeColor = System.Drawing.Color.White;
            this.BTNDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNDeletar.Location = new System.Drawing.Point(3, 322);
            this.BTNDeletar.Name = "BTNDeletar";
            this.BTNDeletar.Size = new System.Drawing.Size(130, 39);
            this.BTNDeletar.TabIndex = 3;
            this.BTNDeletar.Text = "Contato";
            this.BTNDeletar.UseVisualStyleBackColor = true;
            this.BTNDeletar.Click += new System.EventHandler(this.BTNContato_Click);
            // 
            // BTNAlterar
            // 
            this.BTNAlterar.FlatAppearance.BorderSize = 0;
            this.BTNAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAlterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAlterar.ForeColor = System.Drawing.Color.White;
            this.BTNAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNAlterar.Location = new System.Drawing.Point(3, 243);
            this.BTNAlterar.Name = "BTNAlterar";
            this.BTNAlterar.Size = new System.Drawing.Size(130, 39);
            this.BTNAlterar.TabIndex = 2;
            this.BTNAlterar.Text = "Ajuda";
            this.BTNAlterar.UseVisualStyleBackColor = true;
            this.BTNAlterar.Click += new System.EventHandler(this.BTNAjuda_Click);
            // 
            // BTNCadastro
            // 
            this.BTNCadastro.FlatAppearance.BorderSize = 0;
            this.BTNCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.BTNCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCadastro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCadastro.ForeColor = System.Drawing.Color.White;
            this.BTNCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCadastro.Location = new System.Drawing.Point(3, 86);
            this.BTNCadastro.Name = "BTNCadastro";
            this.BTNCadastro.Size = new System.Drawing.Size(130, 39);
            this.BTNCadastro.TabIndex = 1;
            this.BTNCadastro.Text = "Cadastrar";
            this.BTNCadastro.UseVisualStyleBackColor = true;
            this.BTNCadastro.Click += new System.EventHandler(this.BTNCadastro_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.BackgroundImage = global::PadraoDeProjetoEmCamadas.Properties.Resources.enfermagem_3_152321;
            this.panelConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelConteudo.Controls.Add(this.pictureBox1);
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(136, 40);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(664, 505);
            this.panelConteudo.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(580, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNRestaurar;
        private System.Windows.Forms.Button BTNMaximizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BTNDeletar;
        private System.Windows.Forms.Button BTNAlterar;
        private System.Windows.Forms.Button BTNCadastro;
        private System.Windows.Forms.Button BTNLocalizar;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Relatorios;
    }
}