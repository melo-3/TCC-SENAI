using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //Cria um alerta para o usuario
using MySql.Data.MySqlClient; //Biblioteca mysql
using System.Data;
using System.Security;

namespace Almoxarifado_TCC
{
    class ClassConexao
    {
        // Variaveis de conexao
        static private string servidor = "localhost"; // caminho do servidor
        static private string bancodedados = "db_almoxarifado"; // nome do banco
        static private string usuario = "root"; // nome padrão
        static private string senha = ""; //


        static public string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getConexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getConexao().Open();//abrir a conexao bd
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result; //retorna a conexão
        }
        public void desconectar()
        {
            getConexao().Close();
        }

        public DataTable Getperfil()
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe

            MySqlConnection conexao = con.getConexao();
            string SQL = "select * from tb_tipo_usuario";
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_tipo_usuario = new DataTable();
            dados.Fill(tb_tipo_usuario);
            return tb_tipo_usuario;

                conexao.Close();
        }

    }
}