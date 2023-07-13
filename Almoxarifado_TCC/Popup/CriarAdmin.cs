using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class CriarAdmin : Form
    {
        public CriarAdmin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CriarAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Gerenciamento.CurrentInstance.apagar_icons();
            this.Close();
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

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtRSenha_Enter(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "REPETIR SENHA")
            {
                txtRSenha.Text = "";
                txtRSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtRSenha_Leave(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "")
            {
                txtRSenha.Text = "REPETIR SENHA";
                txtRSenha.UseSystemPasswordChar = false;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "";
                txtTelefone.Visible = true;
                LinhaTel.Visible = true;
            }

            else
            {
                checkBox1.Text = "Deseja cadastrar um telefone?";
                txtTelefone.Visible = false;
                LinhaTel.Visible = false;
                txtTelefone.Text = "TELEFONE";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe
            ClassUsuario usu = new ClassUsuario();
            string nome = txtNome.Text, cpf = txtCPF.Text, email = txtEmail.Text, senha = txtSenha.Text, senhaR = txtRSenha.Text;
            if (nome == "NOME")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo NOME está vazio";
            }

            else if (cpf == "CPF")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo CPF está vazio";
            }

            else if (CPFLenght != 14)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Insira um CPF válido";
            }

            else if (email == "EMAIL")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo Email está vazio";
            }

            else if (senha == "SENHA")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo SENHA está vazio";
            }

            else if (senhaR == "REPETIR SENHA")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo REPETIR SENHA está vazio";
            }
           
            else if(senha != senhaR)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "As senhas nao coincidem";
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
                    string sql = "insert into tb_admin(nome_admin,cpf,email,senha,telefone) values" + "('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" + usu.getMD5hash(txtSenha.Text) + "','" + txtTelefone.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    //MessageBox.Show("Cadastro realizado!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    con.desconectar();
                    Gerenciamento.CurrentInstance.apagar_icons();
                    Gerenciamento.CurrentInstance.reset();
                    Gerenciamento.CurrentInstance.Fechar();
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

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int CPFLenght;
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no CPF
            string cpf = txtCPF.Text.Replace(".", "").Replace("-", "");

            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length == 11)
            {
                // Formatar o CPF com os pontos e o traço
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";

                // Atualizar o texto da TextBox com o CPF formatado
                txtCPF.Text = cpf;

                txtCPF.SelectionStart = txtCPF.Text.Length;
            }

            CPFLenght = txtCPF.Text.Length;

            if (txtCPF.Text.Length > 14)
            {
                txtCPF.Text = txtCPF.Text.Substring(0, 14);
                txtCPF.SelectionStart = txtCPF.Text.Length;
            }
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no número de telefone
            string telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            // Verificar se o número de telefone possui 10 ou 11 dígitos
            if (telefone.Length == 11)
            {
                // Formatar o número de telefone no formato (xx) xxxxx-xxxx
                string formattedTelefone = "";

                if (telefone.Length == 11)
                {
                    formattedTelefone = string.Format("({0}) {1}-{2}",
                        telefone.Substring(0, 2),
                        telefone.Substring(2, 5),
                        telefone.Substring(7, 4));
                }

                // Atualizar o texto selecionado da TextBox com o número de telefone formatado
                txtTelefone.Text = formattedTelefone;
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }

            if (txtTelefone.Text.Length > 15)
            {
                txtTelefone.Text = txtTelefone.Text.Substring(0, 15);
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }
        }
    }
}
