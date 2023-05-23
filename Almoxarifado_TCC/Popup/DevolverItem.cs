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
    public partial class DevolverItem : Form
    {
        public int cod_emp;
        public string hora, data, usuario;

        public DevolverItem(int cod)
        {
            InitializeComponent();
            Hora_Devolver.Start();
        }

        private void DevolverItem_Load(object sender, EventArgs e)
        {
            txtDevolucao.Text = hora;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            String consulta = "";
            consulta = "SELECT u.nome_usuario from tb_emp_item e inner join tb_usuario u on e.id_usuario=u.id_usuario where id_emp_item='" + cod_emp + "'";
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();
            MySqlDataReader registro = commando.ExecuteReader();
            registro.Read();
            usuario = Convert.ToString(registro["nome_usuario"]);
            conexao.Close();

            txtNome.Text = usuario;
        }

        private void Hora_Devolver_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/YYYY");
        }
    }
}
