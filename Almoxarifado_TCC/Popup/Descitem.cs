using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class Descitem : Form
    {

        public int cod_desc, quantAt, quantTt, quantFn;
        public string data, hora, nome, desc, quant;

        public Descitem(int cod)
        {
            InitializeComponent();
            cod_desc = cod;
            hora_desc.Start();
        }

        private void Descitem_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT nome_item, descricao, quant from tb_item where id_item=" + cod_desc;
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            txtNome.Text = Convert.ToString(registro["nome_item"]);
            txtDescricao.Text = Convert.ToString(registro["descricao"]);
            lblQuantTotal.Text = Convert.ToString(registro["quant"]);
            quantTt = Convert.ToInt32(registro["quant"]);
            conexao.Close();

            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Obs";
                lblDescricao.Visible = false;
            }
            else {
                lblDescricao.Visible = true;
            }
        }


        #region Botões

        private void btnMax_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) + 1;

            if (txtQuant.Text == lblQuantTotal.Text)
            {

            }
            else
            {
                txtQuant.Text = valoradd.ToString();
            }

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int valorret = Convert.ToInt32(txtQuant.Text) - 1;
            txtQuant.Text = valorret.ToString();

            if (Convert.ToInt32(txtQuant.Text) <= 0)
            {
                txtQuant.Text = "0";
            }
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            quantAt = Convert.ToInt32(txtQuant.Text);
            quantFn = quantTt - quantAt;

            if (txtQuant.Text != "0")
            {

                if (txtObs.Text == "Obs")
                {
                    txtObs.Text = "";
                }

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                string sql = "insert into tb_descarte(id_item, quant, hora_desc, data_desc, obs, stats) values" + "('" + cod_desc + "','" + txtQuant.Text + "','" + hora + "','" + data + "','" + txtObs.Text + "',' Esperando')";
                conexao.Open();
                MySqlCommand command = new MySqlCommand(sql, conexao);
                MySqlDataReader registro = command.ExecuteReader();
                registro.Read();
                conexao.Close();

                ClassConexao con1 = new ClassConexao();
                MySqlConnection conexao1 = con1.getConexao();
                string sql1 = "UPDATE tb_item SET quant = @quant WHERE id_item = " + cod_desc + ";";
                MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
                command1.Parameters.AddWithValue("@quant", quantFn);
                conexao1.Open();
                command1.ExecuteNonQuery();
                conexao1.Close();

                TelaPrincipal.CurrentInstance.Popups_Fechar();
                this.Close();
                Popup.Estoque.CurrentInstance.reset();
            }
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        #endregion


        #region Visuais

        private void txtObs_Enter(object sender, EventArgs e)
        {
            if (txtObs.Text == "Obs")
            {
                txtObs.Text = "";
                lblObs.Visible = true;
            }
        }

        private void txtObs_Leave(object sender, EventArgs e)
        {
            if (txtObs.Text == "")
            {
                txtObs.Text = "Obs";
                lblObs.Visible = false;
            }
        }


        #endregion


        private void hora_desc_Tick(object sender, EventArgs e)
        {
            data = DateTime.Now.ToString("dd/MM/yyyy");
            hora = DateTime.Now.ToString("HH:mm");
        }
    }
}
