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

namespace Almoxarifado_TCC.Forms
{
    public partial class EmpItem : Form
    {
        public EmpItem()
        {
            InitializeComponent();
        }

        private void EmpItem_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT e.id_emp_item as Codigo, i.nome_item as Item, u.nome_usuario as Usuario, e.quant as Quantidade, e.hora_emp as Hora_emprestimo, e.data_emp as Data_empretimo, e.hora_dev as Hora_devolucao, e.data_dev as Data_devolucao, e.obs as Observacao From tb_emp_item e inner join tb_usuario u on e.id_usuario=u.id_usuario inner join tb_item i on e.id_item=i.id_item;";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtHist = new DataTable();

            dados.Fill(dtHist);//manipulação dos dados
            dtvEmpItem.DataSource = dtHist;//chamo o caminho dos dados
            conexao.Close();

            dtvEmpItem.BorderStyle = BorderStyle.None;
            dtvEmpItem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvEmpItem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvEmpItem.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvEmpItem.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvEmpItem.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvEmpItem.EnableHeadersVisualStyles = false;
            dtvEmpItem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvEmpItem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvEmpItem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
