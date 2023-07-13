using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class DeletarUsu : Form
    {
        private Form activeForm = null;

        int id_usu, id_adm;
        public DeletarUsu(int cod_usu, int cod_adm)
        {
            InitializeComponent();
            id_usu = cod_usu;
            id_adm= cod_adm;
            CurrentInstance = this;
        }

        public static DeletarUsu CurrentInstance;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento.CurrentInstance.Fechar();
            this.Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClassUsuario usu = new ClassUsuario();
            if (senha_admin == usu.getMD5hash(txtSenha.Text) && cpf_usuario == txtUsuario.Text)
            {
                bool resultado = Deletar(txtUsuario.Text, txtSenha.Text);
                if (resultado)
                {
                    MessageBox.Show("Conta desativada com sucesso!");
                    Gerenciamento.CurrentInstance.reset();
                    Gerenciamento.CurrentInstance.Fechar();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
            
            else if (txtUsuario.Text == "CPF DO USUÁRIO" || txtUsuario.Text == null)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF em branco";
                iconAviso.Location = new System.Drawing.Point(56, 257);
                lblAviso.Location = new System.Drawing.Point(81, 261);
            }

            else if (CPFLength != 11)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF inválido";
                iconAviso.Location = new System.Drawing.Point(59, 257);
                lblAviso.Location = new System.Drawing.Point(84, 261);
            }

            else if (txtSenha.Text == "SENHA DO ADMINISTRADOR" || txtSenha.Text == null)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Senha em branco";
                iconAviso.Location = new System.Drawing.Point(48, 257);
                lblAviso.Location = new System.Drawing.Point(73, 261);
            }

            else
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF ou senha incorretos";
                iconAviso.Location = new System.Drawing.Point(32, 257);
                lblAviso.Location = new System.Drawing.Point(57, 261);
            }

        }

        public bool Deletar(string cpf, string senha)
        {

            ClassUsuario usu = new ClassUsuario();
            ClassConexao con = new ClassConexao();
            MySqlConnection connection = con.getConexao();

            // Comando SQL para desativar o usuário
            string sql = "UPDATE tb_usuario SET stats = @stats WHERE id_usuario = "+id_usu+" ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@stats", "Inativo");


            connection.Open();
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();

            if (rowsAffected > 0 && rowsAffected >0)
            {
                return true; // Conta desativada com sucesso
            }
            else
            {
                return false; // Falha ao desativar a conta
            }

        }

        #region Interações visuais

        private void txtUsuário_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "CPF DO USUÁRIO")
            {
                txtUsuario.Text = "";
                lblCPF.Visible = true;
                iconAviso.Visible = false;
                lblAviso.Visible = false;
            }
        }

        private void txtUsuário_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "CPF DO USUÁRIO";
                lblCPF.Visible = false;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA DO ADMINISTRADOR")  
            {
                txtSenha.Text = "";
                lblSenha.Visible = true;
                txtSenha.UseSystemPasswordChar = true;
                iconAviso.Visible = false;
                lblAviso.Visible = false;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA DO ADMINISTRADOR";
                lblSenha.Visible = false;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtUsuário_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        #endregion
        string cpf_usuario, senha_admin;
        int CPFLength;

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no CPF
            string cpf = txtUsuario.Text.Replace(".", "").Replace("-", "");

            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length == 11)
            {
                // Formatar o CPF com os pontos e o traço
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";

                // Atualizar o texto da TextBox com o CPF formatado
                txtUsuario.Text = cpf;

                txtUsuario.SelectionStart = txtUsuario.Text.Length;
            }

            CPFLength = txtUsuario.Text.Length;

            if (txtUsuario.Text.Length > 14)
            {
                txtUsuario.Text = txtUsuario.Text.Substring(0, 14);
                txtUsuario.SelectionStart = txtUsuario.Text.Length;
            }
            ;
        }

        private void DeletarUsu_Load(object sender, EventArgs e)
        {
            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao = con1.getConexao();
            String consulta = "";
            consulta = " SELECT cpf from tb_usuario where id_usuario = " + id_usu;
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            cpf_usuario = Convert.ToString(registro["cpf"]);
            conexao.Close();

            ClassConexao con2 = new ClassConexao();
            MySqlConnection conexao2 = con2.getConexao();
            String consulta2 = "";
            consulta2 = " SELECT senha from tb_admin where id_admin = " + id_adm;
            MySqlCommand commando2 = new MySqlCommand(consulta2, conexao2);
            conexao2.Open();
            MySqlDataReader registro2 = commando2.ExecuteReader();
            registro2.Read();
            senha_admin = Convert.ToString(registro2["senha"]);
            conexao2.Close();

        }
    }
}
