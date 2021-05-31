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
    public partial class Cadastrar_PlanoAlimentar : Form
    {
        string Sexo_Paciente, Idade_Paciente, Cpf_Paciente, Paciente, Id_Paciente, Id_PacienteDB, Usuario, opcao1, opcao2, opcao3, opcao4, opcao5, opcao6, opcao7, opcao8, opcao9, opcao10, opcao11, opcao12, opcao13, opcao14, opcao15;
        double status=0;

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plano_Alimentar plano_Alimentar = new Plano_Alimentar();
            plano_Alimentar.ShowDialog();
            this.Dispose();
        }

        private void Grid_PlanoAlimentar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
                            //Limpando Colunas do DataGridView
                            Grid_ClientesCPA.Rows.Clear();

                            //Armazenando Variáveis do Banco em Strings
                            Id_Paciente = dr.GetString("cliente_id");
                            Paciente = dr.GetString("nome_cliente");
                            Usuario = dr.GetString("user_cliente");
                            Cpf_Paciente = dr.GetString("cpf_cliente");
                            Idade_Paciente = dr.GetString("idade_cliente");
                            Sexo_Paciente = dr.GetString("sexo_cliente");

                            //Criando coluna por coluna e setando seus valores com as Strings que vão sendo recebidas acima
                            int n = Grid_ClientesCPA.Rows.Add();

                            Grid_ClientesCPA.Rows[n].Cells[0].Value = Id_Paciente;
                            Grid_ClientesCPA.Rows[n].Cells[1].Value = Usuario;
                            Grid_ClientesCPA.Rows[n].Cells[2].Value = Paciente;
                            Grid_ClientesCPA.Rows[n].Cells[3].Value = Cpf_Paciente;
                            Grid_ClientesCPA.Rows[n].Cells[4].Value = Idade_Paciente;
                            Grid_ClientesCPA.Rows[n].Cells[5].Value = Sexo_Paciente;
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

        private void btn_VisualizarConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizar_Consultas visualizar_Consultas = new Visualizar_Consultas();
            visualizar_Consultas.ShowDialog();
            this.Dispose();
        }

        private void btn_AlterarInfoCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info = new Mostrar_Perfil();
            Atualizar_Info.ShowDialog();
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

        private void btn_CadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario();
            cadastrar_Usuario.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_CadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrar_Cliente = new Cadastrar_Cliente();
            cadastrar_Cliente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_Alteracoes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
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

        private void btn_ExcluirPA_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand com = new MySqlCommand("SELECT Id_Cliente from desjejum where id_cliente = '" + Id_Paciente + "'", con);
                con.Open();

                MySqlDataReader dr0;
                dr0 = com.ExecuteReader();

                while (dr0.Read())
                {
                    Id_PacienteDB = dr0.GetString("id_cliente");
                }
                if (Id_Paciente == Id_PacienteDB == true)
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("DELETE from desjejum WHERE id_cliente ='" + Id_Paciente + "'", conexão);

                    MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando1 = new MySqlCommand("DELETE from almoco WHERE id_cliente ='" + Id_Paciente + "'", conexão1);

                    MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando2 = new MySqlCommand("DELETE from lanchetarde WHERE id_cliente ='" + Id_Paciente + "'", conexão2);

                    MySqlConnection conexão3 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando3 = new MySqlCommand("DELETE from jantar WHERE id_cliente ='" + Id_Paciente + "'", conexão3);

                    MySqlConnection conexão4 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando4 = new MySqlCommand("DELETE from ceia WHERE id_cliente ='" + Id_Paciente + "'", conexão4);

                    conexão.Open();
                    conexão1.Open();
                    conexão2.Open();
                    conexão3.Open();
                    conexão4.Open();

                    Comando.ExecuteNonQuery();
                    Comando1.ExecuteNonQuery();
                    Comando2.ExecuteNonQuery();
                    Comando3.ExecuteNonQuery();
                    Comando4.ExecuteNonQuery();

                    conexão.Close();
                    conexão1.Close();
                    conexão2.Close();
                    conexão3.Close();
                    conexão4.Close();

                    MessageBox.Show("Plano Alimentar Excluído com Sucesso");
                }
                else if (Id_Paciente == Id_PacienteDB == false)
                {
                    MessageBox.Show("Esse Usuário Não Possui Um Plano Alimentar Cadastrado!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Grid_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Comandos para armazenar dados das Colunas e Linhas que o Usuário deu DoubleClick
            if (Grid_ClientesCPA.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Grid_ClientesCPA.CurrentCell.Selected = true;
                Id_Paciente = Grid_ClientesCPA.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                Usuario = Grid_ClientesCPA.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                Paciente = Grid_ClientesCPA.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }    
        }

        private void ArmazenandoVariaveis()
        {
                if (
                    Grid_PlanoAlimentar.Rows[0].Cells["Column4"].Value!=null &&
                    Grid_PlanoAlimentar.Rows[0].Cells["Column3"].Value!=null && 
                    Grid_PlanoAlimentar.Rows[0].Cells["Column2"].Value!=null &&

                    Grid_PlanoAlimentar.Rows[1].Cells["Column4"].Value != null &&
                    Grid_PlanoAlimentar.Rows[1].Cells["Column3"].Value != null &&
                    Grid_PlanoAlimentar.Rows[1].Cells["Column2"].Value != null &&

                    Grid_PlanoAlimentar.Rows[2].Cells["Column4"].Value != null &&
                    Grid_PlanoAlimentar.Rows[2].Cells["Column3"].Value != null &&
                    Grid_PlanoAlimentar.Rows[2].Cells["Column2"].Value != null &&

                    Grid_PlanoAlimentar.Rows[3].Cells["Column4"].Value != null &&
                    Grid_PlanoAlimentar.Rows[3].Cells["Column3"].Value != null &&
                    Grid_PlanoAlimentar.Rows[3].Cells["Column2"].Value != null &&

                    Grid_PlanoAlimentar.Rows[4].Cells["Column4"].Value != null &&
                    Grid_PlanoAlimentar.Rows[4].Cells["Column3"].Value != null &&
                    Grid_PlanoAlimentar.Rows[4].Cells["Column2"].Value != null &&

                    Grid_PlanoAlimentar.Rows[5].Cells["Column4"].Value != null &&
                    Grid_PlanoAlimentar.Rows[5].Cells["Column3"].Value != null &&
                    Grid_PlanoAlimentar.Rows[5].Cells["Column2"].Value != null
                    )
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
                else
                {
                    status = 1;                   
                }   
        }

        private void Grid_Clientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AtualizarPA_Click(object sender, EventArgs e)
        {
            ArmazenandoVariaveis();
            try
            {
                if (status == 0)
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("UPDATE desjejum set opcao1 = '" + opcao1 + "', opcao2 = '" + opcao2 + "', opcao3 = '" + opcao3 + "' where id_cliente = '" + Id_Paciente + "'", conexão);
                    conexão.Open();

                    MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando1 = new MySqlCommand("UPDATE almoco set opcao1 = '" + opcao4 + "', opcao2 = '" + opcao5 + "', opcao3 = '" + opcao6 + "' where id_cliente = '" + Id_Paciente + "'", conexão1);
                    conexão1.Open();

                    MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando2 = new MySqlCommand("UPDATE lanchetarde set opcao1 = '" + opcao7 + "', opcao2 = '" + opcao8 + "', opcao3 = '" + opcao9 + "' where id_cliente = '" + Id_Paciente + "'", conexão2);
                    conexão2.Open();

                    MySqlConnection conexão3 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando3 = new MySqlCommand("UPDATE jantar set opcao1 = '" + opcao10 + "', opcao2 = '" + opcao11 + "', opcao3 = '" + opcao12 + "' where id_cliente = '" + Id_Paciente + "'", conexão3);
                    conexão3.Open();

                    MySqlConnection conexão4 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
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
                else
                {
                    MessageBox.Show("Esse usuário não possui Plano Alimentar!");
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

        private void btn_PesquisarCliente_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Grid_Clientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Cadastrar_PlanoAlimentar()
        {
            InitializeComponent();
        }

        private void Grid_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastrar_PlanoAlimentar_Load(object sender, EventArgs e)
        {
            int n = Grid_PlanoAlimentar.Rows.Add();
            int n1 = Grid_PlanoAlimentar.Rows.Add();
            int n2 = Grid_PlanoAlimentar.Rows.Add();
            int n3 = Grid_PlanoAlimentar.Rows.Add();
            int n4 = Grid_PlanoAlimentar.Rows.Add();

            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
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
                    int nc = Grid_ClientesCPA.Rows.Add();

                    Grid_ClientesCPA.Rows[nc].Cells[0].Value = Id_Paciente;
                    Grid_ClientesCPA.Rows[nc].Cells[1].Value = Usuario;
                    Grid_ClientesCPA.Rows[nc].Cells[2].Value = Paciente;
                    Grid_ClientesCPA.Rows[nc].Cells[3].Value = Cpf_Paciente;
                    Grid_ClientesCPA.Rows[nc].Cells[4].Value = Idade_Paciente;
                    Grid_ClientesCPA.Rows[nc].Cells[5].Value = Sexo_Paciente;
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

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            ArmazenandoVariaveis();
            if (status == 0)
            {
                try
                {
                    MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
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
                        MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
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
            else
            {
                MessageBox.Show("Preencha as colunas e linhas Corretamente!");
            }       
        }
    }
}