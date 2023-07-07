using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Forms;

namespace Almoxarifado_TCC.Popup
{
    public partial class DeletarUsu : Form
    {
        public DeletarUsu(int cod)
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento.CurrentInstance.Fechar();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            /// Código para deletar conta
            

            /// -------------------------
            
            Gerenciamento.CurrentInstance.Fechar();
            this.Close();
        }

        #region Interações visuais

        private void txtUsuário_Enter(object sender, EventArgs e)
        {
            if (txtUsuário.Text == "CPF DO USUÁRIO")
            {
                txtUsuário.Text = "";
                lblCPF.Visible = true;
            }
        }

        private void txtUsuário_Leave(object sender, EventArgs e)
        {
            if (txtUsuário.Text == "")
            {
                txtUsuário.Text = "CPF DO USUÁRIO";
                lblCPF.Visible = false;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA DO ADMINISTRADOR")  
            {
                txtSenha.Text = "";
                lblSenha.Visible = true;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA DO ADMINISTRADOR";
                lblSenha.Visible = false;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuário_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion


    }
}
