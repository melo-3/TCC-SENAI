using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
//bibliotecas email
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Web;
using System.Net.Configuration;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Almoxarifado_TCC

{
    class ClassUsuario
    {
        public int codigo;
        public string nome;
        public string cpf;
        public string telefone;
        public string email;
        public string login;
        public string senha;
        public bool logado;
        public string perfil;
        public string fotousu;
        public int cod_rec;

        public void usuario()
        {
            this.codigo = 0;
            this.nome = "";
            this.cpf = "";
            this.telefone = "";
            this.email = "";
            this.perfil = "";
            this.fotousu = "";
        }

        public string recuperarEmail(string cpf)
        {
            string msg;
            if (cpf == "")
            {
                msg = "Login está vazio";
                return msg;
            }
            ClassConexao conexao = new ClassConexao();
            MySqlConnection con = conexao.getConexao();
            string sql = "select * from tb_admin where cpf=@cpf";

            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cpf", cpf);
            try
            {
                con.Open();
                MySqlDataReader registro = comando.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    nome = Convert.ToString(registro["nome_admin"]);
                    email = Convert.ToString(registro["email"]);
                    cpf = Convert.ToString(registro["cpf"]);
                    codigo = Convert.ToInt32(registro["id_admin"]);
                    senha = Convert.ToString(registro["senha"]);
                }
                else
                {
                    msg = "1";
                    return msg;
                }

                //gera código aleatório
                Random numAletorio = new Random();
                cod_rec = numAletorio.Next(1000, 10000);

                ///MessageBox.Show("email: "+email);
                // começar o acesso ao email
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.office365.com";
                //client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("grupinhodoti@gmail.com", "124900TI");
                MailMessage mail = new MailMessage();
                mail.Sender = new System.Net.Mail.MailAddress("grupinhodoti@gmail.com", "sistema uuuuuuuu");
                mail.From = new MailAddress("grupinhodoti@gmail.com", "Sistema Grupinho do TI");
                mail.To.Add(new MailAddress(email, nome));
                mail.Subject = "Almoxarifado: Senha esquecida";
                mail.Body = "Esse email foi enviado com um código de verificação para recuperar sua senha. O código é: " + cod_rec + " Favor não responder esse email.";
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                try
                {
                    client.Send(mail);
                    msg = "email enviado";
                    //return msg;
                    string cod_rec2 = Convert.ToString(cod_rec);
                    return cod_rec2;

                }
                catch (Exception erro)
                {
                    msg = "erro:" + erro.Message;
                    return msg;

                }
                finally
                {
                    mail = null;
                }
            }
            catch (SqlException erro)
            {
                msg = "erro no banco" + erro.Message;
                return msg;

            }
            finally
            {
                con.Close();
            }
            //return msg;
        }

        public string foto
        {
            get { return fotousu; }
            set { fotousu = value; }
        }


        public string getMD5hash(string senha) //criptografia da senha
        {
            System.Security.Cryptography.MD5 mds = System.Security.Cryptography.MD5.Create();
            byte[] imputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = mds.ComputeHash(imputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

    }
    }
