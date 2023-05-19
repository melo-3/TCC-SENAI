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
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC
{
    public partial class TelaPrincipal : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm = null;
        public int codigoid;
        //Constructor
        public TelaPrincipal(int codigoid)
        {
            this.codigoid = codigoid;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Cores
            panelMenu.BackColor = RGBColors.color2; // Define a cor do MENU para azul escuro
            panelTitleBar.BackColor = RGBColors.color3; // Define a cor da TITLEBAR para azul escuro
            panelTitleRepart.BackColor = RGBColors.color4; // Define a cor da barra que divite o TITULO e o PAINEL PRINCIPAL para azul escuro
            //panelDesktop.BackColor = RGBColors.color5; // Define a cor do PAINEL PRINCIPAL para azul escuro
            panelLine2.BackColor = Color.Gainsboro;

            //Esconde os submenus
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelSubMenuChave.Visible = false;
            panelSubMenuEstoque.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelSubMenuChave.Visible == true)
            {
                panelSubMenuChave.Visible = false;
            }
            if (panelSubMenuEstoque.Visible == true)
            {
                panelSubMenuEstoque.Visible = false;
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);// Branco
            public static Color color2 = Color.FromArgb(0, 75, 112); // MENU 
            public static Color color3 = Color.FromArgb(0, 75, 112); // TITULO
            public static Color color4 = Color.FromArgb(1, 99, 148); // BARRA DIVISORIA e BOTÂO_PRESS
            public static Color color5 = Color.FromArgb(15, 15, 15); // TELA PRINCIPAL
        }

        //Methods
        private void ActivateButon(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = RGBColors.color4; // COR
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void ActivateSubButon(object senderbtn, Color color)
        {
            if (senderbtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderbtn;
                currentBtn.BackColor = RGBColors.color4; // COR
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        //Structs
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = RGBColors.color2; // COR
                currentBtn.ForeColor = RGBColors.color1; // COR
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = RGBColors.color1; // COR
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildForm.Text = childForm.Name;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Gainsboro;
            lblCurrentChildForm.Text = "Menu";
        }


        //Drag From
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Botões
        private void btnChave_Click(object sender, EventArgs e) // Botão CHAVE
        {
            ShowSubMenu(panelSubMenuChave);
            ActivateButon(sender, RGBColors.color1); // Define a cor em que o botão vai ficar ao ser selecionado [Azul claro]
            OpenChildForm(new Forms.Chave()); // Abre o Form da Chave
        }

        private void btnChaveHist_Click(object sender, EventArgs e)
        {
            ActivateSubButon(sender, RGBColors.color1);
            OpenChildForm(new Forms.Pedidos());
        }

        private void btnEstoque_Click(object sender, EventArgs e) // Botão ESTOQUE
        {
            ShowSubMenu(panelSubMenuEstoque);
            ActivateButon(sender, RGBColors.color1); // Define a cor em que o botão vai ficar ao ser selecionado [Azul claro]
            OpenChildForm(new Forms.Estoque()); // Abre o Form do Estoque
        }

        private void btnDescarte_Click(object sender, EventArgs e)
        {
            ActivateSubButon(sender, RGBColors.color1);
            OpenChildForm(new Forms.Descarte());
        }

        private void btnEstoqueHist_Click(object sender, EventArgs e)
        {
            ActivateSubButon(sender, RGBColors.color1);
            OpenChildForm(new Forms.Historico());
        }

        private void btnHome_Click(object sender, EventArgs e) // Botão HOME [imagem logo]
        {
            if (activeForm != null)
            {
                hideSubMenu();
                activeForm.Close();
                Reset();
            }
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) // Barra de titulo
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Perfil(this.codigoid));
            iconCurrentChildForm.IconChar = IconChar.UserAlt;
        }

        private void iconStatus_Click(object sender, EventArgs e) // Muda o estado do Status [Arrumar futuramente, modo automatico]
        {
            if (iconStatus.IconColor == Color.ForestGreen)
            {
                iconStatus.IconColor = Color.DarkOrange;
            }
            else if (iconStatus.IconColor == Color.DarkOrange)
            {
                iconStatus.IconColor = Color.DarkRed;
            }
            else if (iconStatus.IconColor == Color.DarkRed)
            {
                iconStatus.IconColor = Color.ForestGreen;
            }

        }
        public string nome;

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //MessageBox.Show("id admin: " + this.codigoid);
            ClassUsuario usu = new ClassUsuario();//chamo classe usuario
            ClassConexao con = new ClassConexao();//chamo a classe conexao
            String logar = "SELECT nome_admin FROM tb_admin where id_admin=@id";
            MySqlConnection conexao = con.getConexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();
            comando.Parameters.AddWithValue("@id", this.codigoid);

            MySqlDataReader registro = comando.ExecuteReader();//executa a consulta
            registro.Read();
            nome = Convert.ToString(registro["nome_admin"]);
            

            lblNome.Text = nome;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("hh:mm:ss");
            lblData.Text = DateTime.Now.ToString("dddd, dd MMM yyyy");
        }
    }
}
