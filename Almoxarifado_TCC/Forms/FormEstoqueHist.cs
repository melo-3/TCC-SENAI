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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT h.id_hist as Codigo, i.nome_item as Item, h.quant as Quantidade, h.hora_hist as Horario, h.data_hist as Data from tb_hist_item h inner join tb_item i on h.id_item=i.id_item;\r\n";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtHist = new DataTable();

            dados.Fill(dtHist);//manipulação dos dados
            dtvHistorico.DataSource = dtHist;//chamo o caminho dos dados
            conexao.Close();

            dtvHistorico.BorderStyle = BorderStyle.None;
            dtvHistorico.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvHistorico.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvHistorico.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvHistorico.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvHistorico.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvHistorico.EnableHeadersVisualStyles = false;
            dtvHistorico.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvHistorico.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvHistorico.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
