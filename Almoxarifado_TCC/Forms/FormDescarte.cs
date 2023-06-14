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
    public partial class Descarte : Form
    {

        private Form activeForm = null;

        public Descarte()
        {
            InitializeComponent();
            CurrentInstance = this;
        }

        public static Descarte CurrentInstance;

        public int cod_desc;


        public void reset()
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtDescarte = new DataTable();

            dados.Fill(dtDescarte);//manipulação dos dados
            dtvDescarte.DataSource = dtDescarte;//chamo o caminho dos dados
            conexao.Close();
        }

        private void Descarte_Load(object sender, EventArgs e)
        {
            reset();

            dtvDescarte.BorderStyle = BorderStyle.None;
            dtvDescarte.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvDescarte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvDescarte.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvDescarte.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvDescarte.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvDescarte.EnableHeadersVisualStyles = false;
            dtvDescarte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvDescarte.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvDescarte.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnDescarte_Click(object sender, EventArgs e)
        {
            string Verificacao;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT stats from tb_descarte where id_descarte=" + cod_desc;
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();

            Verificacao = Convert.ToString(registro["stats"]);

            conexao.Close();


            if (Verificacao == "Confirmado")
            {
                lblSelecionado.Text = "Este item já foi descartado!";
                lblSelecionado.ForeColor = Color.Red;
            }
            else
            {
                string tela = "Conf_descarte";
                int cod = cod_desc;
                TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
            }
        }

        private void dtvDescarte_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvDescarte.RowCount - 1;
            string item;
            lblSelecionado.ForeColor = Color.DimGray;
            TelaPrincipal.CurrentInstance.Popups_Fechar();

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                cod_desc = Convert.ToInt32(dtvDescarte.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT i.nome_item from tb_descarte d inner join tb_item i on d.id_item=i.id_item where id_descarte=" + cod_desc;
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                item = Convert.ToString(registro["nome_item"]);
                conexao.Close();

                lblSelecionado.Text = item;
                btnDescarte.Enabled = true;
            }
            else
            {
                lblSelecionado.Text = "Campo vazio";
                btnDescarte.Enabled = false;
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //instancia de conexão
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            if (cbxFiltro.Text == "") //Campo vazio lista tudo
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item";
            }
            else if (cbxFiltro.Text == "Código")//Se tiver informação lista
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.id_descarte LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "Item")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE i.nome_item LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "Quantidade")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.quant LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "H.Descarte")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.hora_desc LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "D.Descarte")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.data_desc LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "Observação")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.obs LIKE'%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "Status")
            {
                consulta = "SELECT d.id_descarte as Codigo, i.nome_item as Item, d.quant as Quantidade, d.hora_desc as Hora_Descarte, d.data_desc as Data_Descarte, d.obs as Observacao, d.stats as Status from tb_descarte d inner join tb_item i on d.id_item=i.id_item WHERE d.stats LIKE'%" + txtPesquisar.Text + "%'";
            }
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtDescarte = new DataTable();
            dados.Fill(dtDescarte);//manipulação dos dados
            dtvDescarte.DataSource = dtDescarte;//chamo o caminho dos dados
        }
    }
}
