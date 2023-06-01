namespace Almoxarifado_TCC.Popup
{
    partial class DeletarUsu
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
            this.lineCPF = new System.Windows.Forms.Panel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsuário = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.iconExc = new FontAwesome.Sharp.IconPictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).BeginInit();
            this.SuspendLayout();
            // 
            // lineCPF
            // 
            this.lineCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lineCPF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineCPF.Location = new System.Drawing.Point(13, 253);
            this.lineCPF.Name = "lineCPF";
            this.lineCPF.Size = new System.Drawing.Size(189, 1);
            this.lineCPF.TabIndex = 21;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSenha.Location = new System.Drawing.Point(12, 237);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(189, 13);
            this.txtSenha.TabIndex = 22;
            this.txtSenha.Text = "SENHA";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(13, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 1);
            this.panel1.TabIndex = 23;
            // 
            // txtUsuário
            // 
            this.txtUsuário.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtUsuário.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuário.Font = new System.Drawing.Font("Bahnschrift Light", 8F);
            this.txtUsuário.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtUsuário.Location = new System.Drawing.Point(12, 196);
            this.txtUsuário.Name = "txtUsuário";
            this.txtUsuário.Size = new System.Drawing.Size(189, 13);
            this.txtUsuário.TabIndex = 24;
            this.txtUsuário.Text = "USUÁRIO";
            this.txtUsuário.Enter += new System.EventHandler(this.txtUsuário_Enter);
            this.txtUsuário.Leave += new System.EventHandler(this.txtUsuário_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.iconExc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 136);
            this.panel2.TabIndex = 25;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Location = new System.Drawing.Point(21, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(169, 33);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "Deletar um usuário do sistema \n       é uma ação irreversível\n\n\n\n";
            // 
            // iconExc
            // 
            this.iconExc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.iconExc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.iconExc.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExc.IconSize = 70;
            this.iconExc.Location = new System.Drawing.Point(69, 23);
            this.iconExc.Name = "iconExc";
            this.iconExc.Size = new System.Drawing.Size(75, 70);
            this.iconExc.TabIndex = 8;
            this.iconExc.TabStop = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Bahnschrift Light", 9F);
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox2.Location = new System.Drawing.Point(32, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(169, 33);
            this.richTextBox2.TabIndex = 27;
            this.richTextBox2.Text = "Preencha as informações \nabaixo se deseja continuar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.Location = new System.Drawing.Point(13, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 29);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletar.Location = new System.Drawing.Point(111, 288);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(83, 29);
            this.btnDeletar.TabIndex = 50;
            this.btnDeletar.Text = "DELETAR";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // DeletarUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(213, 340);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsuário);
            this.Controls.Add(this.lineCPF);
            this.Controls.Add(this.txtSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletarUsu";
            this.Text = "DeletarUsu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lineCPF;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuário;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconExc;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
    }
}