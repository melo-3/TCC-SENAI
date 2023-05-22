using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;// Usado para o DllImport
using MySql.Data.MySqlClient;
using System.Windows.Markup;

namespace Almoxarifado_TCC.Popup
{
    public partial class Ceder : Form
    {

        public int cod_item;
        public int cod_usu;

        public Ceder(int cod)
        {
            cod_item = cod;
            InitializeComponent();
            this.TopMost = true;
        }

        #region Visuais

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ceder_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";
                txtCpf.ForeColor = Color.Black;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF";
                txtCpf.ForeColor = Color.Black;
            }
        }


        #endregion

        public void reset() {

            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT cpf as CPF from tb_usuario";
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void Ceder_Load(object sender, EventArgs e)
        {
            reset();

            ClassConexao con1 = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao1 = con1.getConexao();
            String consulta1 = "";
            conexao1.Open();//Abro minha conexao
            consulta1 = "SELECT quant from tb_item where id_item='" + cod_item + "'";

            //Monta meu comando sql
            MySqlCommand commando1 = new MySqlCommand(consulta1, conexao1);
            MySqlDataReader registro = commando1.ExecuteReader();
            registro.Read();

            lblQuantTotal.Text = Convert.ToString(registro["quant"]);
            quantTt = Convert.ToInt32(registro["quant"]);

            conexao1.Close();

            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(73, 78, 92);
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(39, 43, 52);
            dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuario.BackgroundColor = Color.FromArgb(56, 60, 71);

            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dgvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) + 1;          

            if (txtQuant.Text == lblQuantTotal.Text) { 
 
            }
            else
            {
                txtQuant.Text = valoradd.ToString();
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) - 1;
            txtQuant.Text = valoradd.ToString();

            if (Convert.ToInt32(txtQuant.Text) <= 0)
            {
                txtQuant.Text = "0";
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCpf.Text != "CPF" && txtCpf.Text != "")
            {
                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta = "";

                consulta = "SELECT cpf as CPF from tb_usuario where cpf ='" + txtCpf.Text + "'";

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

            else if (e.KeyCode == Keys.Enter && txtCpf.Text != "CPF" && txtCpf.Text == "")
            {
                reset();
            }
        }

        public int quantAt, quantTt, quant;
        public string hora, data;

        private void Hora_Ceder_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCeder_Click(object sender, EventArgs e)
        {

            quantAt = Convert.ToInt32(txtQuant.Text);
            quant = quantTt - quantAt;

            /// Insere os dados na tabela de emprestimo
            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();

            string sql3 = "insert into tb_emp_item(id_item, id_usuario, quant, hora_emp, hora_dev, data_emp, data_dev, obs) values"+"('" + cod_item + "','" + cod_usu + "','" + quantAt + "','" + hora + "','" + "11/11/1111" + "','" + data + "')";
            conexao.Open();
            MySqlCommand comando3 = new MySqlCommand(sql3, conexao);
            MySqlDataReader registro = comando3.ExecuteReader();
            registro.Read();

            ////idchave = Convert.ToInt32(registro["id_chave"]);

            conexao.Close();
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int contador = dgvUsuario.RowCount - 1;

            if (e.RowIndex < contador && e.RowIndex >= 0)
            {
                //aguarda o codigo da linha selecionada
                cod_usu = Convert.ToInt32(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("Código usu: " + cod_usu);
            }
            else
            {

            }
        }
    }
}
