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
using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class DevolverChave : Form
    {
        public string nome;
        public int cod_emp;
        public int cod_chave;
        public DevolverChave(int cod)
        {
            InitializeComponent();
            cod_emp = cod;
            Temp_devolucao.Start();

            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT u.nome_usuario, ec.id_chave, ec.horario_emp from tb_usuario u inner join tb_emp_chave ec on u.id_usuario=ec.id_usuario where id_emp="+cod_emp +"";
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao

            MySqlCommand comando = new MySqlCommand(consulta, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                string horarioEmprestimo = Convert.ToString(registro["horario_emp"]);
                int quantidadeCaracteres = 5; // Defina a quantidade de caracteres que você deseja exibir

                if (horarioEmprestimo.Length > quantidadeCaracteres)
                {
                    horarioEmprestimo = horarioEmprestimo.Substring(0, quantidadeCaracteres);
                }

                txtNome.Text = Convert.ToString(registro["nome_usuario"]);
                cod_chave = Convert.ToInt32(registro["id_chave"]);
                txtEmprestimo.Text = horarioEmprestimo;
                //MessageBox.Show("Oiiiii giiii <3 "+cod_chave);
            }
            conexao.Close();
        }

        #region Interações visuais

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void DevolverChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        #region Botões

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao1 = con1.getConexao();

            string SQL1 = "UPDATE tb_emp_chave set horario_dev = @horario, data_dev = @data where id_emp=" + cod_emp + " ";
            MySqlCommand comando = new MySqlCommand(SQL1, conexao1);
            comando.Parameters.AddWithValue("@horario", txtDevolucao.Text);
            comando.Parameters.AddWithValue("@data", data);

            conexao1.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Atualização realizada com sucesso!");
            this.Close();

            ClassConexao con2 = new ClassConexao();
            MySqlConnection conexao2 = con2.getConexao();

            string SQL2 = "UPDATE tb_chave set stats = 'Disponível' where id_chave=" + cod_chave + " ";
            MySqlCommand comando2 = new MySqlCommand(SQL2, conexao2);

            conexao2.Open();
            comando2.ExecuteNonQuery();
            this.Close();

            Popup.Pedidos.CurrentInstance.reset();
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        #endregion

        public string data;

        private void Temp_devolucao_Tick(object sender, EventArgs e)
        {
            txtDevolucao.Text = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
