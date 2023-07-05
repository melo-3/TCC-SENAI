using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading; // Usado para fechar e abrir uma pagina
using MySql.Data.MySqlClient;
using System.Windows.Controls.Primitives;
using System.Speech.Synthesis;
using System.Timers;

namespace Almoxarifado_TCC
{
    public partial class Login : Form
    {
        //Variaveis usadas para a animação de escrita
        private string fullText;
        private int currentLength;

        Thread nt; // Usado para fechar o programa
        
        public int codigoid;
        private Form activeForm = null;

        // Variavel usada para verificar se qual das animações deve ser usada. 
        public int identificador = 1;
        //Se for 1, o painel vai da esquerda para a direita. Se for 0 o painel vai da Direita para a esquerda.

        public Login()
        {
            InitializeComponent();
            // Define a string completa que será exibida no label
            fullText = "Esqueceu a senha?";

            // Inicializa o contador de caracteres exibidos como zero
            currentLength = 0;

            CurrentInstance = this;

        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelTela.Controls.Add(childForm);
            panelTela.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        // Código que permite ao usuario mover o programa pela tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //--------------------------------------------------------------------------------------------
        
        //Buttons
        private void txtUsuario_Enter(object sender, EventArgs e)// Opção que define quando o usuario seleciona a caixa de texto [CPF]
        {
            if(txtUsuario.Text == "CPF"){
                txtUsuario.Text = "";
                lblCPF.Visible = true;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)// Opção que define quando o usuario sai da caixa de texto [CPF]
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "CPF";
                lblCPF.Visible = false;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)// Opção que define quando o usuario seleciona a caixa de texto [SENHA]
        {
            if (txtSenha.Text == "SENHA")
            {
                txtSenha.Text = "";
                txtSenha.UseSystemPasswordChar = true;
                lblSenha1.Visible = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)// Opção que define quando o usuario sai da caixa de texto [SENHA]
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "SENHA";
                txtSenha.UseSystemPasswordChar = false;
                lblSenha1.Visible = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)// Botão que minimiza o programa
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)// Botão que fecha o programa
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)// Códigos funcionais do botão de Avançar
        {
            verificacao();// Void que verifica se as informações inseridas no login estão corretas ou não
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)// Permite que o usuario passe de CPF para SENHA ao clicar ENTER
        {
            if (e.KeyCode == Keys.Enter && txtUsuario.Text != "CPF" && txtUsuario.Text != "")
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)// Permite que o usuario passe de SENHA para AVANÇAR ao clicar ENTER
        {
            if (e.KeyCode == Keys.Enter && txtSenha.Text != "CPF" && txtSenha.Text != "")
            {
                verificacao();
            }
        }

        public void LerId()
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao

            MySqlConnection conexao2 = con.getConexao();
            conexao2.Open();

            string consulta_id = "select id_admin from tb_admin where cpf=@cpf";

            MySqlCommand comando2 = new MySqlCommand(consulta_id, conexao2);
            comando2.Parameters.AddWithValue("@cpf", txtUsuario.Text);
            MySqlDataReader registro2 = comando2.ExecuteReader();//executa a consulta
            registro2.Read();
            this.codigoid = Convert.ToInt32(registro2["id_admin"]);
            //MessageBox.Show("id admin: " + this.codigoid);
            conexao2.Close();
        }

        private void verificacao() // Verifica se as informações inseridas no login estão corretas ou não
        {
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            String logar = "SELECT * FROM tb_admin where cpf=@cpf AND senha=@senha";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@cpf", txtUsuario.Text);
            comando.Parameters.AddWithValue("@senha", txtSenha.Text);

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
                LerId();
                Application.Exit(); // Fecha o programa atual e abre um novo
                nt = new Thread(novoform);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }

            else if (txtUsuario.Text == "CPF" || txtSenha.Text == "SENHA")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;

                if (txtUsuario.Text == "CPF" && txtSenha.Text == "SENHA")
                {
                    lblAviso.Text = "Insira seus dados antes de continuar";
                }
                else if (txtUsuario.Text == "CPF")
                {
                    lblAviso.Text = "O campo CPF está em branco";
                }
                else if (txtSenha.Text == "SENHA")
                {
                    lblAviso.Text = "O campo SENHA está em branco";
                }
            }

            else
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Usuário ou senha inválidos";
                if (lblSenha.Visible == false)
                {
                   lblSenha.Visible = true;
                   lblSenha.Text = "";
                   currentLength = 0;
                   tmESenha.Start();
                }
            }
        }

        private void novoform()// define o programa que vai ser aberto
        {
            Application.Run(new TelaPrincipal(this.codigoid));
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "SENHA")
            {

            }
            else {
                if (txtSenha.UseSystemPasswordChar)
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.Eye;
                    txtSenha.UseSystemPasswordChar = false;
                }
                else
                {
                    iconOlho.IconChar = FontAwesome.Sharp.IconChar.EyeLowVision;
                    txtSenha.UseSystemPasswordChar = true;
                }
            }
        }

        private void tmLogoExpandir_Tick(object sender, EventArgs e)
        {
            // Habilita o botão, permitindo que o usuario posso clicar nele
            lblSenha.Enabled = false;

            // Aumenta a largura do painel em 17 pixels a cada intervalo de tempo
            panelLogo.Width += 17;

            // Verifica se o painel chegou ao lado direito da tela
            if (panelLogo.Width >= this.Width)
            {
                // Define a largura final do painel igual à largura da tela
                panelLogo.Width = this.Width;

                // Para o Timer de expansão
                tmLogoExpandir.Enabled = false;

                // Inicia o Timer para contração do painel
                tmLogoRetrair.Enabled = true;
            }
        }

        private void tmLogoRetrair_Tick(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(27, 30, 36);
            btnMinimize.BackColor = Color.FromArgb(27, 30, 36);

            // Reduz a largura do painel em 17 pixels a cada intervalo de tempo
            panelLogo.Width -= 17;

            // Move o painel para a direita em 17 pixels a cada intervalo de tempo
            panelLogo.Left += 17;
            
            panelTela.Location = new Point(panelTela.Location.Y, 0);
            
            // Verifica se o painel voltou à posição inicial à esquerda da tela
            if (panelLogo.Width <= 250)
            {
                
                // Define a posição final do painel no lado direito da tela
                panelLogo.Left = 544;

                // Para o Timer de contração
                tmLogoRetrair.Enabled = false;

                // Dsabilita o botão, para impedir que o usuario clique mais de uma vez nele seguida.
                lblSenha.Enabled = true;
            }
        }

        private void tmLogoExpandir2_Tick(object sender, EventArgs e)
        {
            // Habilita o botão, permitindo que o usuario posso clicar nele
            lblSenha.Enabled = false;

            // Aumenta a largura do painel em 5 pixels a cada intervalo de tempo
            panelLogo.Width += 17;

            // Move o painel para a esquerda em 5 pixels a cada intervalo de tempo
            panelLogo.Left -= 17;

            // Verifica se o painel chegou ao lado esquerdo da tela
            if (panelLogo.Left <= 0)
            {
                // Para o Timer
                tmLogoExpandir2.Enabled = false;

                // Define a posição final do painel à esquerda da tela
                panelLogo.Left = 0;

                // Inicia uma nova animação para contração do painel
                tmLogoRetrair2.Enabled = true;
            }
        }

        private void tmLogoRetrair2_Tick(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(56, 60, 71);
            btnMinimize.BackColor = Color.FromArgb(56, 60, 71);


            // Reduz a largura do painel em 5 pixels a cada intervalo de tempo
            panelLogo.Width -= 10;

            // Move o painel para a esquerda em 5 pixels a cada intervalo de tempo
            panelLogo.Left -= 10;
            panelTela.Location = new Point(250, panelTela.Location.Y);

            // Verifica se o painel voltou à posição inicial à direita da tela
            if (panelLogo.Left + panelLogo.Width <= 250)
            {
                // Para o Timer
                tmLogoRetrair2.Enabled = false;

                // Define a largura final do painel igual à largura inicial
                panelLogo.Width = 250;

                // Define a posição final do painel à esquerda da tela
                panelLogo.Left = 0;

                // Dsabilita o botão, para impedir que o usuario clique mais de uma vez nele seguida.
                lblSenha.Enabled = true;
            }
        }

        private void tmTelaE_Tick(object sender, EventArgs e)
        {
            //panelTela.Location = new Point(panelTela.Location.Y, 0);
        }

        private void tmTelaD_Tick(object sender, EventArgs e)
        {
            //panelTela.Location = new Point(250, panelTela.Location.Y);
        }

        private async void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Inicia o Timer para expansão do painel
            tmLogoExpandir.Enabled = true;
            tmTelaE.Start();
            identificador = 0;
            lblSenha.Visible = false;
            //lblSenha.Text = "";
            await Task.Delay(500);
            OpenChildForm(new Popup.FormRecuperar());
            iconVoltar.Visible = true;
            txtSenha.UseSystemPasswordChar = false;
            txtSenha.Text = "SENHA";
            txtUsuario.Text = "CPF";
            lblCPF.Visible = false;
            lblSenha1.Visible = false;
            lblAviso.Visible = false;
            iconAviso.Visible = false;
        }
        private async void iconVoltar_Click(object sender, EventArgs e)
        {
            //////panelVazio.Visible = true;
            // Inicia o Timer para expansão do painel
            tmLogoExpandir2.Enabled = true;
            tmTelaD.Start();
            identificador = 1;
            iconVoltar.Visible = false; 
            if (activeForm != null)
            {
                await Task.Delay(500);
                activeForm.Close();
            }
            lblSenha.Visible = true;
            await Task.Delay(480);
            /////panelVazio.Visible = false;
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tmESenha_Tick(object sender, EventArgs e)
        {
            // Incrementa o contador de caracteres exibidos
            currentLength++;

            // Define o texto do label como um substring da string completa com base no contador
            lblSenha.Text = fullText.Substring(0, currentLength);
            
            // Para o timer quando a string completa tiver sido exibida completamente
            if (currentLength == fullText.Length)
            {
                tmESenha.Stop();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static Login CurrentInstance;

        public async void TimerNovaS(string cpf)
        {
            tmNovaSE.Start();
            iconVoltar.Enabled = false;
            await Task.Delay(570);
            if (activeForm != null)
            {
                activeForm.Close();
                iconVoltar.Enabled = true;
            }
                
            OpenChildForm(new Popup.FormNovaSenha(cpf));
        }

        public async Task TimerLogo()
        {
            tmLogoExpandir2.Start();
            iconVoltar.Visible = false;

            await Task.Delay(3000);

            if (activeForm != null)
            {
                activeForm.Close();
            }
        }


        private void tmNovaSE_Tick(object sender, EventArgs e)
        {
            // Aumenta a largura do painel em 14 pixels a cada intervalo de tempo
            panelLogo.Width += 14;

            // Move o painel para a esquerda em 14 pixels a cada intervalo de tempo
            panelLogo.Left -= 14;

            // Verifica se o painel chegou ao lado esquerdo da tela
            if (panelLogo.Left <= 0)
            {
                // Para o Timer1
                tmNovaSE.Enabled = false;

                // Define a posição final do painel à esquerda da tela
                panelLogo.Left = 0;

                // Inicia o Timer2 para retraír o painel
                tmNovaSD.Enabled = true;
            }
        }

        private void tmNovaSD_Tick(object sender, EventArgs e)
        {
            // Diminui a largura do painel em 14 pixels a cada intervalo de tempo
            panelLogo.Width -= 14;

            // Move o painel para a direita em 14 pixels a cada intervalo de tempo
            panelLogo.Left += 14;

            // Verifica se o painel chegou ao tamanho original
            if (panelLogo.Width <= 250) // ajuste 100 para o tamanho original do painel
            {
                // Para o Timer2
                tmNovaSD.Enabled = false;

                // Define a largura final e posição final do painel
                panelLogo.Width = 250; // ajuste 100 para o tamanho original do painel
                panelLogo.Left = this.Width - panelLogo.Width; // ajuste para a posição original do painel
            }
        }
    }
}
