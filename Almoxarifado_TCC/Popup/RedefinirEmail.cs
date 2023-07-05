using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class RedefinirEmail : Form
    {
        private int codigoid;
        public RedefinirEmail(int codigoid)
        {
            InitializeComponent();
            this.codigoid = codigoid;
        }

        // Código para funcionalidade visual

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RedefinirEmail_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void txtEmailAtual_Enter(object sender, EventArgs e)
        {
            if (txtEmailAtual.Text == "EMAIL ATUAL")
            {
                txtEmailAtual.Text = "";
            }
        }

        private void txtEmailAtual_Leave(object sender, EventArgs e)
        {
            if (txtEmailAtual.Text == "")
            {
                txtEmailAtual.Text = "EMAIL ATUAL";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "NOVO EMAIL")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "NOVO EMAIL";
            }
        }// ----------------------------------------------------------

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string senha;
        private void verificacao() // Verifica se as informações inseridas no login estão corretas ou não
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            string SQL = "select * from tb_admin where id_admin=@id_admin";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@id_admin", codigoid);
            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta

            iconAviso.Visible = false;
            lblAviso.Visible = false;
            lblAviso.Text = "";

            if (registro.HasRows)
            {
                registro.Read();
                usu.login = Convert.ToString(registro["cpf"]);
                senha = Convert.ToString(registro["senha"]);
                usu.logado = true;

            }

            
                if (txtSenha.Text == "SENHA")
                {
                    lblAviso.Text = "O campo SENHA está em branco";
                }
                if (txtEmailAtual.Text == "EMAIL ATUAL")
                {
                    lblAviso.Text = "O campo EMAIL ATUAL está em branco";
                }
                if (txtEmailAtual.Text == "NOVO EMAIL")
                {
                    lblAviso.Text = "O campo NOVO EMAIL está em branco";
                }
            

        }

            private void btnAlterar_Click(object sender, EventArgs e)
        {
            verificacao();
            ClassUsuario usu = new ClassUsuario(); // Chama a classe Usuario
            ClassConexao con = new ClassConexao(); // Chama a classe Conexao
            string AtualEmail = txtEmailAtual.Text;
            string novoEmail = txtEmail.Text;

            // Verifica se as senhas informadas são iguais
            //MessageBox.Show(senha);
            if(usu.getMD5hash(txtSenha.Text) == senha)
            {
                if (novoEmail != AtualEmail)
                {
                    MySqlConnection conexao = con.getConexao();
                    string SQL = "UPDATE tb_admin SET email=@email WHERE id_admin=@id_admin"; // Atualiza a senha na tabela do banco de dados
                    MySqlCommand comando = new MySqlCommand(SQL, conexao);
                    conexao.Open();
                    comando.Parameters.AddWithValue("@email", novoEmail);
                    comando.Parameters.AddWithValue("@id_admin", codigoid);
                    comando.ExecuteNonQuery(); // Executa a atualização
                    conexao.Close();

                    MessageBox.Show("Email alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Limpa os campos de senha
                    txtSenha.Text = "";
                    txtEmailAtual.Text = "";
                    txtEmail.Text = "";
                }
                else
                {
                    MessageBox.Show("Os emails não coincidem, por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A senha não coincide, por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
