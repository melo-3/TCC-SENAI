using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class FormNovaSenha : Form
    {

        public string cpf;
        public FormNovaSenha(string cpf)
        {
            InitializeComponent();
            this.cpf = cpf;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ClassUsuario usu = new ClassUsuario(); // Chama a classe Usuario
            ClassConexao con = new ClassConexao(); // Chama a classe Conexao
            string novaSenha = txtNVSenha.Text;
            string confirmarSenha = txtRNVSenha.Text;

            // Verifica se as senhas informadas são iguais
            if (novaSenha == confirmarSenha)
            {
                MySqlConnection conexao = con.getConexao();
                string SQL = "UPDATE tb_admin SET senha=@senha WHERE cpf=@cpf"; // Atualiza a senha na tabela do banco de dados
                MySqlCommand comando = new MySqlCommand(SQL, conexao);
                conexao.Open();
                comando.Parameters.AddWithValue("@senha", usu.getMD5hash(novaSenha));
                comando.Parameters.AddWithValue("@cpf", cpf);
                comando.ExecuteNonQuery(); // Executa a atualização
                conexao.Close();

                //MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                // Limpa os campos de senha
                txtNVSenha.Text = "";
                txtRNVSenha.Text = "";
                Login.CurrentInstance.TimerLogo();
            }
            else
            {
                //MessageBox.Show("As senhas não coincidem, por favor, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtNVSenha_Enter(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "INSIRA A NOVA SENHA")
            {
                txtNVSenha.Text = "";
                txtNVSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNVSenha_Leave(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "")
            {
                txtNVSenha.Text = "INSIRA A NOVA SENHA";
                txtNVSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtRNVSenha_Enter(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "NOVA SENHA")
            {
                txtRNVSenha.Text = "";
                txtRNVSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtRNVSenha_Leave(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "")
            {
                txtRNVSenha.Text = "NOVA SENHA";
                txtRNVSenha.UseSystemPasswordChar = false;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtNVSenha.Text == "INSIRA A NOVA SENHA")
            {

            }
            else
            {
                if (txtNVSenha.UseSystemPasswordChar)
                {
                    iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    txtNVSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    iconButton1.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
                    txtNVSenha.UseSystemPasswordChar = true;
                }
            }
        }

        private void iconOlho_Click(object sender, EventArgs e)
        {
            if (txtRNVSenha.Text == "NOVA SENHA")
            {

            }
            else
            {
                if (txtRNVSenha.UseSystemPasswordChar)
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    txtRNVSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
                    txtRNVSenha.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
