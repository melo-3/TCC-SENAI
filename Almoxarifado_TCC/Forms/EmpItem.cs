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

namespace Almoxarifado_TCC.Forms
{
    public partial class EmpItem : Form
    {
        private Form activeForm = null;

        public EmpItem()
        {
            InitializeComponent();
            CurrentInstance = this;
        }

        public static EmpItem CurrentInstance;

        public void reset()
        {
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "SELECT e.id_emp_item as Codigo, u.nome_usuario as Usuario, i.nome_item as Item, e.quant as Quantidade, e.hora_emp as Hora_emprestimo, e.data_emp as Data_empretimo, e.hora_dev as Hora_devolucao, e.data_dev as Data_devolucao, e.obs as Observacao From tb_emp_item e inner join tb_usuario u on e.id_usuario=u.id_usuario inner join tb_item i on e.id_item=i.id_item;";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtHist = new DataTable();

            dados.Fill(dtHist);//manipulação dos dados
            dtvEmpItem.DataSource = dtHist;//chamo o caminho dos dados
            conexao.Close();
        }
        private void EmpItem_Load(object sender, EventArgs e)
        {
            reset();

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

        public int cod_item;

        private void dtvEmpItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvEmpItem.RowCount - 1;
            string usuario, item;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                cod_item = Convert.ToInt32(dtvEmpItem.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT u.nome_usuario, i.nome_item from tb_emp_item e inner join tb_item i on e.id_item=i.id_item inner join tb_usuario u on e.id_usuario=u.id_usuario where id_emp_item='" + cod_item + "'";
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                usuario = Convert.ToString(registro["nome_usuario"]);
                item = Convert.ToString(registro["nome_item"]);
                conexao.Close();

                lblSelecionado.Text = "'"+item+"' foi emprestado por "+usuario;
                lblSelecionado.ForeColor = Color.DimGray;
                btnDevolver.Enabled = true;
            }
            else
            {
                lblSelecionado.Text = "Campo vazio";
                lblSelecionado.ForeColor = Color.DimGray;
                btnDevolver.Enabled = false; 
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string Verificacao;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT hora_dev from tb_emp_item where id_emp_item="+ cod_item + "";
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
