using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;// Usado para o DllImport

namespace Almoxarifado_TCC.Popup
{
    public partial class Ceder : Form
    {
        public Ceder()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ceder_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";
                txtCpf.ForeColor = Color.Black;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF";
                txtCpf.ForeColor = Color.Black;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void Ceder_Load(object sender, EventArgs e)
        {

            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuario.BackgroundColor = Color.FromArgb(56, 60, 71);

            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dgvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void iconCeder_Click(object sender, EventArgs e)
        {

        }

        private void iconBox_Click(object sender, EventArgs e)
        {

        }

    }
}
