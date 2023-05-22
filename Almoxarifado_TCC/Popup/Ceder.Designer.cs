namespace Almoxarifado_TCC.Popup
{
    partial class Ceder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconCeder = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblQuantTotal = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnMinus = new FontAwesome.Sharp.IconButton();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblQuant = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCeder = new System.Windows.Forms.Button();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBox = new FontAwesome.Sharp.IconPictureBox();
            this.Hora_Ceder = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // iconCeder
            // 
            this.iconCeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconCeder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCeder.IconChar = FontAwesome.Sharp.IconChar.HandHolding;
            this.iconCeder.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCeder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCeder.IconSize = 80;
            this.iconCeder.Location = new System.Drawing.Point(54, 37);
            this.iconCeder.Name = "iconCeder";
            this.iconCeder.Size = new System.Drawing.Size(80, 80);
            this.iconCeder.TabIndex = 10;
            this.iconCeder.TabStop = false;
            this.iconCeder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconChave_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.lblQuantTotal);
            this.panel4.Controls.Add(this.dgvUsuario);
            this.panel4.Controls.Add(this.btnMax);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Controls.Add(this.btnMinus);
            this.panel4.Controls.Add(this.txtCpf);
            this.panel4.Controls.Add(this.lblQuant);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.btnCeder);
            this.panel4.Controls.Add(this.txtQuant);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(2, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 334);
            this.panel4.TabIndex = 11;
            // 
            // lblQuantTotal
            // 
            this.lblQuantTotal.AutoSize = true;
            this.lblQuantTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblQuantTotal.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblQuantTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuantTotal.Location = new System.Drawing.Point(122, 174);
            this.lblQuantTotal.Name = "lblQuantTotal";
            this.lblQuantTotal.Size = new System.Drawing.Size(32, 17);
            this.lblQuantTotal.TabIndex = 26;
            this.lblQuantTotal.Text = "****";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(63)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.dgvUsuario.Location = new System.Drawing.Point(12, 64);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.Size = new System.Drawing.Size(164, 91);
            this.dgvUsuario.TabIndex = 10;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
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
            this.btnMax.Location = new System.Drawing.Point(130, 204);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(23, 23);
            this.btnMax.TabIndex = 25;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
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
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Maroon;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinus.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinus.IconSize = 20;
            this.btnMinus.Location = new System.Drawing.Point(35, 204);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(23, 23);
            this.btnMinus.TabIndex = 24;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtCpf.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCpf.Location = new System.Drawing.Point(27, 37);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(133, 17);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.Text = "CPF";
            this.txtCpf.Enter += new System.EventHandler(this.txtCpf_Enter);
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCpf_KeyDown);
            this.txtCpf.Leave += new System.EventHandler(this.txtCpf_Leave);
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.lblQuant.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.lblQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblQuant.Location = new System.Drawing.Point(34, 174);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(83, 17);
            this.lblQuant.TabIndex = 23;
            this.lblQuant.Text = "Quantidade:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(64, 226);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 2);
            this.panel5.TabIndex = 21;
            // 
            // btnCeder
            // 
            this.btnCeder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.btnCeder.FlatAppearance.BorderSize = 0;
            this.btnCeder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCeder.ForeColor = System.Drawing.Color.White;
            this.btnCeder.Location = new System.Drawing.Point(56, 272);
            this.btnCeder.Name = "btnCeder";
            this.btnCeder.Size = new System.Drawing.Size(75, 23);
            this.btnCeder.TabIndex = 0;
            this.btnCeder.Text = "Ceder";
            this.btnCeder.UseVisualStyleBackColor = false;
            this.btnCeder.Click += new System.EventHandler(this.btnCeder_Click);
            // 
            // txtQuant
            // 
            this.txtQuant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuant.Font = new System.Drawing.Font("Bahnschrift Light", 10F);
            this.txtQuant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtQuant.Location = new System.Drawing.Point(63, 208);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(60, 17);
            this.txtQuant.TabIndex = 22;
            this.txtQuant.Text = "0";
            this.txtQuant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(27, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 2);
            this.panel1.TabIndex = 7;
            // 
            // iconBox
            // 
            this.iconBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.iconBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconBox.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconBox.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBox.IconSize = 40;
            this.iconBox.Location = new System.Drawing.Point(73, 37);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(41, 40);
            this.iconBox.TabIndex = 12;
            this.iconBox.TabStop = false;
            this.iconBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.iconBox_MouseDown);
            // 
            // Hora_Ceder
            // 
            this.Hora_Ceder.Tick += new System.EventHandler(this.Hora_Ceder_Tick);
            // 
            // Ceder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(193, 485);
            this.Controls.Add(this.iconBox);
            this.Controls.Add(this.iconCeder);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ceder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ceder";
            this.Load += new System.EventHandler(this.Ceder_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ceder_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconCeder)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconCeder;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Button btnCeder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label lblQuantTotal;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnMinus;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtQuant;
        private FontAwesome.Sharp.IconPictureBox iconBox;
        private System.Windows.Forms.Timer Hora_Ceder;
    }
}