using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class VisualizarADM : Form
    {

        public int id_adm;
        public VisualizarADM(int cod)
        {
            InitializeComponent();
            id_adm = cod;
        }

        private void VisualizarADM_Load(object sender, EventArgs e)
        {

            ClassConexao con1 = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao1 = con1.getConexao();
            String consulta1;
            consulta1 = "SELECT nome_admin, email, telefone, foto from tb_admin where id_admin="+ id_adm;
            MySqlCommand commando1 = new MySqlCommand(consulta1, conexao1);
            conexao1.Open();//Abro minha conexao
            MySqlDataAdapter dados1 = new MySqlDataAdapter(commando1);
            MySqlDataReader registro = commando1.ExecuteReader();
            registro.Read();
            txtNome.Text = Convert.ToString(registro["nome_admin"]);
            txtEmail.Text = Convert.ToString(registro["email"]);
            string fone = Convert.ToString(registro["telefone"]);
            if (fone == "" || fone == null)
            {
                txtTelefone.Text = "Não possui";
            }
            else { txtTelefone.Text = fone;}
    
            conexao1.Close();

            MySqlConnection connection = null;

            try
            {
                ClassConexao con = new ClassConexao();         //instancia de conexão
                MySqlConnection conexao = con.getConexao();      //obtive a conexao

                string selectQuery = "SELECT foto FROM tb_admin WHERE id_admin = @id";
                MySqlCommand command = new MySqlCommand(selectQuery, conexao);
                command.Parameters.AddWithValue("@id", id_adm);

                conexao.Open();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            byte[] imageData = (byte[])reader["foto"];

                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                panelPerfiFoto.BackgroundImage = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            panelPerfiFoto.BackgroundImage = null; // Se a imagem for nula, limpa o controle PictureBox
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Lidar com exceções relacionadas ao MySQL aqui
            }
            finally
            {
                // Certifique-se de fechar a conexão, mesmo em caso de exceção
                if (connection != null)
                {
                    connection.Close();
                }
            }

            

        }
    }
}
