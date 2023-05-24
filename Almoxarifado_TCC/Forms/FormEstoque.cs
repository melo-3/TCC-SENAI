using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Popup;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
            CurrentInstance = this;
        }
        public static Popup.Estoque CurrentInstance;
        public int codigo_item = 0;

        public void reset()
        {

            ClassConexao con = new ClassConexao();         //instancia de conexão
            MySqlConnection conexao = con.getConexao();      //obtive a conexao
            string consulta = "SELECT * from tb_item"; 
            MySqlCommand commando = new MySqlCommand(consulta, conexao);    //Monta meu comando sql
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtEstoque = new DataTable();
            dados.Fill(dtEstoque);//manipulação dos dados
            dtvEstoque.DataSource = dtEstoque;//chamo o caminho dos dados

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //instancia de conexão
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            if (txtPesquisar.Text == "") //Campo vazio lista tudo
            {
                consulta = "SELECT * from tb_item";
            }
            else //Se tiver informação lista
            {
                consulta = "SELECT * from tb_item where nome_item ='" + txtPesquisar.Text + "'";
            }
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtEstoque = new DataTable();

            dados.Fill(dtEstoque);//manipulação dos dados
            dtvEstoque.DataSource = dtEstoque;//chamo o caminho dos dados
            conexao.Close();
        }

        private void dtvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT id_item as Codigo, nome_item as Item, descricao as Descricao, quant as Quantidade from tb_item";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtEstoque = new DataTable();

            dados.Fill(dtEstoque);//manipulação dos dados
            dtvEstoque.DataSource = dtEstoque;//chamo o caminho dos dados
            conexao.Close();

            dtvEstoque.BorderStyle = BorderStyle.None;
            dtvEstoque.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvEstoque.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvEstoque.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvEstoque.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvEstoque.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvEstoque.EnableHeadersVisualStyles = false;
            dtvEstoque.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnCeder_Click(object sender, EventArgs e)
        {
            string tela = "Item_Ced";
            int cod = this.codigo_item;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string tela = "Item_Add";
            int cod = this.codigo_item;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string tela = "Item_Edt";
            int cod = this.codigo_item;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            string tela = "Item_Desc";
            int cod = this.codigo_item;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            Popup.ExcItem go = new Popup.ExcItem(this.codigo_item);
            go.ShowDialog();
        }

        private void dtvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvEstoque.RowCount -1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                this.codigo_item = Convert.ToInt32(dtvEstoque.Rows[e.RowIndex].Cells[0].Value);
                //MessageBox.Show("Código Item: " + this.codigo_item);
                lblSelecionado.Text = "Número " + this.codigo_item;
                btnCeder.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnDescartar.Enabled = true;
            }
            else
            {
                lblSelecionado.Text = "Campo vazio";
                btnCeder.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnDescartar.Enabled = false;
            }
        }

        
    }
}
