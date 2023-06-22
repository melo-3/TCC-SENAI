namespace Almoxarifado_TCC.Popup
{
    partial class RedefinirSenha
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.iconAviso = new FontAwesome.Sharp.IconPictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRSenha = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCriarUsu = new System.Windows.Forms.RichTextBox();
            this.iconChave = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.iconAviso);
            this.panel1.Controls.Add(this.lblAviso);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtSenhaAtual);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtRSenha);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Location = new System.Drawing.Point(12, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 320);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Light", 7.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(59, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 40);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // iconAviso
            // 
            this.iconAviso.BackColor = System.Drawing.Color.Transparent;
            this.iconAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAviso.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAviso.Location = new System.Drawing.Point(59, 210);
            this.iconAviso.Name = "iconAviso";
            this.iconAviso.Size = new System.Drawing.Size(32, 33);
            this.iconAviso.TabIndex = 50;
            this.iconAviso.TabStop = false;
            this.iconAviso.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Bahnschrift Light", 7.25F);
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAviso.Location = new System.Drawing.Point(89, 219);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(28, 12);
            this.lblAviso.TabIndex = 49;
            this.lblAviso.Text = "Error";
            this.lblAviso.Visible = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Bahnschrift Light", 7.25F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlterar.Location = new System.Drawing.Point(222, 257);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(134, 40);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "SENHA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(108, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 2);
            this.panel2.TabIndex = 26;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSenhaAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtSenhaAtual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSenhaAtual.Location = new System.Drawing.Point(107, 49);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(269, 17);
            this.txtSenhaAtual.TabIndex = 2;
            this.txtSenhaAtual.Text = "SENHA ATUAL";
            this.txtSenhaAtual.Enter += new System.EventHandler(this.txtSenhaAtual_Enter);
            this.txtSenhaAtual.Leave += new System.EventHandler(this.txtSenhaAtual_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(51, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "SENHA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(50, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 24;
            this.label4.Text = "SENHA";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(108, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(269, 2);
            this.panel5.TabIndex = 22;
            // 
            // txtRSenha
            // 
            this.txtRSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtRSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRSenha.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtRSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRSenha.Location = new System.Drawing.Point(107, 173);
            this.txtRSenha.Name = "txtRSenha";
            this.txtRSenha.Size = new System.Drawing.Size(269, 17);
            this.txtRSenha.TabIndex = 4;
            this.txtRSenha.Text = "REPETIR SENHA";
            this.txtRSenha.Enter += new System.EventHandler(this.txtRSenha_Enter);
            this.txtRSenha.Leave += new System.EventHandler(this.txtRSenha_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(107, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 2);
            this.panel4.TabIndex = 20;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSenha.Location = new System.Drawing.Point(106, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(269, 17);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "NOVA SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtCriarUsu
            // 
            this.txtCriarUsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.txtCriarUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCriarUsu.Font = new System.Drawing.Font("Bahnschrift Light", 8.75F, System.Drawing.FontStyle.Bold);
            this.txtCriarUsu.ForeColor = System.Drawing.Color.Silver;
            this.txtCriarUsu.Location = new System.Drawing.Point(35, 111);
            this.txtCriarUsu.Name = "txtCriarUsu";
            this.txtCriarUsu.ReadOnly = true;
            this.txtCriarUsu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCriarUsu.Size = new System.Drawing.Size(379, 48);
            this.txtCriarUsu.TabIndex = 21;
            this.txtCriarUsu.Text = "         Ao mudar a senha, sua conta será desconectada.\n       Use pelo menos 8 c" +
    "aracteres ao redefinir sua senha.";
            this.txtCriarUsu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCriarUsu_MouseDown);
            // 
            // iconChave
            // 
            this.iconChave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconChave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconChave.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChave.IconSize = 80;
            this.iconChave.Location = new System.Drawing.Point(179, 25);
            this.iconChave.Name = "iconChave";
            this.iconChave.Size = new System.Drawing.Size(80, 80);
            this.iconChave.TabIndex = 6;
            this.iconChave.TabStop = false;
            this.iconChave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtCriarUsu_MouseDown);
            // 
            // RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(444, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconChave);
            this.Controls.Add(this.txtCriarUsu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedefinirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedefinirSenha";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RedefinirSenha_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRSenha;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSenha;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconPictureBox iconAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.RichTextBox txtCriarUsu;
        private FontAwesome.Sharp.IconPictureBox iconChave;
    }
}