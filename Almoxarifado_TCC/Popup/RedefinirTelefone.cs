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
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class RedefinirTelefone : Form
    {
        private int codigoid;

        public RedefinirTelefone(int codigoid)
        {
            InitializeComponent();
            this.codigoid = codigoid;
        }


        // Código para funcionalidade visual

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void RedefinirTelefone_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void txtTelefoneAtual_Enter(object sender, EventArgs e)
        {
            if (txtTelefoneAtual.Text == "TELEFONE ATUAL")
            {
                txtTelefoneAtual.Text = "";
            }
        }

        private void txtTelefoneAtual_Leave(object sender, EventArgs e)
        {
            if (txtTelefoneAtual.Text == "")
            {
                txtTelefoneAtual.Text = "TELEFONE ATUAL";
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "NOVO TELEFONE")
            {
                txtTelefone.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "NOVO TELEFONE";
            }
        }// -----------------------------------------------------------

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
                if (txtTelefoneAtual.Text == "TELEFONE ATUAL")
                {
                    lblAviso.Text = "O campo TELEFONE ATUAL está em branco";
                }
                if (txtTelefone.Text == "NOVO TELEFONE")
                {
                    lblAviso.Text = "O campo NOVO TELEFONE está em branco";
                }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            verificacao();
            ClassUsuario usu = new ClassUsuario(); // Chama a classe Usuario
            ClassConexao con = new ClassConexao(); // Chama a classe Conexao
            string TelefoneNovo = txtTelefone.Text;
            string TelefoneAtual = txtTelefoneAtual.Text;

            // Verifica se as senhas informadas são iguais
            if (usu.getMD5hash(txtSenha.Text) == senha)
            {
                if (TelefoneAtual != TelefoneNovo)
                {
                    MySqlConnection conexao = con.getConexao();
                    string SQL = "UPDATE tb_admin SET telefone=@telefone WHERE id_admin=@id_admin"; // Atualiza a senha na tabela do banco de dados
                    MySqlCommand comando = new MySqlCommand(SQL, conexao);
                    conexao.Open();
                    comando.Parameters.AddWithValue("@telefone", TelefoneNovo);
                    comando.Parameters.AddWithValue("@id_admin", codigoid);
                    comando.ExecuteNonQuery(); // Executa a atualização
                    conexao.Close();

                    //MessageBox.Show("Telefone Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Limpa os campos de senha
                    txtSenha.Text = "";
                    txtTelefone.Text = "";
                    txtTelefoneAtual.Text = "";
                }
                else
                {
                    iconAviso.Visible = true;
                    lblAviso.Visible = true;
                    lblAviso.Text = "O telefone novo é igual ao atual";
                }
            }
            
            else
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Senha incorreta";
            }

        }

        private void txtTelefoneAtual_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no número de telefone
            string telefone = txtTelefoneAtual.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
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
                txtTelefoneAtual.Text = formattedTelefone;
                txtTelefoneAtual.SelectionStart = txtTelefoneAtual.Text.Length;
            }

            if (txtTelefoneAtual.Text.Length > 15)
            {
                txtTelefoneAtual.Text = txtTelefoneAtual.Text.Substring(0, 15);
                txtTelefoneAtual.SelectionStart = txtTelefoneAtual.Text.Length;
            }
        }

        private void txtTelefoneAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
