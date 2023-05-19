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
            //MessageBox.Show("id admin: " + this.codigoid);
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            String logar = "SELECT nome_admin,email,foto FROM tb_admin where id_admin=@id";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@id", this.codigoid);

            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta
            registro.Read();
            nome = Convert.ToString(registro["nome_admin"]);
            email = Convert.ToString(registro["email"]);
            Imagem = Convert.ToString(registro["foto"]);

            lblNome.Text = nome;
            lblEmail.Text = email;

            char v = '\\';
            string Imagem2 = Imagem.Replace('*', v);

            if (Imagem2 == "")
            {

            }
            else
            {
                panelPerfiFoto.BackgroundImage = Image.FromFile(Imagem2);
            }
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
                //abre a caixa de seleção da foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image Files(*.jpg;*.png)|*.jpg; *png";
                if (foto.ShowDialog() == DialogResult.OK)
                {//pega o nome do arquivo
                  label1.Text = foto.FileName;
                    //captura o nome para o arquivo da foto
                    Image file = Image.FromFile(foto.FileName);
                    panelPerfiFoto.BackgroundImage = file;//carrega a foto selecionada
                    
                    ClassConexao con = new ClassConexao();

                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    char v = '\\';

                    string barras = @label1.Text;
                    string barras2 = barras.Replace(v, '*');
                    //MessageBox.Show("Caminho: " + barras2);

                    string sql = "UPDATE tb_admin SET foto = '" + barras2 + "' where id_admin = @id;";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.Parameters.AddWithValue("@id", this.codigoid);

                    comando.ExecuteReader();
                    //MessageBox.Show("Foto!");
                    exe_imagem();
                }
                else
                {
                    MessageBox.Show("Não escolheu nenhuma imagem");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
    }
}
