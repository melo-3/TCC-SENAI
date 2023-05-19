using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almoxarifado_TCC.Popup
{
    public partial class DevolverChave : Form
    {
        public string nome;
        public DevolverChave()
        {
            InitializeComponent();
            Horario_devolucao.Start();
        }

        #region Interações visuais

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DevolverChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region Botões

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {

        }

        #endregion



        private void Horario_devolucao_Tick(object sender, EventArgs e)
        {
            txtDevolucao.Text = DateTime.Now.ToString("HH:mm");
        }

        private void DevolverChave_Load(object sender, EventArgs e)
        {
            textBox1.Text=nome;
        }
    }
}
