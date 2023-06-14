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
        public int id_emp;

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            string Verificacao;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT horario_dev from tb_emp_chave where id_emp=" + id_emp + "";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            Verificacao = Convert.ToString(registro["horario_dev"]);
            conexao.Close();


            if (Verificacao != "")
            {
                lblSelecionado.Text = "Esta chave já foi devolvida!";
                lblSelecionado.ForeColor = Color.Red;
            }
            else
            {
                string tela = "Key_Devolução";
                int cod = this.id_emp;
                TelaPrincipal.CurrentInstance.Popups_Tela(tela, cod);
            }
        }

        public void reset()
        {
            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta;
            consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave;";
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

        

        private void dtvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dtvEmp.RowCount - 1;
            lblSelecionado.ForeColor = Color.DimGray;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                id_emp = Convert.ToInt32(dtvEmp.Rows[e.RowIndex].Cells[0].Value);

                string sala, usuario;

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT c.sala_lab, u.nome_usuario from tb_emp_chave ec inner join tb_usuario u on ec.id_usuario=u.id_usuario inner join tb_chave c on ec.id_chave=c.id_chave where id_emp=" + id_emp;
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                sala = Convert.ToString(registro["sala_lab"]);
                usuario = Convert.ToString(registro["nome_usuario"]);
                conexao.Close();

                btnVisualizar.Enabled = true;
                lblSelecionado.Text = "'"+sala+"', foi emprestada por "+usuario;
            }
            else
            {
                lblSelecionado.Text = "Campo vazio";
                btnVisualizar.Enabled = false;
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
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave;";
            }
            else if (cbxFiltro.Text == "Código")//Se tiver informação lista
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE e.id_emp LIKE '%"+ txtPesquisar.Text +"%'";
            }
            else if (cbxFiltro.Text == "Nome")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE u.nome_usuario LIKE '%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "Chave")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE c.sala_lab LIKE '%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "H.Emprestimo")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE e.horario_emp LIKE '%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "D.Emprestimo")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE e.data_emp LIKE '%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "H.Devolução")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE e.horario_dev LIKE '%" + txtPesquisar.Text + "%'";
            }
            else if (cbxFiltro.Text == "D.Devolução")
            {
                consulta = "select e.id_emp as Codigo, u.nome_usuario as Nome, c.sala_lab as Chave, e.horario_emp as H_Emprestimo, e.data_emp as Data_Emprestimo, e.horario_dev as H_Devolucao, e.data_dev as Data_Devolucao from tb_usuario u inner join tb_emp_chave e on u.id_usuario=e.id_usuario inner join tb_chave c on c.id_chave=e.id_chave WHERE e.data_dev LIKE '%" + txtPesquisar.Text + "%'";
            }
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtEmp = new DataTable();
            dados.Fill(dtEmp);//manipulação dos dados
            dtvEmp.DataSource = dtEmp;//chamo o caminho dos dados
        }
    }
}
