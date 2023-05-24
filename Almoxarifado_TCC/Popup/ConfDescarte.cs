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
    public partial class ConfDescarte : Form
    {

        public int cod_desc;
        public string obs;

        public ConfDescarte(int cod)
        {
            InitializeComponent();
            cod_desc = cod;
        }

        private void ConfDescarte_Load(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT i.nome_item, i.descricao, d.quant, d.obs, d.stats from tb_descarte d inner join tb_item i on d.id_item=i.id_item where id_descarte=" + cod_desc + "";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();

            txtStatus.Text = Convert.ToString(registro["stats"]);
            txtNome.Text = Convert.ToString(registro["nome_item"]);
            txtDescricao.Text = Convert.ToString(registro["descricao"]);
            txtQuant.Text = Convert.ToString(registro["quant"]);
            txtObs.Text = Convert.ToString(registro["obs"]);
            
            conexao.Close();
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            string status = "Confirmado";
            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao1 = con1.getConexao();
            string sql1 = "UPDATE tb_descarte SET obs = @obs, stats = @status WHERE id_descarte = " + cod_desc + ";";
            MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
            command1.Parameters.AddWithValue("@obs", txtObs.Text);
            command1.Parameters.AddWithValue("@status", status);
            conexao1.Open();
            command1.ExecuteNonQuery();
            conexao1.Close();

            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
            Popup.Descarte.CurrentInstance.reset();
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }
    }
}
