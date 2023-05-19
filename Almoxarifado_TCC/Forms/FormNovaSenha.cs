using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almoxarifado_TCC.Popup
{
    public partial class FormNovaSenha : Form
    {
        public FormNovaSenha()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login.CurrentInstance.TimerLogo();
        }

        private void txtNVSenha_Enter(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "INSIRA A NOVA SENHA")
            {
                txtNVSenha.Text = "";
                txtNVSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNVSenha_Leave(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "")
            {
                txtNVSenha.Text = "INSIRA A NOVA SENHA";
                txtNVSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtRNVSenha_Enter(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "NOVA SENHA")
            {
                txtRNVSenha.Text = "";
                txtNVSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtRNVSenha_Leave(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "")
            {
                txtRNVSenha.Text = "NOVA SENHA";
                txtRNVSenha.UseSystemPasswordChar = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "INSIRA A NOVA SENHA")
            {

            }
            else
            {
                if (txtNVSenha.UseSystemPasswordChar)
                {
                    iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    txtNVSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
                    txtNVSenha.UseSystemPasswordChar = true;
                }
            }
        }

        private void iconOlho_Click(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "NOVA SENHA")
            {

            }
            else
            {
                if (txtRNVSenha.UseSystemPasswordChar)
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    txtRNVSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
                    txtRNVSenha.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
