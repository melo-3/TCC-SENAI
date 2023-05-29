using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Almoxarifado_TCC.Popup;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Forms
{
    public partial class Gerenciamento : Form
    {
        public Gerenciamento()
        {
            InitializeComponent();
        }

        public void reset()
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtUsuario = new DataTable();

            dados.Fill(dtUsuario);//manipulação dos dados
            dtvUsuario.DataSource = dtUsuario;//chamo o caminho dos dados
            conexao.Close();

            ClassConexao con1 = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao1 = con1.getConexao();
            String consulta1;
            consulta1 = "SELECT nome_admin, email, telefone from tb_admin";
            MySqlCommand commando1 = new MySqlCommand(consulta1, conexao1);
            conexao1.Open();//Abro minha conexao
            MySqlDataAdapter dados1 = new MySqlDataAdapter(commando1);
            //Crio uma nova tabela de dados
            DataTable dtAdmin = new DataTable();

            dados1.Fill(dtAdmin);//manipulação dos dados
            dtvAdmin.DataSource = dtAdmin;//chamo o caminho dos dados
            conexao1.Close();
        }

        private Form ActivePopup = null; // usado para verificar se existe algum popup ativo


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

        private void Gerenciamento_Load(object sender, EventArgs e)
        {
            reset();

            dtvUsuario.BorderStyle = BorderStyle.None;
            dtvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvUsuario.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvUsuario.EnableHeadersVisualStyles = false;
            dtvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dtvAdmin.BorderStyle = BorderStyle.None;
            dtvAdmin.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvAdmin.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvAdmin.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvAdmin.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvAdmin.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvAdmin.EnableHeadersVisualStyles = false;
            dtvAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvAdmin.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvAdmin.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }



        #region Interações visuais

        public static class CoresGlobais
        {

            public static Color Sobre { get; } = Color.FromArgb(118, 131, 143);
            public static Color Normal { get; } = SystemColors.ButtonFace;
            public static Color Selecionado { get; } = Color.CornflowerBlue;
            public static Color Danger { get; } = Color.FromArgb(168, 2, 2);

        }

        public void apagar_icons()
        {
            btnPesquisar.IconColor = CoresGlobais.Normal;
            btnVisualizar.IconColor = CoresGlobais.Normal;
            btnEditar.IconColor = CoresGlobais.Normal;
            btnExcluir.IconColor = CoresGlobais.Normal;
        }

        private void btnPesquisar_MouseEnter(object sender, EventArgs e)
        {
            if (btnPesquisar.IconColor != CoresGlobais.Selecionado)
                btnPesquisar.IconColor = CoresGlobais.Sobre;
            lblPesquisar.Visible = true;
        }

        private void btnPesquisar_MouseLeave(object sender, EventArgs e)
        {
            if (btnPesquisar.IconColor != CoresGlobais.Selecionado)
                btnPesquisar.IconColor = CoresGlobais.Normal;
            lblPesquisar.Visible = false;
        }

        private void btnVisualizar_MouseEnter(object sender, EventArgs e)
        {
            if (btnVisualizar.IconColor != CoresGlobais.Selecionado)
                btnVisualizar.IconColor = CoresGlobais.Sobre;
            lblVisualizar.Visible = true;

        }

        private void btnVisualizar_MouseLeave(object sender, EventArgs e)
        {
            if (btnVisualizar.IconColor != CoresGlobais.Selecionado)
                btnVisualizar.IconColor = CoresGlobais.Normal;
            lblVisualizar.Visible = false;
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            if (btnEditar.IconColor != CoresGlobais.Selecionado)
                btnEditar.IconColor = CoresGlobais.Sobre;
            lblEditar.Visible = true;
        }

        private void btnEditar_MouseLeave(object sender, EventArgs e)
        {
            if (btnEditar.IconColor != CoresGlobais.Selecionado)
                btnEditar.IconColor = CoresGlobais.Normal;
            lblEditar.Visible = false;
        }

        private void btnExcluir_MouseEnter(object sender, EventArgs e)
        {
            if (btnExcluir.IconColor != CoresGlobais.Selecionado)
                btnExcluir.IconColor = CoresGlobais.Danger;
            lblExcluir.Visible = true;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            if (btnExcluir.IconColor != CoresGlobais.Selecionado)
                btnExcluir.IconColor = CoresGlobais.Normal;
            lblExcluir.Visible = false;
        }


        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.IconColor == CoresGlobais.Selecionado)
            {
                apagar_icons();
                pnlPesquisar.Visible= false;
                txtPesquisar.Text = "Pesquisar";
            }
            else
            {
                apagar_icons();
                pnlPesquisar.Visible = true;
                btnPesquisar.IconColor = CoresGlobais.Selecionado;
            }
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "Pesquisar")
                txtPesquisar.Text = "";
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
                txtPesquisar.Text = "Pesquisar";
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
