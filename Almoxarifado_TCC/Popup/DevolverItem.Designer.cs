namespace Almoxarifado_TCC.Popup
{
    partial class DevolverItem
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
            this.txtObs = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDevolucao = new System.Windows.Forms.Label();
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
            this.iconBox = new FontAwesome.Sharp.IconPictureBox();
            this.iconCeder = new FontAwesome.Sharp.IconPictureBox();
            this.Hora_Devolver = new System.Windows.Forms.Timer(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.txtObs);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.txtNome);
            this.panel4.Controls.Add(this.lblDevolucao);
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
            this.panel4.TabIndex = 13;
            // 
            // txtObs
            // 
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObs.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtObs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtObs.Location = new System.Drawing.Point(27, 216);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(133, 17);
            this.txtObs.TabIndex = 21;
            this.txtObs.Text = "Obs";
            this.txtObs.Enter += new System.EventHandler(this.txtObs_Enter);
            this.txtObs.Leave += new System.EventHandler(this.txtObs_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(27, 235);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 2);
            this.panel5.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNome.Location = new System.Drawing.Point(27, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(133, 19);
            this.txtNome.TabIndex = 20;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDevolucao
            // 
            this.lblDevolucao.AutoSize = true;
            this.lblDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblDevolucao.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.lblDevolucao.Location = new System.Drawing.Point(56, 31);
            this.lblDevolucao.Name = "lblDevolucao";
            this.lblDevolucao.Size = new System.Drawing.Size(75, 18);
            this.lblDevolucao.TabIndex = 19;
            this.lblDevolucao.Text = "Devolução";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(106, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 2);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(71, 2);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(104, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Devolução";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Emprestimo";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblHorario.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.lblHorario.Location = new System.Drawing.Point(60, 103);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(63, 18);
            this.lblHorario.TabIndex = 16;
            this.lblHorario.Text = "Horários";
            // 
            // txtDevolucao
            // 
            this.txtDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtDevolucao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDevolucao.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDevolucao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.txtDevolucao.Location = new System.Drawing.Point(105, 155);
            this.txtDevolucao.Name = "txtDevolucao";
            this.txtDevolucao.Size = new System.Drawing.Size(72, 19);
            this.txtDevolucao.TabIndex = 15;
            this.txtDevolucao.Text = "hh:mm";
            this.txtDevolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmprestimo
            // 
            this.txtEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmprestimo.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(131)))), ((int)(((byte)(143)))));
            this.txtEmprestimo.Location = new System.Drawing.Point(13, 155);
            this.txtEmprestimo.Name = "txtEmprestimo";
            this.txtEmprestimo.Size = new System.Drawing.Size(71, 19);
            this.txtEmprestimo.TabIndex = 14;
            this.txtEmprestimo.Text = "--:--";
            this.txtEmprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(27, 52);
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
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconBox.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconBox.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBox.IconSize = 40;
            this.iconBox.Location = new System.Drawing.Point(73, 75);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(41, 40);
            this.iconBox.TabIndex = 15;
            this.iconBox.TabStop = false;
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
            this.iconCeder.TabIndex = 16;
            this.iconCeder.TabStop = false;
            // 
            // Hora_Devolver
            // 
            this.Hora_Devolver.Tick += new System.EventHandler(this.Hora_Devolver_Tick);
            // 
            // DevolverItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.iconCeder);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DevolverItem";
            this.Text = "DevolverItem";
            this.Load += new System.EventHandler(this.DevolverItem_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDevolucao;
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
        private FontAwesome.Sharp.IconPictureBox iconBox;
        private FontAwesome.Sharp.IconPictureBox iconCeder;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Timer Hora_Devolver;
    }
}