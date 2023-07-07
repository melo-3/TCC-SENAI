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
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class AddChave : Form
    {
        public AddChave()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AddChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Fecha a tela de PopUp
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Número")
            {
                txtNumero.Text = "";
                lblNumero.Visible = true;
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Número";
                lblNumero.Visible = false;
            }
        }

        private void txtSala_Enter(object sender, EventArgs e)
        {
            if (txtSala.Text == "Sala / Lab")
            {
                txtSala.Text = "";
                lblSala.Visible = true;
            }
        }

        private void txtSala_Leave(object sender, EventArgs e)
        {
            if (txtSala.Text == "")
            {
                txtSala.Text = "Sala / Lab";
                lblSala.Visible = false;
            }
        }

        private void txtObs_Enter(object sender, EventArgs e)
        {
            if (txtObs.Text == "Obs")
            {
                txtObs.Text = "";
                lblObs.Visible = true;
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (txtObs.Text == "")
            {
                txtObs.Text = "Obs";
                lblObs.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //botao adicionar
            string numero = txtNumero.Text, sala = txtSala.Text, status = cbxStatus.Text, obs = txtObs.Text;

            if (numero == "" || numero == "Número")
            {
                MessageBox.Show("Campo Número está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (sala == "" || sala == "Sala / Lab")
            {
                MessageBox.Show("Campo Sala está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if(status == "")
            {
                MessageBox.Show("Campo Status está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                ClassConexao con = new ClassConexao();
                try
                {
                    if (txtObs.Text == "Obs")
                    {
                        txtObs.Text = "";
                    }
                    
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    
                    string sql = "insert into tb_chave(num_chave,sala_lab,stats,obs) values" + "('" + txtNumero.Text + "','" + txtSala.Text + "','" + cbxStatus.Text + "','" + txtObs.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    
                    comando.ExecuteReader();
                    MessageBox.Show("Chave adicionada!");
                    Popup.Chave.CurrentInstance.reset();
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
    }
}
