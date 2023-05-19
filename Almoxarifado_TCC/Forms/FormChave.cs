using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class Chave : Form
    {
        public Chave()
        {
            InitializeComponent();

            CurrentInstance = this;
        }

        public static Popup.Chave CurrentInstance;

        public int codigo_chave = 0;
        

        public void reset()
        {
            //instancia de conexão
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT num_chave as Numero,sala_lab as SalaLab,stats as Status,obs as Observacao from tb_chave";
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtChave = new DataTable();
            dados.Fill(dtChave);//manipulação dos dados
            dtvChave.DataSource = dtChave;//chamo o caminho dos dados

        }
        private void button2_Click(object sender, EventArgs e) //pesquisa
        {
            //instancia de conexão
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            if (cbxFiltro.Text == "Todos" || cbxFiltro.Text == "") //Campo vazio lista tudo
            {
                consulta = "SELECT num_chave,sala_lab,stats,obs from tb_chave";
            }
            else if (cbxFiltro.Text == "Número")//Se tiver informação lista
            {
                consulta = "SELECT num_chave,sala_lab,stats,obs from tb_chave where num_chave ='" + txtPesquisar.Text + "'";
            }
            else if (cbxFiltro.Text == "Sala/lab")
            {
                consulta = "SELECT num_chave,sala_lab,stats,obs from tb_chave where sala_lab ='" + txtPesquisar.Text + "'";
            }
            else if (cbxFiltro.Text == "Disponível")
            {
                consulta = "SELECT num_chave,sala_lab,stats,obs from tb_chave where stats ='Disponível'";
            }
            else if (cbxFiltro.Text == "Indisponível")
            {
                consulta = "SELECT num_chave,sala_lab,stats,obs from tb_chave where stats ='Indisponível'";
            }
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtChave = new DataTable();
            dados.Fill(dtChave);//manipulação dos dados
            dtvChave.DataSource = dtChave;//chamo o caminho dos dados
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //vai pra outro form
        }

        private void Chave_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT num_chave as Chave,sala_lab as Sala,stats as Status,obs as Observacao from tb_chave";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtChave = new DataTable();

            dados.Fill(dtChave);//manipulação dos dados
            dtvChave.DataSource = dtChave;//chamo o caminho dos dados
            conexao.Close();

            dtvChave.BorderStyle = BorderStyle.None;
            dtvChave.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvChave.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvChave.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvChave.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvChave.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvChave.EnableHeadersVisualStyles = false;
            dtvChave.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvChave.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvChave.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            string tela = "Key_Emp";
            int cod = this.codigo_chave;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string tela = "Key_Add";
            int cod = this.codigo_chave;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int cod = this.codigo_chave;
            string tela = "Key_Edt";
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            Popup.ExcChave go = new Popup.ExcChave(this.codigo_chave);
            go.ShowDialog();
        }

        private void dtvChave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvChave.RowCount - 1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                this.codigo_chave = Convert.ToInt32(dtvChave.Rows[e.RowIndex].Cells[0].Value);
                //MessageBox.Show("Código chave: " + this.codigo_chave);
                lblSelecionado.Text = "Número " + this.codigo_chave;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnEmprestimo.Enabled = true;
            }
            else
            {
                lblSelecionado.Text = "Campo vazio";
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnEmprestimo.Enabled = false;
            }
        }
    }
}
