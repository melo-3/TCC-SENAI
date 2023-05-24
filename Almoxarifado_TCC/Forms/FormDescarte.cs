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
        public Descarte()
        {
            InitializeComponent();
        }

        private void Descarte_Load(object sender, EventArgs e)
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
            consulta = "SELECT hora_dev from tb_emp_item where id_emp_item=" + cod_item + "";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            Verificacao = Convert.ToString(registro["hora_dev"]);
            conexao.Close();


            if (Verificacao != "")
            {
                lblSelecionado.Text = "Este item já foi devolvido!";
                lblSelecionado.ForeColor = Color.Red;
            }
            else
            {
                string tela = "Item_Devolução";
                int cod = cod_item;
                TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
            }
        }
    }
}
