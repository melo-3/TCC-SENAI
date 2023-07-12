using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Almoxarifado_TCC.Popup
{
    public partial class EditarUsuario : Form
    {
        int cod, codTipo;

        public EditarUsuario(int id_usu)
        {
            InitializeComponent();

            cod = id_usu;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento.CurrentInstance.Fechar();
            this.Close();
        }

        #region Pega as informações do usuário 

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe

            cmbTipo.DataSource = con.Getperfil(); //popula as info do perfil da tabela
            cmbTipo.DisplayMember = "tipo_usu"; //mostra descrição do campo
            cmbTipo.ValueMember = "id_tipo_usu"; //pega o codigo do campo

            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao = con1.getConexao();
            String consulta = "";
            consulta = " SELECT nome_usuario, cpf, telefone, email from tb_usuario where id_usuario = " + cod;
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            txtNome.Text = Convert.ToString(registro["nome_usuario"]);
            txtCPF.Text = Convert.ToString(registro["cpf"]);
            txtEmail.Text = Convert.ToString(registro["email"]);
            txtTelefone.Text = Convert.ToString(registro["telefone"]);
            conexao.Close();

            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "TELEFONE";
                lblTelefone.Visible = false;
            }
            else
            {
                lblTelefone.Visible = true;
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            codTipo = Convert.ToInt32(((DataRowView)cmbTipo.SelectedItem)["id_tipo_usu"]);
        }

        #endregion

        #region Envia as novas informações do usuário

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            { 
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Nome está vazio";
                iconAviso.Location = new Point(50, 262);
                lblAviso.Location = new Point(75, 266);
            }

            else if (txtCPF.Text == "CPF")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF está vazio";
                iconAviso.Location = new Point(52, 262);
                lblAviso.Location = new Point(77, 266);
            }

            else if (txtCPF.Text.Length != 14)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF inválido";
                iconAviso.Location = new Point(58, 262);
                lblAviso.Location = new Point(83, 266);
            }

            else if (txtEmail.Text == "EMAIL")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "E-mail está vazio";
                iconAviso.Location = new Point(51, 262);
                lblAviso.Location = new Point(76, 266);
            }

            else if (txtTelefone.Text != "TELEFONE" && txtTelefone.Text.Length !=15)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Telefone inválido";
                iconAviso.Location = new Point(51, 262);
                lblAviso.Location = new Point(76, 266);
            }

            else if (cmbTipo.Text == "Nenhum")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Selecione um tipo de usuário";
                iconAviso.Location = new Point(24, 262);
                lblAviso.Location = new Point(49, 266);
            }

            else
            {
                if (txtTelefone.Text == "TELEFONE")
                    txtTelefone.Text = "";

                ClassConexao con1 = new ClassConexao();
                MySqlConnection conexao1 = con1.getConexao();
                string sql1 = "UPDATE tb_usuario SET nome_usuario = @nome, id_tipo_usu = @tipo, cpf = @cpf, telefone = @tele, email = @ema where id_usuario= " + cod + ";";
                MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
                command1.Parameters.AddWithValue("@nome", txtNome.Text);
                command1.Parameters.AddWithValue("@tipo", codTipo);
                command1.Parameters.AddWithValue("@cpf", txtCPF.Text);
                command1.Parameters.AddWithValue("@tele", txtTelefone.Text);
                command1.Parameters.AddWithValue("@ema", txtEmail.Text);
                conexao1.Open();
                command1.ExecuteNonQuery();
                conexao1.Close();

                Gerenciamento.CurrentInstance.reset();
                Gerenciamento.CurrentInstance.Fechar();
                this.Close();
            }
            
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int CPFlenght;
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

            if (txtCPF.Text.Length > 14)
            {
                txtCPF.Text = txtCPF.Text.Substring(0, 14);
                txtCPF.SelectionStart = txtCPF.Text.Length;
            }

            CPFlenght = txtCPF.Text.Length;
        }

        #endregion

        #region Interações visuais

        public static class CoresGlobais
        {
            public static Color Danger { get; } = Color.Red;
            public static Color Normal { get; } = SystemColors.ButtonFace;
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            {
                txtNome.Text = "";
                txtNome.ForeColor = CoresGlobais.Normal;
                lblNome.Visible = true;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "NOME";
                lblNome.Visible = false;
            }
                
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
                txtCPF.ForeColor = CoresGlobais.Normal;
                lblCPF.Visible = true;
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
                lblCPF.Visible = false;
            }
                
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = CoresGlobais.Normal;
                lblEmail.Visible = true;
            }
                
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
                lblEmail.Visible = false;
            }
                
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "TELEFONE")
            {
                txtTelefone.Text = "";
                lblTelefone.Visible = true;
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

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "TELEFONE";
                lblTelefone.Visible = false;
            }
        }

        #endregion

    }
}
