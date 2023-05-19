using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Almoxarifado_TCC.Popup;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Almoxarifado_TCC
{
    public partial class TelaPrincipal : Form
    {

        private Form ActiveForm = null; // usado para verificar se existe algum form secundario ativo 
        private Form ActivePopup = null; // usado para verificar se existe algum popup ativo

        public int codigoid;
        public string nome;
        public string fotousu;

        public TelaPrincipal(int codigoid)
        {
            this.codigoid = codigoid;
            
            InitializeComponent();

            BackMenu.Width = 83;
            Menu.Width = 56;
            BackPopUp.Width = 0;

            CurrentInstance = this; // Usado para transferir informações entre forms usando voids
        }           

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            Horario.Start();
            
            //MessageBox.Show("id admin: " + this.codigoid);
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            String logar = "SELECT nome_admin,foto FROM tb_admin where id_admin=@id";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@id", this.codigoid);

            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta
            registro.Read();
            nome = Convert.ToString(registro["nome_admin"]);

            lblNome.Text = nome;
        }



        #region Controladores de tempo

        private void Horario_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
        }

        private void Mostrar_Tick(object sender, EventArgs e)
        {
            // Aumenta a largura do painel em 17 pixels a cada intervalo de tempo
            BackMenu.Width += 17;
            Menu.Width += 17;

            // Verifica se o painel chegou ao lado direito da tela
            if (BackMenu.Width >= 227 && Menu.Width >= 193)
            {
                // Define a largura final do painel igual à largura da tela
                BackMenu.Width = 227;
                Menu.Width = 193;

                // Para o Timer de expansão
                Mostrar.Enabled = false;
            }
        }

        private void Esconder_Tick(object sender, EventArgs e)
        {
            // Reduz a largura do painel em 5 pixels a cada intervalo de tempo
            BackMenu.Width -= 17;
            Menu.Width -= 17;

            // Verifica se o painel voltou à posição inicial à direita da tela
            if (BackMenu.Left + BackMenu.Width <= 83 && Menu.Left + Menu.Width <= 56)
            {
                // Para o Timer
                Esconder.Enabled = false;

                // Define a posição final do painel à esquerda da tela
                //panel13.Left = 0;
                //panel1.Left = 28;

                // Define a largura final do painel igual à largura inicial
                BackMenu.Width = 83;
                Menu.Width = 56;
            }
        }

        #endregion

        #region Controlador de telas

        public static TelaPrincipal CurrentInstance; // Usado para transferir informações entre forms usando voids

        private void OpenForm(Form ChildForm)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void OpenPopup(Form ChildPopup)
        {
            if (ActivePopup != null)
                ActivePopup.Close();
            ActivePopup = ChildPopup;
            ChildPopup.TopLevel = false;
            ChildPopup.FormBorderStyle = FormBorderStyle.None;
            ChildPopup.Dock = DockStyle.Fill;
            PopUp.Controls.Add(ChildPopup);
            ChildPopup.BringToFront();
            ChildPopup.Show();
        }

        public void Popups_Fechar()
        {
            BackPopUp.Width = 0;
            if (ActivePopup != null)
                ActivePopup.Close();
        }
        public void Popups_Tela(string tela, int codigo)
        {
            /// -----Botões form chave-----
            if (tela == "Key_Emp")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.Emprestimo());
            }

            if (tela == "Key_Add")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.AddChave());
            }

            if (tela == "Key_Edt")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.EdtChave(codigo));
            }


            /// -----Botões form Pedidos-----
            if (tela == "Key_Devolução")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.DevolverChave());
            }


            /// -----Botões form Estoque-----

            if (tela == "Item_Ced")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.Ceder());
            }

            if (tela == "Item_Add")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.AddItem());
            }

            if (tela == "Item_Edt")
            {
                BackPopUp.Width = 227;
                OpenPopup(new Popup.EdtItem(codigo));
            }

            if (tela == "Item_Desc")
            {

            }

            /// -----Botões form Histórico-----

            if (tela == "???????")
            {
                BackPopUp.Width = 227;
                ///OpenPopup(new Popup.());
            }

            /// -----Botões form Descartes-----

            if (tela == "???????")
            {
                BackPopUp.Width = 227;
                ///OpenPopup(new Popup.());
            }

        }

        #endregion

        #region Buttons

        int identificador = 1;

        private void Icon_extend_Click(object sender, EventArgs e)
        {
            if (identificador == 1 && Esconder.Enabled == false)
            {
                Mostrar.Enabled = true;
                identificador = 0;
                Icon_extend.IconColor = CoresGlobais.Selecionado;
            }
            else if (identificador == 0 && Mostrar.Enabled == false)
            {
                Esconder.Enabled = true;
                identificador = 1;
                Icon_extend.IconColor = CoresGlobais.Normal;
            }
        }

        private void icon_Perfil_Click(object sender, EventArgs e)
        {
            if (icon_Perfil.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Perfil.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Perfil(codigoid));
            }
        }

        private void icon_Key_Click(object sender, EventArgs e)
        {
            if (icon_Key.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Key.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Chave()); // Abre o Form da Chave
            }
        }

        private void icon_Emp_Click(object sender, EventArgs e)
        {
            if (icon_Emp.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Emp.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Pedidos());
            }
        }

        private void icon_Descartes_Click(object sender, EventArgs e)
        {
            if (icon_Descartes.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Descartes.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Descarte());
            }
        }

        private void icon_Estoque_Click(object sender, EventArgs e)
        {
            if (icon_Estoque.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Estoque.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Estoque()); // Abre o Form do Estoque
            }
        }

        private void icon_Hist_Click(object sender, EventArgs e)
        {
            if (icon_Hist.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Hist.IconColor = CoresGlobais.Selecionado;
                OpenForm(new Popup.Historico());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            apagar_icons();
            Popups_Fechar();
        }

        private void icon_Config_Click(object sender, EventArgs e)
        {
            if (icon_Config.IconColor == CoresGlobais.Selecionado)
            {
                Popups_Fechar();
                if (ActiveForm != null)
                    ActiveForm.Close();
                apagar_icons();
            }
            else
            {
                Popups_Fechar();
                apagar_icons();
                icon_Config.IconColor = CoresGlobais.Selecionado;
                // OpenForm(new Popup.???());
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e) // Diminui o programa
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFullSC_Click(object sender, EventArgs e) // Deixa o programa em FullScreen
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) // Fecha o programa
        {
            Application.Exit();
        }

        #endregion

        #region Interações visuais

        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) // Barra de titulo
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public static class CoresGlobais
        {
            public static Color Sobre { get; } = Color.FromArgb(165, 184, 201);
            public static Color Normal { get; } = Color.FromArgb(118, 131, 143);
            public static Color Selecionado { get; } = Color.CornflowerBlue; // 58, 98, 135

        }

        private void apagar_icons()
        {
            //icon_Home.IconColor = CoresGlobais.Normal;
            icon_Key.IconColor = CoresGlobais.Normal;
            icon_Emp.IconColor = CoresGlobais.Normal;
            icon_Estoque.IconColor = CoresGlobais.Normal;
            icon_Hist.IconColor = CoresGlobais.Normal;
            icon_Descartes.IconColor = CoresGlobais.Normal;
            icon_Perfil.IconColor = CoresGlobais.Normal;
            icon_Config.IconColor = CoresGlobais.Normal;
        }

        private void Icon_extend_MouseEnter(object sender, EventArgs e)
        {
            if (Icon_extend.IconColor != CoresGlobais.Selecionado)
                Icon_extend.IconColor = CoresGlobais.Sobre;
        }

        private void Icon_extend_MouseLeave(object sender, EventArgs e)
        {
            if (Icon_extend.IconColor != CoresGlobais.Selecionado)
                Icon_extend.IconColor = CoresGlobais.Normal;
        }

        private void icon_Key_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Key.IconColor != CoresGlobais.Selecionado)
                icon_Key.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Key_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Key.IconColor != CoresGlobais.Selecionado)
                icon_Key.IconColor = CoresGlobais.Normal;
        }

        private void icon_Emp_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Emp.IconColor != CoresGlobais.Selecionado)
                icon_Emp.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Emp_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Emp.IconColor != CoresGlobais.Selecionado)
                icon_Emp.IconColor = CoresGlobais.Normal;
        }

        private void icon_Estoque_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Estoque.IconColor != CoresGlobais.Selecionado)
                icon_Estoque.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Estoque_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Estoque.IconColor != CoresGlobais.Selecionado)
                icon_Estoque.IconColor = CoresGlobais.Normal;
        }

        private void icon_Hist_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Hist.IconColor != CoresGlobais.Selecionado)
                icon_Hist.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Hist_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Hist.IconColor != CoresGlobais.Selecionado)
                icon_Hist.IconColor = CoresGlobais.Normal;
        }

        private void icon_Descartes_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Descartes.IconColor != CoresGlobais.Selecionado)
                icon_Descartes.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Descartes_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Descartes.IconColor != CoresGlobais.Selecionado)
                icon_Descartes.IconColor = CoresGlobais.Normal;
        }

        private void icon_Config_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Config.IconColor != CoresGlobais.Selecionado)
                icon_Config.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Config_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Config.IconColor != CoresGlobais.Selecionado)
                icon_Config.IconColor = CoresGlobais.Normal;
        }

        private void icon_Perfil_MouseEnter(object sender, EventArgs e)
        {
            if (icon_Perfil.IconColor != CoresGlobais.Selecionado)
                icon_Perfil.IconColor = CoresGlobais.Sobre;
        }

        private void icon_Perfil_MouseLeave(object sender, EventArgs e)
        {
            if (icon_Perfil.IconColor != CoresGlobais.Selecionado)
                icon_Perfil.IconColor = CoresGlobais.Normal;
        }


        #endregion


    }
}
