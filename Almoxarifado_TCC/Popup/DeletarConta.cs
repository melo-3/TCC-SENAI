using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace Almoxarifado_TCC.Popup
{
    public partial class DeletarConta : Form
    {
        Thread nt; // Usado para fechar o programa

        private int codigoid;
        public DeletarConta(int codigoid)
        {
            this.codigoid = codigoid;
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeletarConta_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconExc_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
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

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            string senha = txtSenha.Text;
            bool resultado = Deletar(cpf, senha);

            if (resultado)
            {
                MessageBox.Show("Conta deletada com sucesso!");
                Application.Exit(); // Fecha o programa atual e abre um novo
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Conta não encontrada.");
            }
        }

        public bool Deletar(string cpf, string senha)
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            MySqlConnection connection = con.getConexao();

            // Comando SQL para deletar a conta
            string sql = "DELETE FROM tb_admin WHERE cpf = @cpf AND senha = @senha";
            MySqlCommand command = new MySqlCommand(sql, connection);
            connection.Open();
            command.Parameters.AddWithValue("@cpf", cpf);
            command.Parameters.AddWithValue("@senha", usu.getMD5hash(senha));

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                return true; // Conta deletada com sucesso
            }
            else
            {
                return false; // Falha ao deletar a conta
            }
            connection.Close();

        }

        private void novoform()// define o programa que vai ser aberto
        {
            Application.Run(new Login());
        }

    }
  }

