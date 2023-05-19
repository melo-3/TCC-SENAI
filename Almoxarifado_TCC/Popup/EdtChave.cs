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
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class EdtChave : Form
    {
        public int cod_chave;
        public EdtChave(int codigo_chave)
        {
            InitializeComponent();
            cod_chave = codigo_chave;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            conexao.Open();
            string chavesql = "SELECT * FROM tb_chave WHERE num_chave = " + this.cod_chave; //cria a variavel consulta usuario passando o atributo id
            MySqlCommand comando = new MySqlCommand(chavesql, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            txtNumero.Text = Convert.ToString(registro["num_chave"]);
            txtSala.Text = Convert.ToString(registro["sala_lab"]);
            cbxStatus.Text = Convert.ToString(registro["stats"]);
            txtObs.Text = Convert.ToString(registro["obs"]);
            conexao.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void EdtChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNumero_Enter(object sender, EventArgs e)
        {
            if (txtNumero.Text == "Número")
            {
                txtNumero.Text = "";
            }
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "Número";
            }
        }

        private void txtSala_Enter(object sender, EventArgs e)
        {
            if (txtSala.Text == "Sala / Lab")
            {
                txtSala.Text = "";
            }
        }

        private void txtSala_Leave(object sender, EventArgs e)
        {
            if (txtSala.Text == "")
            {
                txtSala.Text = "Sala / Lab";
            }
        }

        private void txtObs_Enter(object sender, EventArgs e)
        {
            if (txtObs.Text == "Obs")
            {
                txtObs.Text = "";
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (txtObs.Text == "")
            {
                txtObs.Text = "Obs";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)// Botão de Editar

        {

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao2 = con.getConexao();

            string SQL = "UPDATE tb_chave SET num_chave = @num_chave, sala_lab = @sala_lab, stats = @stats, obs = @obs WHERE num_chave = " + this.cod_chave + ";";
            MySqlCommand comando = new MySqlCommand(SQL, conexao2);
            comando.Parameters.AddWithValue("@num_chave", txtNumero.Text);
            comando.Parameters.AddWithValue("@sala_lab", txtSala.Text);
            comando.Parameters.AddWithValue("@stats", cbxStatus.Text);
            comando.Parameters.AddWithValue("@obs", txtObs.Text);        
          
            try {
                conexao2.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualização realizada com sucesso!");
                this.Close();
                Popup.Chave.CurrentInstance.reset();
            }


            catch (MySqlException ex)
            {
                // Trata as exceções específicas do MySQL
                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Não foi possível conectar ao servidor.");
                        break;
                    case 1062:
                        MessageBox.Show("Já existe uma chave com esse número.");
                        break;
                    default:
                        MessageBox.Show("Erro: " + ex.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                // Trata as demais exceções
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Fecha a conexão com o banco de dados
                conexao2.Close();
            }

        }

        private void lklCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

    }
}
