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
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class CriarUsuario : Form
    {
        public CriarUsuario()
        {
            InitializeComponent();
            //this.TopMost = true;
        }

        // Código que permite ao usuario mover o programa pela tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CriarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "";
                txtTelefone.Visible = true;
                LinhaTel.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Deseja cadastrar um telefone?";
                txtTelefone.Text = "TELEFONE";
                txtTelefone.Visible = false;
                LinhaTel.Visible = false;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            {
                txtNome.Text = "";
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "NOME";
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "TELEFONE")
            {
                txtTelefone.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "TELEFONE";
            }
        }

        int codTipo;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codTipo = Convert.ToInt32(((DataRowView)cmbTipo.SelectedItem)["id_tipo_usu"]);  
        }

        private void CriarUsuario_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe

            cmbTipo.DataSource = con.Getperfil(); //popula as info do perfil da tabela
            cmbTipo.DisplayMember = "tipo_usu"; //mostra descrição do campo
            cmbTipo.ValueMember = "id_tipo_usu"; //pega o codigo do campo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe
            ClassUsuario usu = new ClassUsuario();
            string nome = txtNome.Text, cpf = txtCPF.Text, email = txtEmail.Text;
            if (nome == "")
            {
                MessageBox.Show("Campo NOME está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cpf == "")
            {
                MessageBox.Show("Campo CPF está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (email == "")
            {
                MessageBox.Show("Campo Email está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (CPFLenght != 11)
            {
                MessageBox.Show("Insira um CPF válido!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    if (txtTelefone.Text == "TELEFONE")
                    {
                        txtTelefone.Text = "";
                    }
                    string sql = "insert into tb_usuario(nome_usuario,cpf,email,telefone,id_tipo_usu) values" + "('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "','" + codTipo + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    MessageBox.Show("Cadastro realizado!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    con.desconectar();
                }
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int CPFLenght = 0;
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text.Length > 11)
            {
                txtCPF.Text = txtCPF.Text.Remove(txtCPF.Text.Length - 1);
                txtCPF.Select(11, 0); // Coloca o cursor no final do texto
            }
            CPFLenght = txtCPF.Text.Length;
        }
    }
}
