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
    public partial class Mostrar_Perfil : Form
    {
        string CPFBD, cpf_Digitado, sexo_cliente;
        int sex;

        public Mostrar_Perfil()
        {
            InitializeComponent();
        }
        public Mostrar_Perfil(string Nome) : this()
        {
            //lbl_nome.Text = Nome;
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
        private void Mostrar_Perfil_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrarCliente = new Cadastrar_Cliente();
            cadastrarCliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrarUsuários = new Cadastrar_Usuario();
            cadastrarUsuários.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            sex = cb_sexo_cliente.SelectedIndex;

            if (sex == 0)
            {
                sexo_cliente = "Masculino";
            }
            else if (sex == 1)
            {
                sexo_cliente = "Feminino";
            }
            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                conexão.Open();
                MySqlCommand Comando = new MySqlCommand("UPDATE cliente set nome_cliente = '" + tb_nome_cliente.Text + "', idade_cliente = '" + tb_idade_cliente.Text + "', sexo_cliente = '"+sexo_cliente+"',peso_cliente = '"+tb_peso_inicial.Text+"', peso_atual = '"+tb_peso_atual.Text+"', massa_magra = '"+tb_massa_magra.Text+"', massa_gorda ='"+tb_massa_gorda.Text+"', cpf_cliente = '"+tb_cpf_cliente.Text+"'  where cpf_cliente = '" + cpf_Digitado + "'", conexão);

                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();

                conexão.Close();
                MessageBox.Show("Atualizado com Sucesso!");    
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

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painel_Alteracoes);
        }

        private void btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Alteracoes_Cliente = new Perfil_Paciente_Nutri();
            Alteracoes_Cliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnAgendarConsultas_Click(object sender, EventArgs e)
        {
        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
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

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void btn_PesquisarCliente_Click_1(object sender, EventArgs e)
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
                            cb_sexo_cliente.Text = dr.GetString("sexo_cliente");
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
    }
}
