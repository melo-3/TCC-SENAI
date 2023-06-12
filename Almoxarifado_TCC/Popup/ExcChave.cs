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

namespace Almoxarifado_TCC.Popup
{
    public partial class ExcChave : Form
    {
        public int cod_chave;
        public ExcChave(int codigo_chave)
        {
            InitializeComponent();
            this.TopMost = true;
            cod_chave = codigo_chave; 
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ExcChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconExc_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtConfirm_Enter(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "Insira o nome da sala")
            {
                txtConfirm.Text = "";
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Insira o nome da sala";
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();//instancia de conexão
            MySqlConnection conexao = con.getConexao(); //obtive a conexao
            String consulta = "SELECT sala_lab from tb_chave where num_chave = " + this.cod_chave + "";
            conexao.Open();//Abro minha conexao
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            string sala = Convert.ToString(registro["sala_lab"]);
            //MessageBox.Show(sala);
            conexao.Close();

            if (txtConfirm.Text == sala)
            {
                int resultado;
                MySqlConnection conexao2 = con.getConexao();
                string excluir = "delete from tb_chave where num_chave =" + this.cod_chave + "";
                MySqlCommand comando2 = new MySqlCommand(excluir, conexao2);
                conexao2.Open();//Abro minha conexao
                resultado = comando2.ExecuteNonQuery();
                if (resultado >= 1)
                {
                    MessageBox.Show("Excluido com sucesso"); 
                }
                conexao2.Close();
                this.Close();
                //MessageBox.Show("Nome: " + this.cod_chave);
                Popup.Chave.CurrentInstance.reset();
            }
            else
            {
                MessageBox.Show("Voce escreveu a sala errada");
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
