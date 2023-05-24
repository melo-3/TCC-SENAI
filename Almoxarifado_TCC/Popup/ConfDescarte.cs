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
    public partial class ConfDescarte : Form
    {

        public int cod_desc;

        public ConfDescarte(int cod)
        {
            InitializeComponent();
            cod_desc = cod;
        }

        private void ConfDescarte_Load(object sender, EventArgs e)
        {

        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
