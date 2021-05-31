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

namespace TG.Telas_Nutricionista
{
    public partial class Plano_Alimentar : Form
    {
        string opcao1, opcao2, opcao3, opcao4, opcao5, opcao6, opcao7, opcao8, opcao9, opcao10, opcao11, opcao12, opcao13, opcao14, opcao15, Id_Paciente, Id_PacienteDB, Paciente, Cpf_Paciente, Idade_Paciente, Sexo_Paciente, Usuario;

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario();
            cadastrar_Usuario.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {

        }

        private void Pb_Pesquisa_Click(object sender, EventArgs e)
        {
            if (tb_Pesquisa.Text == "")
            {
                MessageBox.Show("Por Favor Preencha o Campo de Pesquisa Digitando o nome do Cliente!");
            }
            else
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("SELECT * FROM `cliente`", conexão);
                    conexão.Open();

                    MySqlDataReader dr;
                    dr = Comando.ExecuteReader();
                    while (dr.Read())
                    {
                        Paciente = dr.GetString("nome_cliente");
                        if (tb_Pesquisa.Text == Paciente)
                        {
                            Grid_Clientes.Rows.Clear();
                            Id_Paciente = dr.GetString("cliente_id");
                            Paciente = dr.GetString("nome_cliente");
                            Usuario = dr.GetString("user_cliente");
                            Cpf_Paciente = dr.GetString("cpf_cliente");
                            Idade_Paciente = dr.GetString("idade_cliente");
                            Sexo_Paciente = dr.GetString("sexo_cliente");

                            int n = Grid_Clientes.Rows.Add();

                            Grid_Clientes.Rows[n].Cells[0].Value = Id_Paciente;
                            Grid_Clientes.Rows[n].Cells[1].Value = Usuario;
                            Grid_Clientes.Rows[n].Cells[2].Value = Paciente;
                            Grid_Clientes.Rows[n].Cells[3].Value = Cpf_Paciente;
                            Grid_Clientes.Rows[n].Cells[4].Value = Idade_Paciente;
                            Grid_Clientes.Rows[n].Cells[5].Value = Sexo_Paciente;
                        }
                    }
                }
                catch (MySqlException exx)
                {
                    MessageBox.Show("Problemas com o Banco de Dados", exx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrar_Cliente = new Cadastrar_Cliente();
            cadastrar_Cliente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btn_Alteracoes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Excluir_Paciente = new Perfil_Paciente_Nutri();
            Excluir_Paciente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void DesignPaineis()
        {
            painelPossiveisCadastros.Visible = false;
            painelAlteracoes.Visible = false;
        }
        private void EsconderMenu()
        {
            if (painelPossiveisCadastros.Visible == true)
                painelPossiveisCadastros.Visible = false;
            if (painelAlteracoes.Visible == true)
                painelAlteracoes.Visible = false;
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

        private void btn_AlterarInfoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Perfil = new Mostrar_Perfil();
            Atualizar_Perfil.ShowDialog();
            this.Hide();
            EsconderMenu();
        }

        private void btn_VisualizarConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizar_Consultas visualizar_Consultas = new Visualizar_Consultas();
            visualizar_Consultas.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void Grid_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Comandos para armazenar dados das Colunas e Linhas que o Usuário deu DoubleClick
            if (Grid_Clientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Grid_Clientes.CurrentCell.Selected = true;
                Id_Paciente = Grid_Clientes.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Usuario = Grid_Clientes.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                Paciente = Grid_Clientes.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }

            //Select Na Tabela Desjejum, Almoço, Lanche da Tarde, Jantar e Ceia
            try
            {
                MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando1 = new MySqlCommand("SELECT * from desjejum", conexão1);
                conexão1.Open();

                MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando2 = new MySqlCommand("SELECT * from almoco", conexão2);
                conexão2.Open();

                MySqlConnection conexão3 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando3 = new MySqlCommand("SELECT * from lanchetarde", conexão3);
                conexão3.Open();

                MySqlConnection conexão4 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando4 = new MySqlCommand("SELECT * from jantar", conexão4);
                conexão4.Open();

                MySqlConnection conexão5 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando5 = new MySqlCommand("SELECT * from ceia", conexão5);
                conexão5.Open();

                MySqlDataReader dr1;
                dr1 = Comando1.ExecuteReader();

                MySqlDataReader dr2;
                dr2 = Comando2.ExecuteReader();

                MySqlDataReader dr3;
                dr3 = Comando3.ExecuteReader();

                MySqlDataReader dr4;
                dr4 = Comando4.ExecuteReader();

                MySqlDataReader dr5;
                dr5 = Comando5.ExecuteReader();

                Grid_PlanoAlimentar.Rows.Clear();

                while (dr1.Read())
                {
                    Id_PacienteDB = dr1.GetString("id_cliente");
                    if (Id_PacienteDB == Id_Paciente)
                    {
                        opcao1 = dr1.GetString("opcao1");
                        opcao2 = dr1.GetString("opcao2");
                        opcao3 = dr1.GetString("opcao3");

                        int n1 = Grid_PlanoAlimentar.Rows.Add();

                        Grid_PlanoAlimentar.Rows[n1].Cells[0].Value = opcao1;
                        Grid_PlanoAlimentar.Rows[n1].Cells[1].Value = opcao2;
                        Grid_PlanoAlimentar.Rows[n1].Cells[2].Value = opcao3;
                    }
                }
                conexão1.Close();

                while (dr2.Read())
                {
                    Id_PacienteDB = dr2.GetString("id_cliente");
                    if (Id_PacienteDB == Id_Paciente)
                    {
                        opcao4 = dr2.GetString("opcao1");
                        opcao5 = dr2.GetString("opcao2");
                        opcao6 = dr2.GetString("opcao3");

                        int n2 = Grid_PlanoAlimentar.Rows.Add();

                        Grid_PlanoAlimentar.Rows[n2].Cells[0].Value = opcao4;
                        Grid_PlanoAlimentar.Rows[n2].Cells[1].Value = opcao5;
                        Grid_PlanoAlimentar.Rows[n2].Cells[2].Value = opcao6;
                    }
                }
                conexão2.Close();

                while (dr3.Read())
                {
                    Id_PacienteDB = dr3.GetString("id_cliente");
                    if (Id_PacienteDB == Id_Paciente)
                    {
                        opcao7 = dr3.GetString("opcao1");
                        opcao8 = dr3.GetString("opcao2");
                        opcao9 = dr3.GetString("opcao3");

                        int n3 = Grid_PlanoAlimentar.Rows.Add();

                        Grid_PlanoAlimentar.Rows[n3].Cells[0].Value = opcao7;
                        Grid_PlanoAlimentar.Rows[n3].Cells[1].Value = opcao8;
                        Grid_PlanoAlimentar.Rows[n3].Cells[2].Value = opcao9;
                    }
                }
                conexão3.Close();

                while (dr4.Read())
                {
                    Id_PacienteDB = dr4.GetString("id_cliente");
                    if (Id_PacienteDB == Id_Paciente)
                    {
                        opcao10 = dr4.GetString("opcao1");
                        opcao11 = dr4.GetString("opcao2");
                        opcao12 = dr4.GetString("opcao3");

                        int n4 = Grid_PlanoAlimentar.Rows.Add();

                        Grid_PlanoAlimentar.Rows[n4].Cells[0].Value = opcao10;
                        Grid_PlanoAlimentar.Rows[n4].Cells[1].Value = opcao11;
                        Grid_PlanoAlimentar.Rows[n4].Cells[2].Value = opcao12;
                    }
                }
                conexão4.Close();

                while (dr5.Read())
                {
                    Id_PacienteDB = dr5.GetString("id_cliente");
                    if (Id_PacienteDB == Id_Paciente)
                    {
                        opcao13 = dr5.GetString("opcao1");
                        opcao14 = dr5.GetString("opcao2");
                        opcao15 = dr5.GetString("opcao3");

                        int n5 = Grid_PlanoAlimentar.Rows.Add();

                        Grid_PlanoAlimentar.Rows[n5].Cells[0].Value = opcao13;
                        Grid_PlanoAlimentar.Rows[n5].Cells[1].Value = opcao14;
                        Grid_PlanoAlimentar.Rows[n5].Cells[2].Value = opcao15;
                    }
                }
                conexão5.Close();
            }
            catch (MySqlException exx)
            {
                MessageBox.Show("Problemas com o Banco de Dados!", exx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public Plano_Alimentar()
        {
            InitializeComponent();
        }

        private void Grid_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
          
        }

        private void Plano_Alimentar_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM `cliente` ORDER BY `nome_cliente`", conexão);
                conexão.Open();

                MySqlDataReader dr;
                dr = Comando.ExecuteReader();
                while (dr.Read())
                {
                    Id_Paciente = dr.GetString("cliente_id");
                    Paciente = dr.GetString("nome_cliente");
                    Usuario = dr.GetString("user_cliente");
                    Cpf_Paciente = dr.GetString("cpf_cliente");
                    Idade_Paciente = dr.GetString("idade_cliente");
                    Sexo_Paciente = dr.GetString("sexo_cliente");

                    int n = Grid_Clientes.Rows.Add();

                    Grid_Clientes.Rows[n].Cells[0].Value = Id_Paciente;
                    Grid_Clientes.Rows[n].Cells[1].Value = Usuario;
                    Grid_Clientes.Rows[n].Cells[2].Value = Paciente;
                    Grid_Clientes.Rows[n].Cells[3].Value = Cpf_Paciente;
                    Grid_Clientes.Rows[n].Cells[4].Value = Idade_Paciente;
                    Grid_Clientes.Rows[n].Cells[5].Value = Sexo_Paciente;
                }
            }
            catch (MySqlException exx)
            {
                MessageBox.Show("Problemas com o Banco de Dados", exx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_PlanoAlimentar cadastrar_PlanoAlimentar = new Cadastrar_PlanoAlimentar();
            cadastrar_PlanoAlimentar.ShowDialog();
            this.Dispose();
        }

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
           
        }
        private void Grid_PlanoAlimentar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
