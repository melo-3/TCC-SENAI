using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // Usado para fechar e abrir uma pagina
using MySql.Data.MySqlClient;
using System.Runtime.ConstrainedExecution;
using FontAwesome.Sharp;
using System.IO;

namespace Almoxarifado_TCC.Popup
{
    public partial class Perfil : Form
    {

        private Form activeForm = null;

        public string Imagem;
        Thread nt; // Usado para fechar o programa
        public int codigoid;
        public string nome;
        public string email;

        public Perfil(int codigoid)
        {
            this.codigoid = codigoid;
            InitializeComponent();
            CurrentInstance = this;
        }

        public static Perfil CurrentInstance;

        private void btnDesconectar_Click(object sender, EventArgs e)// Fecha o programa
        {
            Application.Exit();
            nt = new Thread(novoform);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoform()// define o programa que vai ser aberto
        {
            Application.Run(new Login());
        }

        public void exe_imagem()
        {
            ClassUsuario usu = new ClassUsuario(); // chamo a classe usuário
            ClassConexao con = new ClassConexao(); // chamo a classe conexão
            string logar = "SELECT nome_admin, email, foto FROM tb_admin WHERE id_admin = @id";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            comando.Parameters.AddWithValue("@id", this.codigoid);

            conexao.Open();

            MySqlDataReader registro = comando.ExecuteReader(); // executa a consulta
            if (registro.Read())
            {
                string nome = registro["nome_admin"].ToString();
                string email = registro["email"].ToString();
                object fotoValue = registro["foto"];
                byte[] imageData = fotoValue != DBNull.Value ? (byte[])fotoValue : null;

                lblNome.Text = nome;
                lblEmail.Text = email;

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        panelPerfiFoto.BackgroundImage = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Caso a imagem seja nula, limpa o controle
                    panelPerfiFoto.BackgroundImage = null;
                }
            }

            conexao.Close();
        }


        private void Perfil_Load(object sender, EventArgs e)
        {
            exe_imagem();
        }

        #region Visual button animation

        public static class CoresGlobais
        {
            public static Color Sobre { get; } = Color.FromArgb(73, 78, 92);
            public static Color Normal { get; } = Color.FromArgb(56, 60, 71);

        }

        // Animação de cores do botão Senha, opção de Segurança (Ignore, coisa de front!!!)
        private void iconSetaSenha_MouseMove(object sender, MouseEventArgs e)
        {
            panelSenha.BackColor = CoresGlobais.Sobre;
        }

        private void iconSetaSenha_MouseLeave(object sender, EventArgs e)
        {
            panelSenha.BackColor = CoresGlobais.Normal;
        }

        private void iconSetaSenha_MouseDown(object sender, MouseEventArgs e)
        {
            //SENHA ALTERAR
            Popup.RedefinirSenha go = new Popup.RedefinirSenha(codigoid);
            go.ShowDialog();
        }

        //-----------------------------------------------------------------

        // Animação de cores do botão Telefone, opção de Segurança

        private void iconSetaTele_MouseMove(object sender, MouseEventArgs e)
        {
            panelTelefone.BackColor = CoresGlobais.Sobre;
        }

        private void iconSetaTele_MouseLeave(object sender, EventArgs e)
        {
            panelTelefone.BackColor = CoresGlobais.Normal;
        }

        private void iconSetaTele_MouseDown(object sender, MouseEventArgs e)
        {
            Popup.RedefinirTelefone go = new Popup.RedefinirTelefone(codigoid);
            go.ShowDialog();
        }

        //-----------------------------------------------------------------

        // Animação de cores do botão Email, opção de Segurança

        private void iconSetaEmail_MouseMove(object sender, MouseEventArgs e)
        {
            panelEmail.BackColor = CoresGlobais.Sobre;
        }

        private void iconSetaEmail_MouseLeave(object sender, EventArgs e)
        {
            panelEmail.BackColor = CoresGlobais.Normal;
        }

        private void iconSetaEmail_MouseDown(object sender, MouseEventArgs e)
        {
            Popup.RedefinirEmail go = new Popup.RedefinirEmail(codigoid);
            go.ShowDialog();
        }

        //-----------------------------------------------------------------

        // Animação de cores do botão Usuario, opção de Criar Perfil

        private void iconSetaUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            panelUsuario.BackColor = CoresGlobais.Sobre;
        }

        private void iconSetaUsuario_MouseLeave(object sender, EventArgs e)
        {
            panelUsuario.BackColor = CoresGlobais.Normal;
        }

        private void iconSetaUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            Popup.CriarUsuario go = new Popup.CriarUsuario();
            go.ShowDialog();
        }

        //-----------------------------------------------------------------

        // Animação de cores do botão Administrador, opção de Criar Perfil

        private void iconSetaAdm_MouseMove(object sender, MouseEventArgs e)
        {
            panelAdm.BackColor = CoresGlobais.Sobre;
        }

        private void iconSetaAdm_MouseLeave(object sender, EventArgs e)
        {
            panelAdm.BackColor = CoresGlobais.Normal;
        }

        private void iconSetaAdm_MouseDown(object sender, MouseEventArgs e)
        {
            Popup.CriarAdmin go = new Popup.CriarAdmin();
            go.ShowDialog();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Popup.DeletarConta go = new Popup.DeletarConta(codigoid);
            go.ShowDialog();
        }

        private void btnDesconectar_MouseEnter(object sender, EventArgs e)
        {
            btnDesconectar.ForeColor = CoresGlobais.Sobre;
            btnDesconectar.IconColor = CoresGlobais.Sobre;
        }

        private void btnDesconectar_MouseLeave(object sender, EventArgs e)
        {
            btnDesconectar.ForeColor = Color.White;
            btnDesconectar.IconColor = Color.White;
        }

        #endregion


        private void iconFoto_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";

                if (foto.ShowDialog() == DialogResult.OK)
                {
                    string filePath = foto.FileName;
                    byte[] imageData = File.ReadAllBytes(filePath); // Lê os dados da imagem selecionada

                    MySqlConnection connection1 = new MySqlConnection("server=localhost;database=db_almoxarifado;user=root;password=;");
                    connection1.Open();

                    string updateQuery = "UPDATE tb_admin SET foto = @foto WHERE id_admin = @id";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection1);
                    command.Parameters.AddWithValue("@foto", imageData);
                    command.Parameters.AddWithValue("@id", this.codigoid);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Foto atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar a foto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection1.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            MySqlConnection connection = null;

            try
            {
                ClassConexao con = new ClassConexao();         //instancia de conexão
                MySqlConnection conexao = con.getConexao();      //obtive a conexao

                string selectQuery = "SELECT foto FROM tb_admin WHERE id_admin = @id";
                MySqlCommand command = new MySqlCommand(selectQuery, conexao);
                command.Parameters.AddWithValue("@id", this.codigoid);

                conexao.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read()) 
                    {
                        if (!reader.IsDBNull(0))
                        {
                            byte[] imageData = (byte[])reader["foto"];

                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                picPerfil.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picPerfil.Image = null; // Se a imagem for nula, limpa o controle PictureBox
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Lidar com exceções relacionadas ao MySQL aqui
            }
            finally
            {
                // Certifique-se de fechar a conexão, mesmo em caso de exceção
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
