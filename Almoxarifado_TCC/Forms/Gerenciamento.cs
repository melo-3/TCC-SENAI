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
using Org.BouncyCastle.Crypto.Tls;

namespace Almoxarifado_TCC.Forms
{
    public partial class Gerenciamento : Form
    {

        private Form activeForm = null;
        public string nome_usu, nome_admin;
        public int id_usu, id_adm;

        public Gerenciamento()
        {
            InitializeComponent();
            CurrentInstance = this;
        }

        public static Gerenciamento CurrentInstance;

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

            lblNomeU.Text = "-----";

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

            lblNomeA.Text = "-----";
        }

        private Form ActivePopup = null; // usado para verificar se existe algum popup ativo

        public void Fechar()
        {
            if (ActivePopup != null)
                ActivePopup.Close();
            BackPopUp.Visible = false;
            apagar_icons();
            pnlPesquisar.Visible = false;
            pnlPesquisarA.Visible = false;
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

        public void Panel_PopUp()
        {
            BackPopUp.Size = new System.Drawing.Size(219, 346);
            BackPopUp.Location = new System.Drawing.Point(641, 172);
        }

        public void Panel_Pesquisar()
        {
            pnlPesquisar.Size = new System.Drawing.Size(165, 124);
            pnlPesquisar.Location = new System.Drawing.Point(641, 216);
        }


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
            btnAdicionar.IconColor = CoresGlobais.Normal;
            btnEditar.IconColor = CoresGlobais.Normal;
            btnExcluir.IconColor = CoresGlobais.Normal;
            btnPesquisarA.IconColor = CoresGlobais.Normal;
            btnVisualizarA.IconColor = CoresGlobais.Normal;
            btnCriarAdm.IconColor = CoresGlobais.Normal;
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

        private void btnAdicionar_MouseEnter(object sender, EventArgs e)
        {
            if (btnAdicionar.IconColor != CoresGlobais.Selecionado)
                btnAdicionar.IconColor = CoresGlobais.Sobre;
            lblCriarUsu.Visible = true;

        }

        private void btnAdicionar_MouseLeave(object sender, EventArgs e)
        {
            if (btnAdicionar.IconColor != CoresGlobais.Selecionado)
                btnAdicionar.IconColor = CoresGlobais.Normal;
            lblCriarUsu.Visible = false;
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

        private void btnPesquisarA_MouseEnter(object sender, EventArgs e)
        {
            if (btnPesquisarA.IconColor != CoresGlobais.Selecionado)
                btnPesquisarA.IconColor = CoresGlobais.Sobre;
            lblPesquisarA.Visible = true;
        }

        private void btnPesquisarA_MouseLeave(object sender, EventArgs e)
        {
            if (btnPesquisarA.IconColor != CoresGlobais.Selecionado)
                btnPesquisarA.IconColor = CoresGlobais.Normal;
            lblPesquisarA.Visible = false;
        }

        private void btnVisualizarA_MouseEnter(object sender, EventArgs e)
        {
            if (btnVisualizarA.IconColor != CoresGlobais.Selecionado)
                btnVisualizarA.IconColor = CoresGlobais.Sobre;
            lblVisualizarA.Visible = true;
        }

        private void btnVisualizarA_MouseLeave(object sender, EventArgs e)
        {
            if (btnVisualizarA.IconColor != CoresGlobais.Selecionado)
                btnVisualizarA.IconColor = CoresGlobais.Normal;
            lblVisualizarA.Visible = false;
        }

        private void btnCriarAdm_MouseEnter(object sender, EventArgs e)
        {
            if (btnCriarAdm.IconColor != CoresGlobais.Selecionado)
                btnCriarAdm.IconColor = CoresGlobais.Sobre;
            lblCriarAdm.Visible = true;
        }

        private void btnCriarAdm_MouseLeave(object sender, EventArgs e)
        {
            if (btnCriarAdm.IconColor != CoresGlobais.Selecionado)
                btnCriarAdm.IconColor = CoresGlobais.Normal;
            lblCriarAdm.Visible = false;
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

        private void txtPesquisarA_Enter(object sender, EventArgs e)
        {
            if (txtPesquisarA.Text == "Pesquisar")
                txtPesquisarA.Text = "";
        }

        private void txtPesquisarA_Leave(object sender, EventArgs e)
        {
            if (txtPesquisarA.Text == "")
                txtPesquisarA.Text = "Pesquisar";
        }

        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (btnPesquisar.IconColor == CoresGlobais.Selecionado)
            {
                Fechar();
                apagar_icons();
                txtPesquisar.Text = "Pesquisar";
            }
            else
            {
                Panel_Pesquisar();
                Fechar();
                apagar_icons();
                pnlPesquisar.Visible = true;
                btnPesquisar.IconColor = CoresGlobais.Selecionado;
            }
        }  

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (btnAdicionar.IconColor == CoresGlobais.Selecionado)
            {
                apagar_icons();
                Fechar();
            }
            else
            {
                apagar_icons();
                Fechar();
                btnAdicionar.IconColor = CoresGlobais.Selecionado;
                Popup.CriarUsuario go = new Popup.CriarUsuario();
                go.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string txt = "Selecione um usuário para editar";
            if (lblNomeU.Text == "Campo vazio" || lblNomeU.Text == "-----" || lblNomeU.Text == txt)
            {
                apagar_icons();
                Fechar();
                lblNomeU.Text = txt;
            }
            else
            {

                if (btnEditar.IconColor == CoresGlobais.Selecionado)
                {
                apagar_icons();
                Fechar();
                }
                else
                {
                Panel_PopUp();
                apagar_icons();
                BackPopUp.Visible = true;
                btnEditar.IconColor = CoresGlobais.Selecionado;
                OpenPopup(new Popup.EditarUsuario(id_usu));
                }   

            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string txt = "Selecione um usuário para excluir";
            if (lblNomeU.Text == "Campo vazio" || lblNomeU.Text == "-----" || lblNomeU.Text == txt)
            {
                apagar_icons();
                Fechar();
                lblNomeU.Text = txt;
            }
            else
            {
                if (btnExcluir.IconColor == CoresGlobais.Selecionado)
                {
                    apagar_icons();
                    Fechar();
                }
                else
                {
                    Panel_PopUp();
                    apagar_icons();
                    BackPopUp.Visible = true;
                    btnExcluir.IconColor = CoresGlobais.Selecionado;
                    OpenPopup(new Popup.DeletarUsu(id_usu));
                }
            }
            
        }

        private void dtvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvUsuario.RowCount - 1;
            string tipo;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                nome_usu = Convert.ToString(dtvUsuario.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT u.id_usuario, tu.tipo_usu from tb_usuario u inner join tb_tipo_usuario tu on u.id_tipo_usu=tu.id_tipo_usu where nome_usuario='" + nome_usu + "'";
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                tipo = Convert.ToString(registro["tipo_usu"]);
                id_usu = Convert.ToInt32(registro["id_usuario"]);
                conexao.Close();

                lblNomeU.Text = nome_usu + ", " + tipo;
            }
            else
            {
                lblNomeU.Text = "Campo vazio";
            }
        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPesquisar.Text != "Pesquisar")
            {

                //instancia de conexão
                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                if (cbxFiltro.Text == "Todos" || cbxFiltro.Text == "") //Campo vazio lista tudo
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu";
                }
                else if (cbxFiltro.Text == "Nome")//Se tiver informação lista
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu where u.nome_usuario like '%"+ txtPesquisar.Text +"%'";
                }
                else if (cbxFiltro.Text == "Tipo")
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu where t.tipo_usu like '%" + txtPesquisar.Text + "%'";
                }
                else if (cbxFiltro.Text == "CPF")
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu where u.cpf like '%" + txtPesquisar.Text + "%'";
                }
                else if (cbxFiltro.Text == "Email")
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu where u.email like '%" + txtPesquisar.Text + "%'";
                }
                else if (cbxFiltro.Text == "Telefone")
                {
                    consulta = "SELECT u.nome_usuario, t.tipo_usu, u.cpf, u.email from tb_usuario u inner join tb_tipo_usuario t on u.id_tipo_usu=t.id_tipo_usu where u.Telefone like '%" + txtPesquisar.Text + "%'";
                }
                //Monta meu comando sql
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();//Abro minha conexao
                               //monto a tabela de dados
                MySqlDataAdapter dados = new MySqlDataAdapter(commando);
                //Crio uma nova tabela de dados
                DataTable dtUsuario = new DataTable();
                dados.Fill(dtUsuario);//manipulação dos dados
                dtvUsuario.DataSource = dtUsuario;//chamo o caminho dos dados

            }
        }

        private void btnPesquisarA_Click(object sender, EventArgs e)
        {
            if (btnPesquisarA.IconColor == CoresGlobais.Selecionado)
            {
                Fechar();
                apagar_icons();
                txtPesquisarA.Text = "Pesquisar";
            }
            else
            {
                Fechar();
                apagar_icons();
                pnlPesquisarA.Location = new System.Drawing.Point(643, 677);
                pnlPesquisarA.Visible = true;
                btnPesquisarA.IconColor = CoresGlobais.Selecionado;
            }
        }

        private void txtPesquisarA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtPesquisarA.Text != "Pesquisar")
            {
                //instancia de conexão
                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                if (cbxFiltroA.Text == "Todos" || txtPesquisarA.Text == "") //Campo vazio lista tudo
                {
                    consulta = "SELECT nome_admin, email, telefone from tb_admin"; 
                }
                else if (cbxFiltroA.Text == "Nome")//Se tiver informação lista
                {
                    consulta = "SELECT nome_admin, email, telefone from tb_admin where nome_admin like '%" + txtPesquisarA.Text + "%'";
                }
                else if (cbxFiltroA.Text == "Email")
                {
                    consulta = "SELECT nome_admin, email, telefone from tb_admin where email like '%" + txtPesquisarA.Text + "%'";
                }
                else if (cbxFiltroA.Text == "Telefone")
                {
                    consulta = "SELECT nome_admin, email, telefone from tb_admin where telefone like '%" + txtPesquisarA.Text + "%'";
                }
                //Monta meu comando sql
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();//Abro minha conexao
                               //monto a tabela de dados
                MySqlDataAdapter dados = new MySqlDataAdapter(commando);
                //Crio uma nova tabela de dados
                DataTable dtAdmin = new DataTable();
                dados.Fill(dtAdmin);//manipulação dos dados
                dtvAdmin.DataSource = dtAdmin;//chamo o caminho dos dados
            }
        }

        private void btnCriarAdm_Click(object sender, EventArgs e)
        {
            if (btnCriarAdm.IconColor == CoresGlobais.Selecionado)
            {
                apagar_icons();
                Fechar();
            }
            else
            {
                apagar_icons();
                Fechar();
                btnCriarAdm.IconColor = CoresGlobais.Selecionado;
                Popup.CriarAdmin go = new Popup.CriarAdmin();
                go.ShowDialog();
            }
        }

        private void dtvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvUsuario.RowCount - 1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                nome_admin = Convert.ToString(dtvAdmin.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT id_admin from tb_admin where nome_admin ='" + nome_admin + "'";
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                id_adm = Convert.ToInt32(registro["id_admin"]);
                conexao.Close();

                lblNomeA.Text = nome_admin;
            }
            else
            {
                lblNomeA.Text = "Campo vazio";
            }
        }

        private void btnVisualizarA_Click(object sender, EventArgs e)
        {
            string txt = "Selecione um administrador para visualizar";
            if (lblNomeA.Text == "Campo vazio" || lblNomeA.Text == "-----" || lblNomeA.Text == txt)
            {
                apagar_icons();
                Fechar();
                lblNomeA.Text = txt;
            }
            else
            {
                if (btnVisualizarA.IconColor == CoresGlobais.Selecionado)
                {
                    apagar_icons();
                    Fechar();
                }
                else
                {
                    BackPopUp.Location = new System.Drawing.Point(641, 684);
                    apagar_icons();
                    BackPopUp.Visible = true;
                    btnVisualizarA.IconColor = CoresGlobais.Selecionado;
                    OpenPopup(new Popup.VisualizarADM(id_adm));
                }
            }
        }

      
    }
}
