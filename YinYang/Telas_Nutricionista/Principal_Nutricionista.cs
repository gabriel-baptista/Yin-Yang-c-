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
    public partial class Principal_Nutricionista : Form
    {
        string Id_Paciente, Paciente, Cpf_Paciente, Idade_Paciente, Sexo_Paciente, Usuario, Data_Convertida, Data_DBConvertida, Hora_Convertida, Hora_DBConvertida, HoraDB, DataDB, Data, Hora;
        public Principal_Nutricionista()
        {
            InitializeComponent();
            DesignPaineis();
        }
        public Principal_Nutricionista(string Nome) : this()
        {
            lbl_nome.Text = Nome;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
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
        private void button4_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);

        }

        private void Principal_Nutricionista_Load(object sender, EventArgs e)
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_mostra_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void painel_Logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void painel_Informacoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {

        }

        private void painel_Principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario(lbl_nome.Text);
            cadastrar_Usuario.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrarCliente = new Cadastrar_Cliente(lbl_nome.Text);
            cadastrarCliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plano_Alimentar plano_Alimentar = new Plano_Alimentar();
            plano_Alimentar.ShowDialog();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info_Paciente = new Mostrar_Perfil(lbl_nome.Text);
            Atualizar_Info_Paciente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Alteracoes_Cliente = new Perfil_Paciente_Nutri();
            Alteracoes_Cliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_Sair_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Grid_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            double stats = 0;
            Hora = tb_Hora.Text;
            Data = iconeData2.Text;

            DateTime dt = Convert.ToDateTime(Data);
            Data_Convertida = dt.ToString("yyyy-MM-dd");

            DateTime hr = Convert.ToDateTime(Hora);
            Hora_Convertida = hr.ToString("H:mm:ss");

            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando = new MySqlCommand("SELECT * from consulta", conexão);
                conexão.Open();

                MySqlDataReader dr;
                dr = Comando.ExecuteReader();

                while (dr.Read())
                {
                    DataDB = dr.GetString("agenda_data");
                    HoraDB = dr.GetString("agenda_hora");

                    DateTime dt2 = Convert.ToDateTime(DataDB);
                    Data_DBConvertida = dt2.ToString("yyyy-MM-dd");

                    DateTime hr2 = Convert.ToDateTime(HoraDB);
                    Hora_DBConvertida = hr2.ToString("H:mm:ss");

                    if (Data_Convertida != Data_DBConvertida && Hora_Convertida != Hora_DBConvertida)
                    {
                        stats = 0;
                    }
                    else if (Data_Convertida == Data_DBConvertida && Hora_Convertida == Hora_DBConvertida)
                    {
                        stats = 1;
                    }

                }
                conexão.Close();
                if (stats == 0)
                {
                    try
                    {
                        MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                        MySqlCommand Comando2 = new MySqlCommand("INSERT into consulta (agenda_idpaciente, agenda_data, agenda_hora, agenda_paciente, agenda_status) VALUES('" + Id_Paciente + "','" + Data_Convertida + "','" + Hora_Convertida + "','" + Paciente + "','0')", conexão2);

                        conexão2.Open();

                        MySqlDataReader dr2;
                        dr2 = Comando2.ExecuteReader();
                        conexão2.Close();

                        MessageBox.Show("Consulta Agendada com Sucesso!");
                    }
                    catch (MySqlException exx)
                    {
                        MessageBox.Show(exx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Você Já Possui Consulta Marcada Para Esse Horário!");
                }
            }
            catch (MySqlException exx)
            {
                MessageBox.Show(exx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Grid_Consultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Visualizar_Consultas visualizar_Consultas = new Visualizar_Consultas();
            visualizar_Consultas.ShowDialog();
            this.Dispose();
        }

        private void painel_VaiMudar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
