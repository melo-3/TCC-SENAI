﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almoxarifado_TCC.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace Almoxarifado_TCC.Popup
{
    public partial class CriarUsuario : Form
    {
        int id_adm;
        private Form activeForm = null;
        public CriarUsuario(int cod_adm)
        {
            InitializeComponent();
            CurrentInstance = this;
            id_adm = cod_adm;
        }
        public static CriarUsuario CurrentInstance;

        // Código que permite ao usuario mover o programa pela tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CriarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "";
                txtTelefone.Visible = true;
                LinhaTel.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                checkBox1.Text = "Deseja cadastrar um telefone?";
                txtTelefone.Text = "TELEFONE";
                txtTelefone.Visible = false;
                LinhaTel.Visible = false;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "NOME")
            {
                txtNome.Text = "";
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "NOME";
            }
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "CPF")
            {
                txtCPF.Text = "";
            }
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "CPF";
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "EMAIL")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "EMAIL";
            }
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "TELEFONE")
            {
                txtTelefone.Text = "";
            }
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "TELEFONE";
            }
        }

        int codTipo;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codTipo = Convert.ToInt32(((DataRowView)cmbTipo.SelectedItem)["id_tipo_usu"]);  
        }

        private void CriarUsuario_Load(object sender, EventArgs e)
        {
            DataCriacao.Start();
            ClassConexao con = new ClassConexao(); //instanciando a classe

            cmbTipo.DataSource = con.Getperfil(); //popula as info do perfil da tabela
            cmbTipo.DisplayMember = "tipo_usu"; //mostra descrição do campo
            cmbTipo.ValueMember = "id_tipo_usu"; //pega o codigo do campo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Gerenciamento.CurrentInstance.reset();
            Gerenciamento.CurrentInstance.Fechar();
            this.Close();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassConexao con = new ClassConexao(); //instanciando a classe
            ClassUsuario usu = new ClassUsuario();
            string nome = txtNome.Text, cpf = txtCPF.Text, email = txtEmail.Text, tipo = cmbTipo.Text;
            if (nome == "NOME")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo NOME está vazio";
            }
            else if (cpf == "CPF")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo CPF está vazio";
            }

            else if (CPFLenght != 14)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Insira um CPF válido";
            }

            else if (email == "EMAIL")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo Email está vazio";
            }

            else if (tipo == "Nenhum")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Campo Tipo está vazio";
            }

            else
            {
                try
                {
                    MySqlConnection conexao = con.getConexao();
                    //para a segurança dos dados
                    if (txtTelefone.Text == "TELEFONE")
                    {
                        txtTelefone.Text = "";
                    }
                    string sql = "insert into tb_usuario(nome_usuario,cpf,email,telefone,id_tipo_usu, stats) values" + "('" + txtNome.Text + "','" + txtCPF.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "','" + codTipo + "', 'Ativo')";
                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    conexao.Open();
                    comando.ExecuteReader();
                    
                    //MessageBox.Show("Cadastro realizado!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
                finally
                {
                    Hist_Cadastro(txtCPF.Text);
                    Gerenciamento.CurrentInstance.reset();
                    Gerenciamento.CurrentInstance.Fechar();
                    con.desconectar();
                }
            }
        }

        private void Hist_Cadastro(string cpf_usuario)
        {
            int id_usuario;

            ClassConexao con = new ClassConexao();
            MySqlConnection conexao = con.getConexao();
            conexao.Open();
            string itemsql = "SELECT id_usuario FROM tb_usuario WHERE cpf= '" + cpf_usuario + "'"; //cria a variavel consulta usuario passando o atributo id
            MySqlCommand comando = new MySqlCommand(itemsql, conexao);
            MySqlDataReader registro = comando.ExecuteReader();
            registro.Read();
            id_usuario = Convert.ToInt32(registro["id_usuario"]);
            conexao.Close();

            ClassConexao con1 = new ClassConexao();
            MySqlConnection conexao1 = con.getConexao();
            string sql1 = "insert into tb_cadastro(id_admin, id_usuario, data_criacao) values" + "('" + id_adm + "','" + id_usuario + "','" + data + "')";
            MySqlCommand comando1 = new MySqlCommand(sql1, conexao1);
            conexao1.Open();
            comando1.ExecuteReader();
            con1.desconectar();

            //MessageBox.Show(" Foi essa merda! ");
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int CPFLenght = 0;
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no CPF
            string cpf = txtCPF.Text.Replace(".", "").Replace("-", "");

            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length == 11)
            {
                // Formatar o CPF com os pontos e o traço
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";

                // Atualizar o texto da TextBox com o CPF formatado
                txtCPF.Text = cpf;

                txtCPF.SelectionStart = txtCPF.Text.Length;
            }

            CPFLenght = txtCPF.Text.Length;

            if (txtCPF.Text.Length > 14)
            {
                txtCPF.Text = txtCPF.Text.Substring(0, 14);
                txtCPF.SelectionStart = txtCPF.Text.Length;
            }
            
        }

        string data;
        private void DataCriacao_Tick(object sender, EventArgs e)
        {
            data = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no número de telefone
            string telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            // Verificar se o número de telefone possui 10 ou 11 dígitos
            if (telefone.Length == 11)
            {
                // Formatar o número de telefone no formato (xx) xxxxx-xxxx
                string formattedTelefone = "";

                if (telefone.Length == 11)
                {
                    formattedTelefone = string.Format("({0}) {1}-{2}",
                        telefone.Substring(0, 2),
                        telefone.Substring(2, 5),
                        telefone.Substring(7, 4));
                }

                // Atualizar o texto selecionado da TextBox com o número de telefone formatado
                txtTelefone.Text = formattedTelefone;
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }

            if (txtTelefone.Text.Length > 15)
            {
                txtTelefone.Text = txtTelefone.Text.Substring(0, 15);
                txtTelefone.SelectionStart = txtTelefone.Text.Length;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
