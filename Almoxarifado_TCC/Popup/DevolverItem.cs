using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class DevolverItem : Form
    {
        public int cod_emp;
        public string hora, data;

        public DevolverItem(int cod)
        {
            InitializeComponent();
            Hora_Devolver.Start();
            cod_emp = cod;
        }

        private void DevolverItem_Load(object sender, EventArgs e)
        {
            string nome, horarioEmprestimo;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT u.nome_usuario, e.hora_emp from tb_emp_item e inner join tb_usuario u on e.id_usuario=u.id_usuario where id_emp_item='" + cod_emp + "'";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            nome = Convert.ToString(registro["nome_usuario"]);
            
            horarioEmprestimo = Convert.ToString(registro["hora_emp"]);
            int quantidadeCaracteres = 5; // Defina a quantidade de caracteres que você deseja exibir

            if (horarioEmprestimo.Length > quantidadeCaracteres)
            {
                horarioEmprestimo = horarioEmprestimo.Substring(0, quantidadeCaracteres);
            }

            conexao.Close();

            txtNome.Text = nome;
            txtEmprestimo.Text = horarioEmprestimo;

        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            string obs = txtObs.Text;
            int cod_item, quant, quantTotal, quantAtual;

            if (txtObs.Text == "Obs")
            {
                obs = "";
            }

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            string sql = "UPDATE tb_emp_item SET hora_dev = @hora, data_dev = @data, obs = @observacao WHERE id_emp_item = " + cod_emp + ";";
            MySqlCommand command = new MySqlCommand(sql, conexao);
            command.Parameters.AddWithValue("@hora", txtDevolucao.Text);
            command.Parameters.AddWithValue("@data", data);
            command.Parameters.AddWithValue("@observacao", obs);
            conexao.Open();
            command.ExecuteNonQuery();
            conexao.Close();

            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao1 = con1.getConexao();
            String consulta1 = "";
            conexao1.Open();
            consulta1 = "SELECT id_item, quant from tb_emp_item where id_emp_item="+cod_emp;
            MySqlCommand commando1 = new MySqlCommand(consulta1, conexao1);
            MySqlDataReader registro = commando1.ExecuteReader();
            registro.Read();
            cod_item = Convert.ToInt32(registro["id_item"]);
            quant = Convert.ToInt32(registro["quant"]);
            conexao1.Close();

            ClassConexao con3 = new ClassConexao();
            MySqlConnection conexao3 = con3.getConexao();
            String consulta3 = "";
            conexao3.Open();
            consulta3 = "SELECT quant from tb_item where id_item=" + cod_item;
            MySqlCommand commando3 = new MySqlCommand(consulta3, conexao3);
            MySqlDataReader registro3 = commando3.ExecuteReader();
            registro3.Read();
            quantAtual = Convert.ToInt32(registro3["quant"]);
            conexao3.Close();

            quantTotal = quant + quantAtual;

            ClassConexao con2 = new ClassConexao();
            MySqlConnection conexao2 = con2.getConexao();
            string sql2 = "UPDATE tb_item SET quant = @quant WHERE id_item = " + cod_item + ";";
            MySqlCommand command2 = new MySqlCommand(sql2, conexao2);
            command2.Parameters.AddWithValue("@quant", quantTotal);
            conexao2.Open();
            command2.ExecuteNonQuery();
            conexao2.Close();

            TelaPrincipal.CurrentInstance.Popups_Fechar();
            Forms.EmpItem.CurrentInstance.reset();
            this.Close();
            
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void Hora_Devolver_Tick(object sender, EventArgs e)
        {
            txtDevolucao.Text = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
