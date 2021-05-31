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
    public partial class Cad_PlanoAlimentar : Form
    {
        string Sexo_Paciente, Idade_Paciente, Cpf_Paciente, Paciente, Id_Paciente, Id_PacienteDB, Usuario, opcao1, opcao2, opcao3, opcao4, opcao5, opcao6, opcao7, opcao8, opcao9, opcao10, opcao11, opcao12, opcao13, opcao14, opcao15;

        private void btn_CadastrarPA_Click(object sender, EventArgs e)
        {
            ArmazenandoVariaveis();
            try
            {
                MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando1 = new MySqlCommand("SELECT Id_Cliente from desjejum where id_cliente = '" + Id_Paciente + "'", conexão1);
                conexão1.Open();

                MySqlDataReader dr1;
                dr1 = Comando1.ExecuteReader();

                while (dr1.Read())
                {
                    Id_PacienteDB = dr1.GetString("id_cliente");
                }
                if (Id_Paciente == Id_PacienteDB == false)
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                    MySqlCommand Comando = new MySqlCommand("INSERT INTO desjejum (opcao1,opcao2,opcao3,id_cliente) values ('" + opcao1 + "','" + opcao2 + "'," +
                        "'" + opcao3 + "','" + Id_Paciente + "'); INSERT INTO almoco(opcao1,opcao2,opcao3,id_cliente) values ('" + opcao4 + "','" + opcao5 + "','" + opcao6 + "','" + Id_Paciente + "'); INSERT INTO lanchetarde(opcao1,opcao2,opcao3,id_cliente) values " +
                        "('" + opcao7 + "','" + opcao8 + "','" + opcao9 + "','" + Id_Paciente + "'); INSERT INTO jantar(opcao1,opcao2,opcao3,id_cliente) values ('" + opcao10 + "','" + opcao11 + "','" + opcao12 + "','" + Id_Paciente + "');" +
                        "INSERT INTO ceia (opcao1,opcao2,opcao3,id_cliente) values ('" + opcao13 + "','" + opcao14 + "','" + opcao15 + "','" + Id_Paciente + "');", conexão);
                    conexão.Open();

                    Comando.ExecuteNonQuery();
                    MessageBox.Show("Plano Alimentar Cadastrado Com Sucesso!");
                    conexão.Close();
                }
                else if (Id_Paciente == Id_PacienteDB == true)
                {
                    MessageBox.Show("Esse Usuário Já Possui Um Plano Alimentar Cadastrado!");
                }
                conexão1.Close();
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

        private void btn_AtualizarPA_Click(object sender, EventArgs e)
        {
            ArmazenandoVariaveis();
            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando = new MySqlCommand("UPDATE desjejum set opcao1 = '" + opcao1 + "', opcao2 = '" + opcao2 + "', opcao3 = '" + opcao3 + "' where id_cliente = '" + Id_Paciente + "'", conexão);
                conexão.Open();

                MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando1 = new MySqlCommand("UPDATE almoco set opcao1 = '" + opcao4 + "', opcao2 = '" + opcao5 + "', opcao3 = '" + opcao6 + "' where id_cliente = '" + Id_Paciente + "'", conexão1);
                conexão1.Open();

                MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando2 = new MySqlCommand("UPDATE lanchetarde set opcao1 = '" + opcao7 + "', opcao2 = '" + opcao8 + "', opcao3 = '" + opcao9 + "' where id_cliente = '" + Id_Paciente + "'", conexão2);
                conexão2.Open();

                MySqlConnection conexão3 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando3 = new MySqlCommand("UPDATE jantar set opcao1 = '" + opcao10 + "', opcao2 = '" + opcao11 + "', opcao3 = '" + opcao12 + "' where id_cliente = '" + Id_Paciente + "'", conexão3);
                conexão3.Open();

                MySqlConnection conexão4 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando4 = new MySqlCommand("UPDATE ceia set opcao1 = '" + opcao13 + "', opcao2 = '" + opcao14 + "', opcao3 = '" + opcao15 + "' where id_cliente = '" + Id_Paciente + "'", conexão4);
                conexão4.Open();

                Comando.CommandType = CommandType.Text;
                Comando.ExecuteNonQuery();

                Comando1.CommandType = CommandType.Text;
                Comando1.ExecuteNonQuery();

                Comando2.CommandType = CommandType.Text;
                Comando2.ExecuteNonQuery();

                Comando3.CommandType = CommandType.Text;
                Comando3.ExecuteNonQuery();

                Comando4.CommandType = CommandType.Text;
                Comando4.ExecuteNonQuery();


                conexão.Close();
                conexão1.Close();
                conexão2.Close();
                conexão3.Close();
                conexão4.Close();
                MessageBox.Show("Plano Alimentar Atualizado com Sucesso!");
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

        private void Grid_ClientesPlano_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Comandos para armazenar dados das Colunas e Linhas que o Usuário deu DoubleClick
            if (Grid_ClientesPlano.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Grid_ClientesPlano.CurrentCell.Selected = true;
                Id_Paciente = Grid_ClientesPlano.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Usuario = Grid_ClientesPlano.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                Paciente = Grid_ClientesPlano.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }

        private void ArmazenandoVariaveis()
        {
            //Pegando tudo que Foi Digitado no DataGridView e Armazenando em suas respectivas Variáveis
            opcao1 = Grid_PlanoAlimentar.Rows[0].Cells["Column4"].Value.ToString();
            opcao2 = Grid_PlanoAlimentar.Rows[0].Cells["Column3"].Value.ToString();
            opcao3 = Grid_PlanoAlimentar.Rows[0].Cells["Column2"].Value.ToString();

            opcao4 = Grid_PlanoAlimentar.Rows[1].Cells["Column4"].Value.ToString();
            opcao5 = Grid_PlanoAlimentar.Rows[1].Cells["Column3"].Value.ToString();
            opcao6 = Grid_PlanoAlimentar.Rows[1].Cells["Column2"].Value.ToString();

            opcao7 = Grid_PlanoAlimentar.Rows[2].Cells["Column4"].Value.ToString();
            opcao8 = Grid_PlanoAlimentar.Rows[2].Cells["Column3"].Value.ToString();
            opcao9 = Grid_PlanoAlimentar.Rows[2].Cells["Column2"].Value.ToString();

            opcao10 = Grid_PlanoAlimentar.Rows[3].Cells["Column4"].Value.ToString();
            opcao11 = Grid_PlanoAlimentar.Rows[3].Cells["Column3"].Value.ToString();
            opcao12 = Grid_PlanoAlimentar.Rows[3].Cells["Column2"].Value.ToString();

            opcao13 = Grid_PlanoAlimentar.Rows[4].Cells["Column4"].Value.ToString();
            opcao14 = Grid_PlanoAlimentar.Rows[4].Cells["Column3"].Value.ToString();
            opcao15 = Grid_PlanoAlimentar.Rows[4].Cells["Column2"].Value.ToString();
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

        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btn_Alteracoes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrar_Cliente = new Cadastrar_Cliente();
            cadastrar_Cliente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario();
            cadastrar_Usuario.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_ExcluirCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Excluir_Cliente = new Perfil_Paciente_Nutri();
            Excluir_Cliente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_AlterarInfoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info = new Mostrar_Perfil();
            Atualizar_Info.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plano_Alimentar plano_Alimentar = new Plano_Alimentar();
            plano_Alimentar.ShowDialog();
            this.Dispose();
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

        public Cad_PlanoAlimentar()
        {
            InitializeComponent();
        }

        private void Cad_PlanoAlimentar_Load(object sender, EventArgs e)
        {
            int n = Grid_PlanoAlimentar.Rows.Add();
            int n1 = Grid_PlanoAlimentar.Rows.Add();
            int n2 = Grid_PlanoAlimentar.Rows.Add();
            int n3 = Grid_PlanoAlimentar.Rows.Add();
            int n4 = Grid_PlanoAlimentar.Rows.Add();

            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM `cliente` ORDER BY `nome_cliente`", conexão);
                conexão.Open();

                MySqlDataReader dr;
                dr = Comando.ExecuteReader();
                while (dr.Read())
                {
                    //Dados Recebidos do Banco de Dados
                    Id_Paciente = dr.GetString("cliente_id");
                    Paciente = dr.GetString("nome_cliente");
                    Usuario = dr.GetString("user_cliente");
                    Cpf_Paciente = dr.GetString("cpf_cliente");
                    Idade_Paciente = dr.GetString("idade_cliente");
                    Sexo_Paciente = dr.GetString("sexo_cliente");

                    //Criando Coluna no DataGriedView e setando os valores das colunas e linhas de acordo com os dados recebidos do Banco de Dados
                    int nc = Grid_ClientesPlano.Rows.Add();

                    Grid_ClientesPlano.Rows[nc].Cells[0].Value = Id_Paciente;
                    Grid_ClientesPlano.Rows[nc].Cells[1].Value = Usuario;
                    Grid_ClientesPlano.Rows[nc].Cells[2].Value = Paciente;
                    Grid_ClientesPlano.Rows[nc].Cells[3].Value = Cpf_Paciente;
                    Grid_ClientesPlano.Rows[nc].Cells[4].Value = Idade_Paciente;
                    Grid_ClientesPlano.Rows[nc].Cells[5].Value = Sexo_Paciente;
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
}
