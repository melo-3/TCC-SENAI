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
    public partial class Pedidos : Form
    {

        private Form activeForm = null;

        public Pedidos()
        {
            InitializeComponent();
            CurrentInstance = this;
        }

        public static Pedidos CurrentInstance;
        public string nome;

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string tela = "Key_Devolução";
            int cod = this.id_emp;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        public void reset()
        {
            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.num_chave as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave;";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtEmp = new DataTable();

            dados.Fill(dtEmp);//manipulação dos dados
            dtvEmp.DataSource = dtEmp;//chamo o caminho dos dados
            conexao.Close();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

            reset();

            dtvEmp.BorderStyle = BorderStyle.None;
            dtvEmp.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dtvEmp.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtvEmp.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dtvEmp.DefaultCellStyle.SelectionForeColor = Color.White;
            dtvEmp.BackgroundColor = Color.FromArgb(56, 60, 71);

            dtvEmp.EnableHeadersVisualStyles = false;
            dtvEmp.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dtvEmp.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dtvEmp.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        public int id_emp;

        private void dtvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvEmp.RowCount - 1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                id_emp = Convert.ToInt32(dtvEmp.Rows[e.RowIndex].Cells[0].Value);

                MessageBox.Show("id: " + id_emp);
            }
        }
    }
}
