using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class Emprestimo : Form
    {
        public int cod_chave;
        public Emprestimo()
        {
            InitializeComponent();
            timer1.Start();
            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT cpf as CPF,nome_usuario as Nome from tb_usuario";
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtUsu = new DataTable();
            dados.Fill(dtUsu);//manipulação dos dados
            dgvUsuario.DataSource = dtUsu;//chamo o caminho dos dados
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Emprestimo_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtEmprestimo.Text = DateTime.Now.ToString("HH:mm");
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF";
            }
        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {
            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(1, 99, 148);
            dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvUsuario.BackgroundColor = Color.White;

            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 75, 112);
            dgvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void iconCeder_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && txtCpf.Text != "CPF" && txtCpf.Text != "")
            {
                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta = "";

                consulta = "SELECT cpf as CPF,nome_usuario as Nome from tb_usuario where cpf ='" + txtCpf.Text + "'";

                //Monta meu comando sql
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();//Abro minha conexao
                //monto a tabela de dados
                MySqlDataAdapter dados = new MySqlDataAdapter(commando);
                //Crio uma nova tabela de dados
                DataTable dtUsu = new DataTable();
                dados.Fill(dtUsu);//manipulação dos dados
                dgvUsuario.DataSource = dtUsu;//chamo o caminho dos dados
            }

        }

        public int codigo_usu;
        private void button1_Click(object sender, EventArgs e)
        {

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            //para a segurança dos dados

            int idchave;


            MySqlConnection conexao3 = con.getConexao();
            string sql3 = "SELECT id_chave from tb_chave where num_chave =" + this.cod_chave + ";";
            conexao3.Open();
            MySqlCommand comando3 = new MySqlCommand(sql3, conexao3);
            MySqlDataReader registro = comando3.ExecuteReader();
            registro.Read();
            idchave = Convert.ToInt32(registro["id_chave"]);
            conexao3.Close();
            //MessageBox.Show(+idchave + " oioioi");




            string sql = "insert into tb_emprestimo(id_usuario,id_chave,horario_saida) values" + "('" + codigo_usu + "','" + idchave + "','" + txtEmprestimo.Text + "')";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            conexao.Open();
            comando.ExecuteReader();
            conexao.Close();

            MySqlConnection conexao2 = con.getConexao();
            string sql2 = "update tb_chave set stats = 'Indisponível' where id_chave = @id_chave";
            MySqlCommand comando2 = new MySqlCommand(sql2, conexao2);
            comando2.Parameters.AddWithValue("@id_chave", idchave);
            conexao2.Open();
            comando2.ExecuteReader();
            conexao2.Close();



            MessageBox.Show("Chave emprestada!");

            Popup.Chave.CurrentInstance.reset();

        }

        public string cpf;

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int contador = dgvUsuario.RowCount - 1;
            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                this.cpf = Convert.ToString(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);

                ClassUsuario usu = new ClassUsuario();//chamo classe usuario
                ClassConexao con = new ClassConexao();//chamo a classe conexao

                MySqlConnection conexao = con.getConexao();
                conexao.Open();

                string consulta_id = "select id_usuario from tb_usuario where cpf=@cpf";

                MySqlCommand comando = new MySqlCommand(consulta_id, conexao);
                comando.Parameters.AddWithValue("@cpf", cpf);
                MySqlDataReader registro = comando.ExecuteReader();//executa a consulta
                registro.Read();
                this.codigo_usu = Convert.ToInt32(registro["id_usuario"]);
                conexao.Close();

                //MessageBox.Show("id usu: " + this.codigo_usu);
            }


        }
    }
}
