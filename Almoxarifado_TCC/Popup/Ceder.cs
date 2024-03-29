﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;// Usado para o DllImport
using MySql.Data.MySqlClient;
using System.Windows.Markup;

namespace Almoxarifado_TCC.Popup
{
    public partial class Ceder : Form
    {
        string nome_usu, cpf, hora, data;
        int cod_item, cod_usu, quantAt, quantTt, quant;

        public Ceder(int cod)
        {
            cod_item = cod;
            InitializeComponent();
            Hora_Ceder.Start();
        }

        #region Visuais

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReliaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconBox_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Ceder_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconChave_MouseDown(object sender, MouseEventArgs e)
        {
            ReliaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            if (txtCpf.Text == "CPF")
            {
                txtCpf.Text = "";
                lblCPF.Visible = true;
            }
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                txtCpf.Text = "CPF";
                lblCPF.Visible = false;
            }
        }


        #endregion

        public void reset() {

            ClassConexao con = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao = con.getConexao();
            string consulta = "SELECT nome_usuario as Nome from tb_usuario where stats = 'Ativo'";
            //Monta meu comando sql
            MySqlCommand commando = new MySqlCommand(consulta, conexao);
            conexao.Open();//Abro minha conexao
            //monto a tabela de dados
            MySqlDataAdapter dados = new MySqlDataAdapter(commando);
            //Crio uma nova tabela de dados
            DataTable dtUsu = new DataTable();
            dados.Fill(dtUsu);//manipulação dos dados
            dgvUsuario.DataSource = dtUsu;//chamo o caminho dos dados

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaPrincipal.CurrentInstance.Popups_Fechar();
            this.Close();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            // Remover qualquer formatação existente no CPF
            string cpf = txtCpf.Text.Replace(".", "").Replace("-", "");

            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length == 11)
            {
                // Formatar o CPF com os pontos e o traço
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9)}";

                // Atualizar o texto da TextBox com o CPF formatado
                txtCpf.Text = cpf;

                txtCpf.SelectionStart = txtCpf.Text.Length;
            }

            if (txtCpf.Text.Length > 14)
            {
                txtCpf.Text = txtCpf.Text.Substring(0, 14);
                txtCpf.SelectionStart = txtCpf.Text.Length;
            }
        }

        private void Ceder_Load(object sender, EventArgs e)
        {
            reset();

            ClassConexao con1 = new ClassConexao();
            //obtive a conexao
            MySqlConnection conexao1 = con1.getConexao();
            String consulta1 = "";
            conexao1.Open();//Abro minha conexao
            consulta1 = "SELECT quant from tb_item where id_item='" + cod_item + "'";

            //Monta meu comando sql
            MySqlCommand commando1 = new MySqlCommand(consulta1, conexao1);
            MySqlDataReader registro = commando1.ExecuteReader();
            registro.Read();

            lblQuantTotal.Text = Convert.ToString(registro["quant"]);
            quantTt = Convert.ToInt32(registro["quant"]);

            conexao1.Close();

            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(56, 60, 71);
            dgvUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(27, 30, 36);
            dgvUsuario.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuario.BackgroundColor = Color.FromArgb(39, 43, 52);

            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 43, 52);
            dgvUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) + 1;          

            if (txtQuant.Text == lblQuantTotal.Text) { 
 
            }
            else
            {
                txtQuant.Text = valoradd.ToString();
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int valoradd = Convert.ToInt32(txtQuant.Text) - 1;
            txtQuant.Text = valoradd.ToString();

            if (Convert.ToInt32(txtQuant.Text) <= 0)
            {
                txtQuant.Text = "0";
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCpf.Text != "CPF" && txtCpf.Text != "")
            {
                ClassConexao con = new ClassConexao();
                //obtive a conexao
                MySqlConnection conexao = con.getConexao();
                String consulta = "";

                consulta = "SELECT nome_usuario as Nome from tb_usuario where cpf ='" + txtCpf.Text + "'";

                //Monta meu comando sql
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();//Abro minha conexao
                //monto a tabela de dados
                MySqlDataAdapter dados = new MySqlDataAdapter(commando);
                //Crio uma nova tabela de dados
                DataTable dtUsu = new DataTable();
                dados.Fill(dtUsu);//manipulação dos dados
                dgvUsuario.DataSource = dtUsu;//chamo o caminho dos dados
            }

            else if (e.KeyCode == Keys.Enter && txtCpf.Text != "CPF" && txtCpf.Text == "")
            {
                reset();
            }
        }

        private void Hora_Ceder_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm");
            data = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnCeder_Click(object sender, EventArgs e)
        {
            if (nome_usu == null)
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "CPF em branco";
                iconAviso.Location = new Point(42, 126);
                lblAviso.Location = new Point(67, 130);
            }

            else if (txtQuant.Text == "0")
            {
                iconAviso.Visible = true;
                lblAviso.Visible = true;
                lblAviso.Text = "Defina uma quantidade";
                iconAviso.Location = new Point(27, 126);
                lblAviso.Location = new Point(52, 130);
            }

            else
            {
                if (cbxNdevolver.Checked == false)
                {
                    quantAt = Convert.ToInt32(txtQuant.Text);
                    quant = quantTt - quantAt;

                    ClassConexao con = new ClassConexao();
                    MySqlConnection conexao = con.getConexao();
                    string sql = "insert into tb_emp_item(id_item, id_usuario, quant, hora_emp, data_emp) values" + "('" + cod_item + "','" + cod_usu + "','" + quantAt + "','" + hora + "','" + data + "')";
                    conexao.Open();
                    MySqlCommand command = new MySqlCommand(sql, conexao);
                    MySqlDataReader registro = command.ExecuteReader();
                    registro.Read();
                    conexao.Close();

                    ClassConexao con1 = new ClassConexao();
                    MySqlConnection conexao1 = con1.getConexao();
                    string sql1 = "UPDATE tb_item SET quant = @quant WHERE id_item = " + cod_item + ";";
                    MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
                    command1.Parameters.AddWithValue("@quant", quant);
                    conexao1.Open();
                    command1.ExecuteNonQuery();
                    conexao1.Close();

                    TelaPrincipal.CurrentInstance.Popups_Fechar();
                    Popup.Estoque.CurrentInstance.reset();
                    this.Close();
                }

                else if (cbxNdevolver.Checked == true)
                {
                    quantAt = Convert.ToInt32(txtQuant.Text);
                    quant = quantTt - quantAt;

                    ClassConexao con = new ClassConexao();
                    MySqlConnection conexao = con.getConexao();
                    string sql = "insert into tb_emp_item(id_item, id_usuario, quant, hora_emp, hora_dev, data_emp, data_dev, obs) values" + "('" + cod_item + "','" + cod_usu + "','" + quantAt + "','" + hora + "','" + "00:00:00" + "','" + data + "','" + "00/00/0000" + "','" + "Não necessita de devolução" + "')";
                    conexao.Open();
                    MySqlCommand command = new MySqlCommand(sql, conexao);
                    MySqlDataReader registro = command.ExecuteReader();
                    registro.Read();
                    conexao.Close();

                    ClassConexao con1 = new ClassConexao();
                    MySqlConnection conexao1 = con1.getConexao();
                    string sql1 = "UPDATE tb_item SET quant = @quant WHERE id_item = " + cod_item + ";";
                    MySqlCommand command1 = new MySqlCommand(sql1, conexao1);
                    command1.Parameters.AddWithValue("@quant", quant);
                    conexao1.Open();
                    command1.ExecuteNonQuery();
                    conexao1.Close();

                    TelaPrincipal.CurrentInstance.Popups_Fechar();
                    Popup.Estoque.CurrentInstance.reset();
                    this.Close();
                }

            }
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                //aguarda o codigo da linha selecionada
                nome_usu = Convert.ToString(dgvUsuario.Rows[e.RowIndex].Cells[0].Value);

                ClassConexao con = new ClassConexao();
                MySqlConnection conexao = con.getConexao();
                String consulta = "";
                consulta = "SELECT id_usuario, cpf from tb_usuario where nome_usuario ='" + nome_usu + "'";
                MySqlCommand commando = new MySqlCommand(consulta, conexao);
                conexao.Open();
                MySqlDataReader registro = commando.ExecuteReader();
                registro.Read();
                cod_usu = Convert.ToInt32(registro["id_usuario"]);
                cpf = Convert.ToString(registro["cpf"]);
                conexao.Close();
                txtCpf.Text = cpf;
        }
    }
}
