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
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
            }
        }

        private void txtRSenha_Enter(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "REPETIR SENHA")
            {
                txtRSenha.Text = "";
            }
        }

        private void txtRSenha_Leave(object sender, EventArgs e)
        {
            if (txtRSenha.Text == "")
            {
                txtRSenha.Text = "REPETIR SENHA";
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
            if (senha == "")
            {
                MessageBox.Show("Campo SENHA está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (senhaR == "")
            {
                MessageBox.Show("Campo REPETIR SENHA está vazio!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            if(senha != senhaR)
            {
                MessageBox.Show("Confirmação de senha ERRADO, as senhas nao coincidem");
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
                    string sql = "insert into tb_admin(nome_admin,cpf,email,senha,telefone,foto) values" + "('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" + usu.getMD5hash(txtSenha.Text) + "','" + txtTelefone.Text + "','" + image + "')";
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
                    Gerenciamento.CurrentInstance.apagar_icons();
                }
            }
        }
        byte[] image;
        public static class ImageDataHolder
        {
            public static byte[] imagem { get; set; }
        }

        private void iconFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog(); // Cria uma instância de OpenFileDialog para permitir que o usuário selecione uma imagem.
            foto.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png"; // Define um filtro para exibir apenas arquivos de imagem com extensões .jpg e .png.

            if (foto.ShowDialog() == DialogResult.OK) // Exibe a caixa de diálogo para selecionar a imagem e verifica se o usuário selecionou um arquivo e pressionou "OK".
            {
                string filePath = foto.FileName; // Obtém o caminho completo do arquivo selecionado.
                byte[] imageData = File.ReadAllBytes(filePath); // Lê os dados da imagem selecionada e os armazena em um array de bytes.
                image= imageData;
            } // Define a imagem de fundo do controle PictureBox (pnlFoto) com base nos dados da imagem.
            
            /*using (MemoryStream ms = new MemoryStream(imageData))
            {
                pnlFoto.BackgroundImage = Image.FromStream(ms);
            }*/
        }
    }
}
