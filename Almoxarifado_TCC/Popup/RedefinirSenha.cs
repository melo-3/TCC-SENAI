using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class RedefinirSenha : Form
    {
        private int codigoid;

        public RedefinirSenha(int codigoid)
        {
            InitializeComponent();
            this.codigoid = codigoid;
        }

        // Código para funcionalidade visual

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void txtCriarUsu_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RedefinirSenha_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtSenhaAtual_Enter(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text == "SENHA ATUAL")
            {
                txtSenhaAtual.Text = "";
            }
        }

        private void txtSenhaAtual_Leave(object sender, EventArgs e)
        {
            if (txtSenhaAtual.Text == "")
            {
                txtSenhaAtual.Text = "SENHA ATUAL";
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "NOVA SENHA")
            {
                txtSenha.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "NOVA SENHA";
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
        }// --------------------------------------------------------



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

            else if (txtSenhaAtual.Text == "SENHA ATUAL" || txtSenha.Text == "SENHA")
            {
                if (txtSenhaAtual.Text == "SENHA ATUAL")
                {
                    lblAviso.Text = "O campo SENHA ATUAL está em branco";
                }
                if (txtSenha.Text == "SENHA")
                {
                    lblAviso.Text = "O campo SENHA está em branco";
                }
                if (txtRSenha.Text == "REPETIR SENHA")
                {
                    lblAviso.Text = "O campo REPETIR SENHA está em branco";
                }
            }

          

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            verificacao();
            ClassUsuario usu = new ClassUsuario(); // Chama a classe Usuario
            ClassConexao con = new ClassConexao(); // Chama a classe Conexao
            string novaSenha = usu.getMD5hash(txtSenha.Text);
            string confirmarSenha = usu.getMD5hash(txtRSenha.Text);

            // Verifica se as senhas informadas são iguais
            if (usu.getMD5hash(txtSenhaAtual.Text) == senha)
            {
                if (novaSenha == confirmarSenha && novaSenha != usu.getMD5hash(txtSenhaAtual.Text))
                {
                    MySqlConnection conexao = con.getConexao();
                    string SQL = "UPDATE tb_admin SET senha=@senha WHERE id_admin=@id_admin"; // Atualiza a senha na tabela do banco de dados
                    MySqlCommand comando = new MySqlCommand(SQL, conexao);
                    conexao.Open();
                    comando.Parameters.AddWithValue("@senha", novaSenha);
                    comando.Parameters.AddWithValue("@id_admin", codigoid);
                    comando.ExecuteNonQuery(); // Executa a atualização
                    conexao.Close();

                    MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Limpa os campos de senha
                    txtSenhaAtual.Text = "";
                    txtSenha.Text = "";
                    txtRSenha.Text = "";
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem, por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            else
            {
                MessageBox.Show("A senha atual não está correta, por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
