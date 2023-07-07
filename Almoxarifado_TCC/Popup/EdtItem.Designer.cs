namespace Almoxarifado_TCC.Popup
{
    partial class EdtItem
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
            this.iconEditar = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblquant = new System.Windows.Forms.Label();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lklCancelar = new System.Windows.Forms.LinkLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconEditar)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconEditar
            // 
            this.iconEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconEditar.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconEditar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconEditar.IconSize = 80;
            this.iconEditar.Location = new System.Drawing.Point(56, 37);
            this.iconEditar.Name = "iconEditar";
            this.iconEditar.Size = new System.Drawing.Size(80, 80);
            this.iconEditar.TabIndex = 12;
            this.iconEditar.TabStop = false;
            this.iconEditar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconEditar_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.lblDescricao);
            this.panel4.Controls.Add(this.lblNome);
            this.panel4.Controls.Add(this.txtDescricao);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lblquant);
            this.panel4.Controls.Add(this.btnMax);
            this.panel4.Controls.Add(this.btnMinus);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtQuant);
            this.panel4.Controls.Add(this.lklCancelar);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(2, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 334);
            this.panel4.TabIndex = 13;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescricao.Location = new System.Drawing.Point(25, 84);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(56, 13);
            this.lblDescricao.TabIndex = 25;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(25, 21);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(36, 13);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDescricao.Location = new System.Drawing.Point(28, 100);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(133, 17);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.Text = "Descrição";
            this.txtDescricao.Enter += new System.EventHandler(this.txtDescricao_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtDescricao_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(28, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 22;
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblquant.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblquant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblquant.Location = new System.Drawing.Point(117, 159);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(32, 17);
            this.lblquant.TabIndex = 20;
            this.lblquant.Text = "****";
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnMax.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 20;
            this.btnMax.Location = new System.Drawing.Point(129, 189);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 23);
            this.btnMax.TabIndex = 19;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Maroon;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 20;
            this.btnMinus.Location = new System.Drawing.Point(34, 189);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 18;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(29, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantidade:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(63, 211);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 2);
            this.panel5.TabIndex = 9;
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuant.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQuant.Location = new System.Drawing.Point(63, 192);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.ReadOnly = true;
            this.txtQuant.Size = new System.Drawing.Size(60, 17);
            this.txtQuant.TabIndex = 9;
            this.txtQuant.Text = "0";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lklCancelar
            // 
            this.lklCancelar.AutoSize = true;
            this.lklCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lklCancelar.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.lklCancelar.Location = new System.Drawing.Point(70, 307);
            this.lklCancelar.Name = "lklCancelar";
            this.lklCancelar.Size = new System.Drawing.Size(42, 12);
            this.lklCancelar.TabIndex = 6;
            this.lklCancelar.TabStop = true;
            this.lklCancelar.Text = "Cancelar";
            this.lklCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCancelar_LinkClicked);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNome.Location = new System.Drawing.Point(28, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 17);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(56, 272);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(28, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 2);
            this.panel1.TabIndex = 7;
            // 
            // EdtItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconEditar);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdtItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdtItem";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EdtItem_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconEditar)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconEditar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel lklCancelar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnMinus;
        private FontAwesome.Sharp.IconButton btnMax;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNome;
    }
}