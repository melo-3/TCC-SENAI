namespace Almoxarifado_TCC.Popup
{
    partial class ExcChave
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
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iconExc = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSala = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.iconAviso = new FontAwesome.Sharp.IconPictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.btnSim.FlatAppearance.BorderSize = 0;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSim.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSim.Location = new System.Drawing.Point(152, 160);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnNao.FlatAppearance.BorderSize = 0;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Bahnschrift Light", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNao.Location = new System.Drawing.Point(40, 160);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 1;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 9.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Você tem certeza que deseja";
            // 
            // iconExc
            // 
            this.iconExc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconExc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconChar = FontAwesome.Sharp.IconChar.Skull;
            this.iconExc.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconExc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExc.IconSize = 107;
            this.iconExc.Location = new System.Drawing.Point(85, 23);
            this.iconExc.Name = "iconExc";
            this.iconExc.Size = new System.Drawing.Size(107, 114);
            this.iconExc.TabIndex = 3;
            this.iconExc.TabStop = false;
            this.iconExc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconExc_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift Light", 9.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "deletar está chave?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.txtConfirm);
            this.panel1.Controls.Add(this.lblSala);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(3, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 203);
            this.panel1.TabIndex = 5;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Bahnschrift SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.DimGray;
            this.lblSala.Location = new System.Drawing.Point(93, 91);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(75, 13);
            this.lblSala.TabIndex = 20;
            this.lblSala.Text = "Nome da sala";
            this.lblSala.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(66, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(133, 2);
            this.panel2.TabIndex = 8;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Bahnschrift Light", 8.75F, System.Drawing.FontStyle.Bold);
            this.txtConfirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtConfirm.Location = new System.Drawing.Point(66, 106);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(133, 15);
            this.txtConfirm.TabIndex = 10;
            this.txtConfirm.Text = "Insira o nome da sala";
            this.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirm.Enter += new System.EventHandler(this.txtConfirm_Enter);
            this.txtConfirm.Leave += new System.EventHandler(this.txtConfirm_Leave);
            // 
            // iconAviso
            // 
            this.iconAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.iconAviso.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAviso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAviso.IconSize = 22;
            this.iconAviso.Location = new System.Drawing.Point(111, 125);
            this.iconAviso.Name = "iconAviso";
            this.iconAviso.Size = new System.Drawing.Size(22, 25);
            this.iconAviso.TabIndex = 21;
            this.iconAviso.TabStop = false;
            this.iconAviso.Visible = false;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.lblAviso.Font = new System.Drawing.Font("Candara", 8.25F);
            this.lblAviso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAviso.Location = new System.Drawing.Point(136, 129);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(31, 13);
            this.lblAviso.TabIndex = 20;
            this.lblAviso.Text = "Error";
            this.lblAviso.Visible = false;
            // 
            // ExcChave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(282, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconAviso);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.iconExc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcChave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcChave";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExcChave_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconExc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAviso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconExc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblSala;
        private FontAwesome.Sharp.IconPictureBox iconAviso;
        private System.Windows.Forms.Label lblAviso;
    }
}