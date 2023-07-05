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
//bibliotecas email
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Web;
using System.Net.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class FormRecuperar : Form
    {

        private string fullText;
        private int currentLength;

        private string fullText2;
        private int currentLength2;

        public FormRecuperar()
        {
            InitializeComponent();

            // Define a string completa que será exibida no label
            fullText = "Insira o código de recuperação na caixa abaixo";

            // Inicializa o contador de caracteres exibidos como zero
            currentLength = 0;

            // Define a string completa que será exibida no label
            fullText2 = "CÓDIGO";

            // Inicializa o contador de caracteres exibidos como zero
            currentLength2 = 0;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "INSIRA SEU CPF")
            {
                txtCPF.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "INSIRA SEU CPF";
            }
        }

        private void tmLabel_Tick(object sender, EventArgs e)
        {
            // Incrementa o contador de caracteres exibidos
            currentLength++;

            // Define o texto do label como um substring da string completa com base no contador
            txtLabel.Text = fullText.Substring(0, currentLength);

            // Para o timer quando a string completa tiver sido exibida completamente
            if (currentLength == fullText.Length)
            {
                tmLabel.Stop();
                txtCPF.Visible = false;
                txtCodigo.Visible = true;
                tmCPF.Start();
            }
        }

        private void tmCPF_Tick(object sender, EventArgs e)
        {
            // Incrementa o contador de caracteres exibidos
            currentLength2++;

            // Define o texto do label como um substring da string completa com base no contador
            txtCodigo.Text = fullText2.Substring(0, currentLength2);

            // Para o timer quando a string completa tiver sido exibida completamente
            if (currentLength2 == fullText2.Length)
            {
                tmCPF.Stop();
            }
        }

        public int identificador = 1, result = 0;
        public string cpf;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            iconAviso.Visible = false;
            lblAviso.Visible = false;

            if (txtCPF.Text == "" || txtCPF.Text == "INSIRA SEU CPF")
            {
                iconAviso.Visible = true;
                lblAviso.Text = "Campo CPF invalido ou vazio";
            }
            else
            {
                if (identificador == 1)
                {
                    ClassUsuario usu = new ClassUsuario();
                    cpf = txtCPF.Text;
                    string resultado = usu.recuperarEmail(cpf);

                    result = Convert.ToInt32(resultado);
                    //MessageBox.Show(resultado);
                    if (result != 1)
                    {
                        iconAviso.Visible = true;
                        iconAviso.IconChar = FontAwesome.Sharp.IconChar.Envelope;
                        lblAviso.Visible = true;
                        lblAviso.Text = "E-mail enviado!";
                        await Task.Delay(1000);
                        tmLabel.Start();

                        identificador = 0;
                    }
                    else
                    {
                        iconAviso.Visible = true;
                        iconAviso.IconChar = FontAwesome.Sharp.IconChar.Warning;
                        lblAviso.Visible = true;
                        lblAviso.Text = "CPF não encontrado";
                    }
                        
                }

                else if (identificador == 0)
                {
                    ClassUsuario usu = new ClassUsuario();
                    int confirm = Convert.ToInt32(txtCodigo.Text);

                    if (confirm == result)
                    {
                        Login.CurrentInstance.TimerNovaS(cpf);
                    }
                    else
                    {
                        //MessageBox.Show("Código de recuperação inválido");
                    }
                }
            }
            
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "CÓDIGO")
            {
                txtCodigo.Text = "";
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                txtCodigo.Text = "CÓDIGO";
            }
        }
    }
}
