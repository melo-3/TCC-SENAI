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
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
            this.TopMost = true;
            txtQuant.Text = "0";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AddItem_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconCaixa_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
                lblNome.Visible = true;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                lblNome.Visible = false;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Descrição")
            {
                txtDescricao.Text = "";
                lblDescricao.Visible = true;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descrição";
                lblDescricao.Visible = true;
            }
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text, descricao = txtDescricao.Text, quantidade = txtQuant.Text;

            if (nome == "" || nome == "Nome")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo Nome está vazio";
                iconAviso.Location = new Point(25, 126);
                lblAviso.Location = new Point(50, 130);
            }
            else if (descricao == "" || descricao == "Descrição")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo Descrição está vazio";
                iconAviso.Location = new Point(16, 126);
                lblAviso.Location = new Point(41, 130);
            }
            else if (quantidade == "0")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Defina uma quantidade";
                iconAviso.Location = new Point(27, 126);
                lblAviso.Location = new Point(52, 130);
            }

            else
            {
                ClassConexao con = new ClassConexao();
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados

                    string sql = "insert into tb_item(nome_item,descricao,quant) values" + "('" + txtNome.Text + "','" + txtDescricao.Text + "','" + txtQuant.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();

                    comando.ExecuteReader();
                    MessageBox.Show("Item adicionado!");
                    Popup.Estoque.CurrentInstance.reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    con.desconectar();
                    TelaPrincipal.CurrentInstance.Popups_Fechar();
                    this.Close();
                }
            }


        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) + 1;
            txtQuant.Text = valoradd.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) - 1;
            txtQuant.Text = valoradd.ToString();


            if(Convert.ToInt32(txtQuant.Text) <= 0) {
             txtQuant.Text = "0";
            }
        }

        private void AddItem_Load(object sender, EventArgs e)
        {
            iconCaixa.Focus();
        }
    }
}
