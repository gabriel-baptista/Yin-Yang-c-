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
using TG.Telas_Cliente;

namespace TG
{
    public partial class Principal_Cliente : Form
    {
        string Nome_Cliente, Id_Cliente, user_cliente1;
        public Principal_Cliente(string user_cliente, string Nome, string senha, string id)
        {
            InitializeComponent();
            Nome_Cliente = Nome;
            user_cliente1 = user_cliente;
            lbl_senha.Text = senha;
            Id_Cliente = id;
        }

        public Principal_Cliente()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Cliente consulta_Cliente = new Consulta_Cliente(Nome_Cliente,lbl_senha.Text,Id_Cliente);
            consulta_Cliente.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void Principal_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_id_cliente_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void btn_Perfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterar_Senha alterar_Senha = new Alterar_Senha(user_cliente1,lbl_senha.Text,Id_Cliente);
            alterar_Senha.ShowDialog();
            this.Dispose();
        }

        private void lbl_nome_cliente_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Texto_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void tb_sexo_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_cpf_cliente_Click(object sender, EventArgs e)
        {

        }

        private void lbl_sexo_Click(object sender, EventArgs e)
        {

        }

        private void tb_peso_inicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_peso_inicial_Click(object sender, EventArgs e)
        {

        }

        private void tb_cpf_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString();
            lbl_Data.Text = DateTime.Now.ToLongDateString();
        }

        private void lbl_Data_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_MeuPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Cliente perfil_Cliente = new Perfil_Cliente(user_cliente1, lbl_senha.Text, Id_Cliente);
            perfil_Cliente.ShowDialog();
            this.Dispose();
        }

        private void Entrar_Click(object sender, EventArgs e)
        { 
          
        }
    }
}
