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
    public partial class ExcItem : Form
    {
        public int cod_item;
        public ExcItem(int codigo_item)
        {
            cod_item = codigo_item;
            InitializeComponent();
            this.TopMost = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ExcItem_MouseDown(object sender, MouseEventArgs e)
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
            if (txtConfirm.Text == "Insira o nome do item")
            {
                txtConfirm.Text = "";
            }
        }

        private void txtConfirm_Leave(object sender, EventArgs e)
        {
            if (txtConfirm.Text == "")
            {
                txtConfirm.Text = "Insira o nome do item";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();//instancia de conexão
            MySqlConnection conexao = con.getConexao(); //obtive a conexao
            String consulta = "SELECT nome_item from tb_item where id_item = " + this.cod_item + "";
            conexao.Open();//Abro minha conexao
            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            string item = Convert.ToString(registro["nome_item"]);
            //MessageBox.Show(sala);
            conexao.Close();

            if (txtConfirm.Text == item)
            {
                int resultado;
                MySqlConnection conexao2 = con.getConexao();
                string excluir = "delete from tb_item where id_item =" + this.cod_item + "";
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
                Popup.Estoque.CurrentInstance.reset();

            }
            else
            {
                MessageBox.Show("Voce escreveu o item errada");
            }
        }
    }
}
