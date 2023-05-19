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
        public Pedidos()
        {
            InitializeComponent();
        }

        public int codigo_chave = 0;
        public string nome;

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            string tela = "Key_Devolução";
            int cod = this.codigo_chave;
            TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.num_chave as Chave, e.horario_saida as H_Emprestimo, e.horario_entrada as H_Devolucao from tb_usuario u inner join tb_emprestimo e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave;";
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

        public int id_emp;

        private void dtvChave_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvChave.RowCount - 1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                id_emp = Convert.ToInt32(dtvChave.Rows[e.RowIndex].Cells[0].Value);

                MessageBox.Show("id: " + id_emp);

            }
        }
    }
}
