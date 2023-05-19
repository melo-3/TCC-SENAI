namespace Almoxarifado_TCC.Popup
{
    partial class FormNovaSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconAviso = new FontAwesome.Sharp.IconPictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.txtRNVSenha = new System.Windows.Forms.TextBox();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.panelLine1 = new System.Windows.Forms.Panel();
            this.txtNVSenha = new System.Windows.Forms.TextBox();
            this.iconOlho = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.label1.Font = new System.Drawing.Font("Candara", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(144, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 29;
            this.label1.Text = "RECUPERAR SENHA";
            // 
            // iconAviso
            // 
            this.iconAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.iconAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAviso.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAviso.Location = new System.Drawing.Point(57, 187);
            this.iconAviso.Name = "iconAviso";
            this.iconAviso.Size = new System.Drawing.Size(32, 33);
            this.iconAviso.TabIndex = 31;
            this.iconAviso.TabStop = false;
            this.iconAviso.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.lblAviso.Font = new System.Drawing.Font("Candara", 8.25F);
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAviso.Location = new System.Drawing.Point(87, 196);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(31, 13);
            this.lblAviso.TabIndex = 30;
            this.lblAviso.Text = "Error";
            this.lblAviso.Visible = false;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnAvancar.FlatAppearance.BorderSize = 0;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Candara", 8.25F);
            this.btnAvancar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvancar.Location = new System.Drawing.Point(57, 234);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(408, 40);
            this.btnAvancar.TabIndex = 27;
            this.btnAvancar.Text = "AVANÇAR";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRNVSenha
            // 
            this.txtRNVSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtRNVSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRNVSenha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRNVSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRNVSenha.Location = new System.Drawing.Point(57, 148);
            this.txtRNVSenha.Name = "txtRNVSenha";
            this.txtRNVSenha.Size = new System.Drawing.Size(388, 20);
            this.txtRNVSenha.TabIndex = 26;
            this.txtRNVSenha.Text = "NOVA SENHA";
            this.txtRNVSenha.Enter += new System.EventHandler(this.txtRNVSenha_Enter);
            this.txtRNVSenha.Leave += new System.EventHandler(this.txtRNVSenha_Leave);
            // 
            // panelLine2
            // 
            this.panelLine2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLine2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLine2.Location = new System.Drawing.Point(57, 170);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(408, 2);
            this.panelLine2.TabIndex = 28;
            // 
            // panelLine1
            // 
            this.panelLine1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLine1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLine1.Location = new System.Drawing.Point(57, 111);
            this.panelLine1.Name = "panelLine1";
            this.panelLine1.Size = new System.Drawing.Size(408, 2);
            this.panelLine1.TabIndex = 32;
            // 
            // txtNVSenha
            // 
            this.txtNVSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.txtNVSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNVSenha.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVSenha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNVSenha.Location = new System.Drawing.Point(56, 89);
            this.txtNVSenha.Name = "txtNVSenha";
            this.txtNVSenha.Size = new System.Drawing.Size(388, 20);
            this.txtNVSenha.TabIndex = 33;
            this.txtNVSenha.Text = "INSIRA A NOVA SENHA";
            this.txtNVSenha.Enter += new System.EventHandler(this.txtNVSenha_Enter);
            this.txtNVSenha.Leave += new System.EventHandler(this.txtNVSenha_Leave);
            // 
            // iconOlho
            // 
            this.iconOlho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.iconOlho.FlatAppearance.BorderSize = 0;
            this.iconOlho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
            this.iconOlho.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconOlho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconOlho.IconSize = 30;
            this.iconOlho.Location = new System.Drawing.Point(443, 147);
            this.iconOlho.Name = "iconOlho";
            this.iconOlho.Size = new System.Drawing.Size(25, 23);
            this.iconOlho.TabIndex = 34;
            this.iconOlho.UseVisualStyleBackColor = false;
            this.iconOlho.Click += new System.EventHandler(this.iconOlho_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
            this.iconButton1.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(443, 86);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(25, 23);
            this.iconButton1.TabIndex = 35;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // FormNovaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(480, 330);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.iconOlho);
            this.Controls.Add(this.panelLine1);
            this.Controls.Add(this.txtNVSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconAviso);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.txtRNVSenha);
            this.Controls.Add(this.panelLine2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovaSenha";
            this.Text = "FormNovaSenha";
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.TextBox txtRNVSenha;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Panel panelLine1;
        private System.Windows.Forms.TextBox txtNVSenha;
        private FontAwesome.Sharp.IconButton iconOlho;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}