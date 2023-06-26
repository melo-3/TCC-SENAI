namespace Almoxarifado_TCC
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconVoltar = new FontAwesome.Sharp.IconButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.lblSenha = new System.Windows.Forms.LinkLabel();
            this.lineCPF = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lineSenha = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblAviso = new System.Windows.Forms.Label();
            this.iconAviso = new FontAwesome.Sharp.IconPictureBox();
            this.iconOlho = new FontAwesome.Sharp.IconButton();
            this.panelTela = new System.Windows.Forms.Panel();
            this.lblSenha1 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.tmLogoExpandir = new System.Windows.Forms.Timer(this.components);
            this.tmLogoRetrair = new System.Windows.Forms.Timer(this.components);
            this.tmTelaE = new System.Windows.Forms.Timer(this.components);
            this.tmTelaD = new System.Windows.Forms.Timer(this.components);
            this.tmLogoExpandir2 = new System.Windows.Forms.Timer(this.components);
            this.tmLogoRetrair2 = new System.Windows.Forms.Timer(this.components);
            this.tmESenha = new System.Windows.Forms.Timer(this.components);
            this.tmNovaSE = new System.Windows.Forms.Timer(this.components);
            this.tmNovaSD = new System.Windows.Forms.Timer(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).BeginInit();
            this.panelTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.panelLogo.Controls.Add(this.iconVoltar);
            this.panelLogo.Controls.Add(this.Logo);
            this.panelLogo.Controls.Add(this.lblSenha);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 330);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // iconVoltar
            // 
            this.iconVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconVoltar.FlatAppearance.BorderSize = 0;
            this.iconVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconVoltar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVoltar.IconSize = 30;
            this.iconVoltar.Location = new System.Drawing.Point(84, 282);
            this.iconVoltar.Name = "iconVoltar";
            this.iconVoltar.Size = new System.Drawing.Size(75, 28);
            this.iconVoltar.TabIndex = 1;
            this.iconVoltar.UseVisualStyleBackColor = true;
            this.iconVoltar.Visible = false;
            this.iconVoltar.Click += new System.EventHandler(this.iconVoltar_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(33, 87);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(178, 143);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Logo_MouseDown);
            // 
            // lblSenha
            // 
            this.lblSenha.ActiveLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Candara", 8.25F);
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSenha.Location = new System.Drawing.Point(75, 291);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(0, 13);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Visible = false;
            this.lblSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lineCPF
            // 
            this.lineCPF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineCPF.Location = new System.Drawing.Point(57, 103);
            this.lineCPF.Name = "lineCPF";
            this.lineCPF.Size = new System.Drawing.Size(408, 2);
            this.lineCPF.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuario.Location = new System.Drawing.Point(56, 81);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(408, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "CPF";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSenha.Location = new System.Drawing.Point(57, 140);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(388, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lineSenha
            // 
            this.lineSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineSenha.Location = new System.Drawing.Point(57, 162);
            this.lineSenha.Name = "lineSenha";
            this.lineSenha.Size = new System.Drawing.Size(408, 2);
            this.lineSenha.TabIndex = 4;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.lblLogin.Font = new System.Drawing.Font("Candara", 20F);
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLogin.Location = new System.Drawing.Point(218, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(89, 33);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 8.25F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(57, 234);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(408, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "AVANÇAR";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(736, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(757, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.lblAviso.Font = new System.Drawing.Font("Candara", 8.25F);
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAviso.Location = new System.Drawing.Point(87, 190);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(31, 13);
            this.lblAviso.TabIndex = 12;
            this.lblAviso.Text = "Error";
            this.lblAviso.Visible = false;
            // 
            // iconAviso
            // 
            this.iconAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.iconAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAviso.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAviso.Location = new System.Drawing.Point(57, 181);
            this.iconAviso.Name = "iconAviso";
            this.iconAviso.Size = new System.Drawing.Size(32, 33);
            this.iconAviso.TabIndex = 13;
            this.iconAviso.TabStop = false;
            this.iconAviso.Visible = false;
            // 
            // iconOlho
            // 
            this.iconOlho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.iconOlho.FlatAppearance.BorderSize = 0;
            this.iconOlho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconOlho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
            this.iconOlho.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconOlho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOlho.IconSize = 30;
            this.iconOlho.Location = new System.Drawing.Point(446, 139);
            this.iconOlho.Name = "iconOlho";
            this.iconOlho.Size = new System.Drawing.Size(25, 23);
            this.iconOlho.TabIndex = 14;
            this.iconOlho.UseVisualStyleBackColor = false;
            this.iconOlho.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTela
            // 
            this.panelTela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.panelTela.Controls.Add(this.lblSenha1);
            this.panelTela.Controls.Add(this.lblCPF);
            this.panelTela.Controls.Add(this.lblLogin);
            this.panelTela.Controls.Add(this.iconOlho);
            this.panelTela.Controls.Add(this.btnLogin);
            this.panelTela.Controls.Add(this.iconAviso);
            this.panelTela.Controls.Add(this.txtSenha);
            this.panelTela.Controls.Add(this.lineCPF);
            this.panelTela.Controls.Add(this.txtUsuario);
            this.panelTela.Controls.Add(this.lblAviso);
            this.panelTela.Controls.Add(this.lineSenha);
            this.panelTela.Location = new System.Drawing.Point(250, 0);
            this.panelTela.Name = "panelTela";
            this.panelTela.Size = new System.Drawing.Size(530, 330);
            this.panelTela.TabIndex = 15;
            // 
            // lblSenha1
            // 
            this.lblSenha1.AutoSize = true;
            this.lblSenha1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSenha1.ForeColor = System.Drawing.Color.DimGray;
            this.lblSenha1.Location = new System.Drawing.Point(54, 120);
            this.lblSenha1.Name = "lblSenha1";
            this.lblSenha1.Size = new System.Drawing.Size(54, 17);
            this.lblSenha1.TabIndex = 26;
            this.lblSenha1.Text = "SENHA";
            this.lblSenha1.Visible = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCPF.ForeColor = System.Drawing.Color.DimGray;
            this.lblCPF.Location = new System.Drawing.Point(53, 61);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 17);
            this.lblCPF.TabIndex = 25;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Visible = false;
            // 
            // tmLogoExpandir
            // 
            this.tmLogoExpandir.Interval = 1;
            this.tmLogoExpandir.Tick += new System.EventHandler(this.tmLogoExpandir_Tick);
            // 
            // tmLogoRetrair
            // 
            this.tmLogoRetrair.Interval = 1;
            this.tmLogoRetrair.Tick += new System.EventHandler(this.tmLogoRetrair_Tick);
            // 
            // tmTelaE
            // 
            this.tmTelaE.Interval = 1;
            this.tmTelaE.Tick += new System.EventHandler(this.tmTelaE_Tick);
            // 
            // tmTelaD
            // 
            this.tmTelaD.Interval = 1;
            this.tmTelaD.Tick += new System.EventHandler(this.tmTelaD_Tick);
            // 
            // tmLogoExpandir2
            // 
            this.tmLogoExpandir2.Interval = 1;
            this.tmLogoExpandir2.Tick += new System.EventHandler(this.tmLogoExpandir2_Tick);
            // 
            // tmLogoRetrair2
            // 
            this.tmLogoRetrair2.Interval = 1;
            this.tmLogoRetrair2.Tick += new System.EventHandler(this.tmLogoRetrair2_Tick);
            // 
            // tmESenha
            // 
            this.tmESenha.Interval = 29;
            this.tmESenha.Tick += new System.EventHandler(this.tmESenha_Tick);
            // 
            // tmNovaSE
            // 
            this.tmNovaSE.Interval = 1;
            this.tmNovaSE.Tick += new System.EventHandler(this.tmNovaSE_Tick);
            // 
            // tmNovaSD
            // 
            this.tmNovaSD.Interval = 1;
            this.tmNovaSD.Tick += new System.EventHandler(this.tmNovaSD_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).EndInit();
            this.panelTela.ResumeLayout(false);
            this.panelTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel lineCPF;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel lineSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lblSenha;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label lblAviso;
        private FontAwesome.Sharp.IconPictureBox iconAviso;
        private FontAwesome.Sharp.IconButton iconOlho;
        private System.Windows.Forms.Panel panelTela;
        private System.Windows.Forms.Timer tmLogoExpandir;
        private System.Windows.Forms.Timer tmLogoRetrair;
        private System.Windows.Forms.Timer tmTelaE;
        private System.Windows.Forms.Timer tmTelaD;
        private FontAwesome.Sharp.IconButton iconVoltar;
        private System.Windows.Forms.Timer tmLogoExpandir2;
        private System.Windows.Forms.Timer tmLogoRetrair2;
        private System.Windows.Forms.Timer tmESenha;
        private System.Windows.Forms.Timer tmNovaSE;
        private System.Windows.Forms.Timer tmNovaSD;
        private System.Windows.Forms.Label lblSenha1;
        private System.Windows.Forms.Label lblCPF;
    }
}

