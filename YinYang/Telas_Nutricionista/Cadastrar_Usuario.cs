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
using TG.Telas_Nutricionista;

namespace TG
{
    public partial class Cadastrar_Usuario : Form
    {
        public void conexão_BancoDeDados()
        {
            
        }

        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }
        public Cadastrar_Usuario(string Nome) : this()
        {
            //lbl_nome.Text = Nome;
        }
        private void DesignPaineis()
        {
            painelPossiveisCadastros.Visible = false;
            painel_Alteracoes.Visible = false;
        }
        private void EsconderMenu()
        {
            if (painelPossiveisCadastros.Visible == true)
                painelPossiveisCadastros.Visible = false;
            if (painel_Alteracoes.Visible == true)
                painel_Alteracoes.Visible = false;
        }
        private void MostrarMenu(Panel painelPossiveisCadastros)
        {
            if (painelPossiveisCadastros.Visible == false)
            {
                EsconderMenu();
                painelPossiveisCadastros.Visible = true;
            }
            else
            {
                painelPossiveisCadastros.Visible = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarUsuários_Load(object sender, EventArgs e)
        {

        }

        private void tb_nivel_acesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastro_Click(object sender, EventArgs e)
        {
            int senha_confirmada=0;

            if (tb_nome.Text == "" || tb_login.Text == "" || tb_senha.Text == "" || tb_senha_confirmada.Text == "")
            {
                MessageBox.Show("Complete os Campos Corretamente!");
            }
            else
            {
                if (tb_senha_confirmada.Text == tb_senha.Text)
                {
                    senha_confirmada = 1;
                }
                else
                {
                    MessageBox.Show("As Senhas não Correspondem!");
                }
            }
            if (senha_confirmada == 1)
            {
                string nivel_acesso = "nutricionista";
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                    MySqlCommand Comando = new MySqlCommand("INSERT into usuarios (nome_usuario, login_usuario, senha_usuario, nivel_acesso) values (?,?,?,?) ", conexão);
                    conexão.Open();


                    Comando.Parameters.Add("@nome_usuario", MySqlDbType.VarChar).Value = tb_nome.Text;
                    Comando.Parameters.Add("@login_usuario", MySqlDbType.VarChar).Value = tb_login.Text;
                    Comando.Parameters.Add("@senha_usuario", MySqlDbType.VarChar).Value = tb_senha.Text;
                    Comando.Parameters.Add("@nivel_acesso", MySqlDbType.VarChar).Value = nivel_acesso;
                        
                    Comando.ExecuteNonQuery();

                    conexão.Close();
                    MessageBox.Show("Cadastro Feito com Sucesso!");
                }
                catch(MySqlException exx)
                {
                    MessageBox.Show(exx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
           
        }

        private void tb_nome_Enter(object sender, EventArgs e)
        {
          
        }

        private void tb_nome_Leave(object sender, EventArgs e)
        {
          
        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_login_Leave(object sender, EventArgs e)
        {
     
        }

        private void tb_login_Enter(object sender, EventArgs e)
        {

        }

        private void tb_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_senha_Enter(object sender, EventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_senha_Leave(object sender, EventArgs e)
        {

        }

        private void tb_senha_confirmada_Enter(object sender, EventArgs e)
        {
 
        }

        private void tb_senha_confirmada_Leave(object sender, EventArgs e)
        { 
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrarCliente = new Cadastrar_Cliente();
            cadastrarCliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
           MostrarMenu(painel_Alteracoes);
        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Alteracoes_Cliente = new Perfil_Paciente_Nutri();
            Alteracoes_Cliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info_Paciente = new Mostrar_Perfil();
            Atualizar_Info_Paciente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnAgendarConsultas_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_VisualizarConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizar_Consultas visualizar_Consultas = new Visualizar_Consultas();
            visualizar_Consultas.ShowDialog();
            this.Dispose();
        }

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plano_Alimentar plano_Alimentar = new Plano_Alimentar();
            plano_Alimentar.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void tb_senha_confirmada_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
