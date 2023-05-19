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
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
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

        private void verificacao() // Verifica se as informações inseridas no login estão corretas ou não
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            string SQL = "select * from tb_admin where telefone=@telefone";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@telefone", txtTelefoneAtual.Text);
            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta

            iconAviso.Visible = false;
            lblAviso.Visible = false;
            lblAviso.Text = "";

            if (registro.HasRows)
            {
                registro.Read();
                usu.login = Convert.ToString(registro["cpf"]);
                usu.senha = Convert.ToString(registro["senha"]);
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

                MessageBox.Show("Telefone Alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                // Limpa os campos de senha
                txtSenha.Text = "";
                txtTelefone.Text = "";
                txtTelefoneAtual.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCriarUsu_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
