using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using TG.Telas_Nutricionista;

namespace TG
{
    public partial class Visualizar_Consultas : Form
    {
        string Id_Paciente, Paciente, Data, Hora, Hora_DBConvertida, Data_DBConvertida, Id_Consulta;

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

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario();
            cadastrar_Usuario.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrar_Cliente = new Cadastrar_Cliente();
            cadastrar_Cliente.ShowDialog();
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

        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btnAlteracoes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Excluir_Cliente = new Perfil_Paciente_Nutri();
            Excluir_Cliente.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info = new Mostrar_Perfil();
            Atualizar_Info.ShowDialog();
            this.Dispose();
            EsconderMenu();
        }

        public Visualizar_Consultas()
        {
            InitializeComponent();
        }

        private void Visualizar_Consultas_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando = new MySqlCommand("SELECT * FROM `consulta` ORDER BY `agenda_data` ASC,`agenda_hora`", conexão);
                conexão.Open();

                MySqlDataReader dr;
                dr = Comando.ExecuteReader();
                while (dr.Read())
                {
                    Id_Paciente = dr.GetString("agenda_idpaciente");
                    Paciente = dr.GetString("agenda_paciente");
                    Data = dr.GetString("agenda_data");
                    Hora = dr.GetString("agenda_hora");
                    Id_Consulta = dr.GetString("agenda_id");

                    DateTime dt3 = Convert.ToDateTime(Data);
                    Data_DBConvertida = dt3.ToString("dd-MM-yyyy");

                    DateTime hr2 = Convert.ToDateTime(Hora);
                    Hora_DBConvertida = hr2.ToString("H:mm:ss");

                    int n = Grid_Consultas.Rows.Add();

                    Grid_Consultas.Rows[n].Cells[0].Value = Id_Consulta;
                    Grid_Consultas.Rows[n].Cells[1].Value = Id_Paciente;
                    Grid_Consultas.Rows[n].Cells[2].Value = Paciente;
                    Grid_Consultas.Rows[n].Cells[3].Value = Data_DBConvertida;
                    Grid_Consultas.Rows[n].Cells[4].Value = Hora_DBConvertida;
                }
                conexão.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
