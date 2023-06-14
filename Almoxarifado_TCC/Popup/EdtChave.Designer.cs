namespace Almoxarifado_TCC.Popup
{
    partial class EdtChave
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
            this.iconChave = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lklCancelar = new System.Windows.Forms.LinkLabel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconChave
            // 
            this.iconChave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconChave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconChave.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChave.IconSize = 80;
            this.iconChave.Location = new System.Drawing.Point(54, 37);
            this.iconChave.Name = "iconChave";
            this.iconChave.Size = new System.Drawing.Size(80, 80);
            this.iconChave.TabIndex = 10;
            this.iconChave.TabStop = false;
            this.iconChave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconChave_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.lblObs);
            this.panel4.Controls.Add(this.lblSala);
            this.panel4.Controls.Add(this.lblNumero);
            this.panel4.Controls.Add(this.txtObs);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.lklCancelar);
            this.panel4.Controls.Add(this.txtNumero);
            this.panel4.Controls.Add(this.btnEditar);
            this.panel4.Controls.Add(this.txtSala);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(2, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 334);
            this.panel4.TabIndex = 11;
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObs.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtObs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtObs.Location = new System.Drawing.Point(27, 170);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(133, 17);
            this.txtObs.TabIndex = 4;
            this.txtObs.Text = "Obs";
            this.txtObs.Enter += new System.EventHandler(this.txtObs_Enter);
            this.txtObs.Leave += new System.EventHandler(this.txtObs_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(27, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 8;
            // 
            // lklCancelar
            // 
            this.lklCancelar.AutoSize = true;
            this.lklCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklCancelar.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.lklCancelar.Location = new System.Drawing.Point(70, 307);
            this.lklCancelar.Name = "lklCancelar";
            this.lklCancelar.Size = new System.Drawing.Size(42, 12);
            this.lklCancelar.TabIndex = 6;
            this.lklCancelar.TabStop = true;
            this.lklCancelar.Text = "Cancelar";
            this.lklCancelar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCancelar_LinkClicked);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtNumero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNumero.Location = new System.Drawing.Point(27, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(133, 17);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.Text = "Número";
            this.txtNumero.Enter += new System.EventHandler(this.txtNumero_Enter);
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(56, 272);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSala
            // 
            this.txtSala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtSala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSala.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtSala.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSala.Location = new System.Drawing.Point(27, 115);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(133, 17);
            this.txtSala.TabIndex = 3;
            this.txtSala.Text = "Sala / Lab";
            this.txtSala.Enter += new System.EventHandler(this.txtSala_Enter);
            this.txtSala.Leave += new System.EventHandler(this.txtSala_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(27, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(27, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 2);
            this.panel1.TabIndex = 7;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumero.Location = new System.Drawing.Point(24, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 9;
            this.lblNumero.Text = "Número";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.DimGray;
            this.lblSala.Location = new System.Drawing.Point(24, 99);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(57, 13);
            this.lblSala.TabIndex = 10;
            this.lblSala.Text = "Sala / Lab";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.ForeColor = System.Drawing.Color.DimGray;
            this.lblObs.Location = new System.Drawing.Point(24, 154);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(66, 13);
            this.lblObs.TabIndex = 11;
            this.lblObs.Text = "Observação";
            // 
            // EdtChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconChave);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EdtChave";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EdtChave";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EdtChave_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconChave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel lklCancelar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblObs;
        private System.Windows.Forms.Label lblSala;
    }
}