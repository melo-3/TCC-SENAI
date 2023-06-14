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
        string nome_usu, cpf, hora, data;
        int cod_item, cod_usu, quantAt, quantTt, quant;

        public Ceder(int cod)
        {
            cod_item = cod;
            InitializeComponent();
            Hora_Ceder.Start();
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
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF";
            }
        }


        #endregion

        public void reset() {

            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT nome_usuario as Nome from tb_usuario";
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
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 30, 36);
            dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuario.BackgroundColor = Color.FromArgb(39, 43, 52);

            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 43, 52);
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

                consulta = "SELECT nome_usuario as Nome from tb_usuario where cpf ='" + txtCpf.Text + "'";

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

        private void Hora_Ceder_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCeder_Click(object sender, EventArgs e)
        {
            if (txtQuant.Text == "0" || nome_usu == null)
            {   

            }
            else
            {
                quantAt = Convert.ToInt32(txtQuant.Text);
                quant = quantTt - quantAt;

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                string sql = "insert into tb_emp_item(id_item, id_usuario, quant, hora_emp, data_emp) values" + "('" + cod_item + "','" + cod_usu + "','" + quantAt + "','" + hora + "','" + data + "')";
                conexao.Open();
                MySqlCommand command = new MySqlCommand(sql, conexao);
                MySqlDataReader registro = command.ExecuteReader();
                registro.Read();
                conexao.Close();

                ClassConexao con1 = new ClassConexao();
                MySqlConnection conexao1 = con1.getConexao();
                string sql1 = "UPDATE tb_item SET quant = @quant WHERE id_item = " + cod_item + ";";
                MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
                command1.Parameters.AddWithValue("@quant", quant);
                conexao1.Open();
                command1.ExecuteNonQuery();
                conexao1.Close();

                TelaPrincipal.CurrentInstance.Popups_Fechar();
                Popup.Estoque.CurrentInstance.reset();
                this.Close();
            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                //aguarda o codigo da linha selecionada
                nome_usu = Convert.ToString(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT id_usuario, cpf from tb_usuario where nome_usuario ='" + nome_usu + "'";
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                cod_usu = Convert.ToInt32(registro["id_usuario"]);
                cpf = Convert.ToString(registro["cpf"]);
                conexao.Close();
                txtCpf.Text = cpf;
        }
    }
}
