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
            if (txtUsuário.Text == "USUÁRIO")
                txtUsuário.Text = "";
        }

        private void txtUsuário_Leave(object sender, EventArgs e)
        {
            if (txtUsuário.Text == "")
                txtUsuário.Text = "USUÁRIO";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
                txtSenha.Text = "";
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
                txtSenha.Text = "SENHA";
        }

        #endregion
        
    }
}
