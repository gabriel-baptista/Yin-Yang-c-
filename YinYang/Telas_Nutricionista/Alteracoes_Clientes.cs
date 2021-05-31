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

namespace TG
{
    public partial class Perfil_Paciente_Nutri : Form
    {
        string CPFBD, cpf_Digitado;
        public Perfil_Paciente_Nutri()
        {
            InitializeComponent();
        }
        private void DesignPaineis()
        {
            painelPossiveisCadastros.Visible = false;
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista Tela_principal = new Principal_Nutricionista();
            Tela_principal.ShowDialog();
            this.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Close();

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            cpf_Digitado = tb_cpf.Text;
            if (cpf_Digitado == "")
            {
                MessageBox.Show("Por favor Preencha o Campo Corretamente");
            }
            else
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("SELECT * FROM cliente", conexão);
                    conexão.Open();

                    Comando.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        CPFBD = dr.GetString("cpf_cliente");
                        if (cpf_Digitado == CPFBD)
                        {
                            tb_id_cliente.Text = dr.GetString("cliente_id");
                            tb_peso_inicial.Text = dr.GetString("peso_cliente");
                            tb_massa_magra.Text = dr.GetString("massa_magra");
                            tb_massa_gorda.Text = dr.GetString("massa_gorda");
                            tb_idade_cliente.Text = dr.GetString("idade_cliente");
                            tb_sexo_cliente.Text = dr.GetString("sexo_cliente");
                            tb_peso_atual.Text = dr.GetString("peso_atual");
                            tb_cpf_cliente.Text = dr.GetString("cpf_cliente");
                            tb_nome_cliente.Text = dr.GetString("nome_cliente");
                        }
                    }
                    conexão.Close();
                }
                catch (MySqlException exx)
                {
                    MessageBox.Show("Problemas com Banco de Dados", exx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void Perfil_Paciente_Nutri_Load(object sender, EventArgs e)
        {

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

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrarUsuários = new Cadastrar_Usuario();
            cadastrarUsuários.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painel_Alteracoes);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void painel_Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info_Paciente = new Mostrar_Perfil();
            Atualizar_Info_Paciente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void btnAgendarConsultas_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            cpf_Digitado = tb_cpf.Text;
            if (cpf_Digitado == "")
            {
                MessageBox.Show("Por favor Preencha o Campo Corretamente!");
            }
            else
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("DELETE from cliente WHERE cpf_cliente ='" + cpf_Digitado + "'", conexão);
                    conexão.Open();
                    Comando.ExecuteNonQuery();

                    conexão.Close();
                    MessageBox.Show("Usúário Excluído com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
