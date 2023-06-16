namespace Almoxarifado_TCC.Popup
{
    partial class DevolverChave
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
            this.components = new System.ComponentModel.Container();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtDevolucao = new System.Windows.Forms.TextBox();
            this.txtEmprestimo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.iconChave = new FontAwesome.Sharp.IconPictureBox();
            this.iconCeder = new FontAwesome.Sharp.IconPictureBox();
            this.Temp_devolucao = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.lblHorario);
            this.panel4.Controls.Add(this.txtDevolucao);
            this.panel4.Controls.Add(this.txtEmprestimo);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.btnDevolver);
            this.panel4.Location = new System.Drawing.Point(2, 149);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 334);
            this.panel4.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNome.Location = new System.Drawing.Point(28, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(133, 17);
            this.txtNome.TabIndex = 20;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(60, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Devolução";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(103, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(9, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 2);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(105, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Devolução";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Emprestimo";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblHorario.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.25F, System.Drawing.FontStyle.Bold);
            this.lblHorario.ForeColor = System.Drawing.Color.DimGray;
            this.lblHorario.Location = new System.Drawing.Point(63, 140);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(59, 16);
            this.lblHorario.TabIndex = 16;
            this.lblHorario.Text = "Horários";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevolucao.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtDevolucao.ForeColor = System.Drawing.Color.DimGray;
            this.txtDevolucao.Location = new System.Drawing.Point(102, 191);
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(72, 17);
            this.txtDevolucao.TabIndex = 15;
            this.txtDevolucao.Text = "hh:mm";
            this.txtDevolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmprestimo.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtEmprestimo.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmprestimo.Location = new System.Drawing.Point(10, 191);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(71, 17);
            this.txtEmprestimo.TabIndex = 14;
            this.txtEmprestimo.Text = "--:--";
            this.txtEmprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(27, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 2);
            this.panel2.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.Location = new System.Drawing.Point(70, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 12);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cancelar";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnDevolver.FlatAppearance.BorderSize = 0;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.Location = new System.Drawing.Point(56, 272);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(75, 23);
            this.btnDevolver.TabIndex = 0;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // iconChave
            // 
            this.iconChave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconChave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconChave.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconChave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconChave.IconSize = 40;
            this.iconChave.Location = new System.Drawing.Point(73, 75);
            this.iconChave.Name = "iconChave";
            this.iconChave.Size = new System.Drawing.Size(41, 40);
            this.iconChave.TabIndex = 13;
            this.iconChave.TabStop = false;
            this.iconChave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DevolverChave_MouseDown);
            // 
            // iconCeder
            // 
            this.iconCeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconCeder.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            this.iconCeder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCeder.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            this.iconCeder.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCeder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCeder.IconSize = 80;
            this.iconCeder.Location = new System.Drawing.Point(54, 37);
            this.iconCeder.Name = "iconCeder";
            this.iconCeder.Size = new System.Drawing.Size(80, 80);
            this.iconCeder.TabIndex = 14;
            this.iconCeder.TabStop = false;
            this.iconCeder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DevolverChave_MouseDown);
            // 
            // Temp_devolucao
            // 
            this.Temp_devolucao.Tick += new System.EventHandler(this.Temp_devolucao_Tick);
            // 
            // DevolverChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconChave);
            this.Controls.Add(this.iconCeder);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolverChave";
            this.Text = "DevolverChave";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DevolverChave_MouseDown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtDevolucao;
        private System.Windows.Forms.TextBox txtEmprestimo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnDevolver;
        private FontAwesome.Sharp.IconPictureBox iconChave;
        private FontAwesome.Sharp.IconPictureBox iconCeder;
        private System.Windows.Forms.Timer Temp_devolucao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
    }
}