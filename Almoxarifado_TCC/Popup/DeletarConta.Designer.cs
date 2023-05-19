namespace Almoxarifado_TCC.Popup
{
    partial class DeletarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarConta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconOlho = new FontAwesome.Sharp.IconButton();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.iconAviso = new FontAwesome.Sharp.IconPictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lineCPF = new System.Windows.Forms.Panel();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lineSenha = new System.Windows.Forms.Panel();
            this.iconExc = new FontAwesome.Sharp.IconPictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.iconOlho);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.iconAviso);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.lineCPF);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.lblAviso);
            this.panel1.Controls.Add(this.lineSenha);
            this.panel1.Location = new System.Drawing.Point(2, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 254);
            this.panel1.TabIndex = 0;
            // 
            // iconOlho
            // 
            this.iconOlho.FlatAppearance.BorderSize = 0;
            this.iconOlho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
            this.iconOlho.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconOlho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOlho.IconSize = 30;
            this.iconOlho.Location = new System.Drawing.Point(449, 97);
            this.iconOlho.Name = "iconOlho";
            this.iconOlho.Size = new System.Drawing.Size(25, 23);
            this.iconOlho.TabIndex = 22;
            this.iconOlho.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(112)))));
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(151)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Candara", 8.25F);
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletar.Location = new System.Drawing.Point(116, 191);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(299, 40);
            this.btnDeletar.TabIndex = 18;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // iconAviso
            // 
            this.iconAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.iconAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAviso.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAviso.Location = new System.Drawing.Point(60, 139);
            this.iconAviso.Name = "iconAviso";
            this.iconAviso.Size = new System.Drawing.Size(32, 33);
            this.iconAviso.TabIndex = 21;
            this.iconAviso.TabStop = false;
            this.iconAviso.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSenha.Location = new System.Drawing.Point(60, 101);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(388, 17);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // lineCPF
            // 
            this.lineCPF.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineCPF.Location = new System.Drawing.Point(60, 61);
            this.lineCPF.Name = "lineCPF";
            this.lineCPF.Size = new System.Drawing.Size(408, 2);
            this.lineCPF.TabIndex = 15;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtCPF.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCPF.Location = new System.Drawing.Point(59, 42);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(408, 17);
            this.txtCPF.TabIndex = 16;
            this.txtCPF.Text = "CPF";
            this.txtCPF.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtCPF.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblAviso.Font = new System.Drawing.Font("Bahnschrift Light", 7F);
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAviso.Location = new System.Drawing.Point(90, 149);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(28, 12);
            this.lblAviso.TabIndex = 20;
            this.lblAviso.Text = "Error";
            this.lblAviso.Visible = false;
            // 
            // lineSenha
            // 
            this.lineSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lineSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineSenha.Location = new System.Drawing.Point(60, 120);
            this.lineSenha.Name = "lineSenha";
            this.lineSenha.Size = new System.Drawing.Size(408, 2);
            this.lineSenha.TabIndex = 19;
            // 
            // iconExc
            // 
            this.iconExc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconExc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.iconExc.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExc.IconSize = 107;
            this.iconExc.Location = new System.Drawing.Point(213, 21);
            this.iconExc.Name = "iconExc";
            this.iconExc.Size = new System.Drawing.Size(107, 114);
            this.iconExc.TabIndex = 7;
            this.iconExc.TabStop = false;
            this.iconExc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconExc_MouseDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(70, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(408, 48);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(513, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DeletarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(536, 452);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.iconExc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletarConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletarConta";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DeletarConta_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconExc;
        private FontAwesome.Sharp.IconButton iconOlho;
        private System.Windows.Forms.Button btnDeletar;
        private FontAwesome.Sharp.IconPictureBox iconAviso;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel lineCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Panel lineSenha;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}