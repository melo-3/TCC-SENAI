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
    public partial class EdtItem : Form
    {
        public int cod_item;
        public EdtItem(int codigo_item)
        {
            InitializeComponent();
            txtQuant.Text = "0";
            this.TopMost = true;
            cod_item = codigo_item;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            conexao.Open();

            string itemsql = "SELECT * FROM tb_item WHERE id_item= '" + this.cod_item + "'"; //cria a variavel consulta usuario passando o atributo id
            MySqlCommand comando = new MySqlCommand(itemsql, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            txtNome.Text = Convert.ToString(registro["nome_item"]);
            txtDescricao.Text = Convert.ToString(registro["descricao"]);
            lblquant.Text = Convert.ToString(registro["quant"]);

            conexao.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void EdtItem_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = "";
                lblNome.Visible = true;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                lblNome.Visible = false;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Descrição")
            {
                txtDescricao.Text = "";
                lblDescricao.Visible = true;
            }
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descrição";
                lblDescricao.Visible = false;
            }
        }

        private void lklCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao2 = con.getConexao();

            string SQL = "UPDATE tb_item SET nome_item = @nome_item, descricao = @descricao, quant = @quant WHERE id_item = " + this.cod_item + ";";
            MySqlCommand comando = new MySqlCommand(SQL, conexao2);
            comando.Parameters.AddWithValue("@id_item", this.cod_item);
            comando.Parameters.AddWithValue("@nome_item", txtNome.Text);
            comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            comando.Parameters.AddWithValue("@quant", txtQuant.Text);

            try
            {
                conexao2.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Atualização realizada com sucesso!");
                this.Close();
                Popup.Estoque.CurrentInstance.reset();
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
                TelaPrincipal.CurrentInstance.Popups_Fechar();
                conexao2.Close();
            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {

            int valoradd = Convert.ToInt32(txtQuant.Text) + 1;
            txtQuant.Text = valoradd.ToString();
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
    }
}
