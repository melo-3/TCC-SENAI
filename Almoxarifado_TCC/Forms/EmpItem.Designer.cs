namespace Almoxarifado_TCC.Forms
{
    partial class EmpItem
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
            this.dtvEmpItem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvEmpItem
            // 
            this.dtvEmpItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvEmpItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvEmpItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvEmpItem.Location = new System.Drawing.Point(36, 106);
            this.dtvEmpItem.Name = "dtvEmpItem";
            this.dtvEmpItem.Size = new System.Drawing.Size(581, 370);
            this.dtvEmpItem.TabIndex = 0;
            // 
            // EmpItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(788, 529);
            this.Controls.Add(this.dtvEmpItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpItem";
            this.Text = "EmpItem";
            this.Load += new System.EventHandler(this.EmpItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvEmpItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvEmpItem;
    }
}