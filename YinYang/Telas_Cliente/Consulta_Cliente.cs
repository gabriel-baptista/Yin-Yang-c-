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

namespace TG.Telas_Cliente
{
    public partial class Consulta_Cliente : Form
    {
        string Senha_Cliente,Id_Paciente1, Usuario_Cliente, Id_Paciente, Paciente, Data, Hora, Hora_DBConvertida, Data_DBConvertida, Id_Consulta;

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Cliente principal_Cliente = new Principal_Cliente();
            principal_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btn_MeuPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Cliente perfil_Cliente = new Perfil_Cliente();
            perfil_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btn_Perfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterar_Senha alterar_Senha = new Alterar_Senha(Usuario_Cliente, Senha_Cliente, Id_Paciente1);
            alterar_Senha.ShowDialog();
            this.Dispose();
        }

        private void btn_MostrarClientes_Click(object sender, EventArgs e)
        {

        }

        public Consulta_Cliente()
        {
        }

        public Consulta_Cliente(string usuario, string id, string senha)
        {
            InitializeComponent();
            Usuario_Cliente = usuario;
            Id_Paciente1 = id;
            Senha_Cliente = senha;
        }

        private void Consulta_Cliente_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexão1 = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                MySqlCommand Comando1 = new MySqlCommand("SELECT * FROM consulta  ORDER BY consulta.agenda_data DESC, consulta.agenda_hora DESC", conexão1);
                conexão1.Open();

                MySqlDataReader dr1;
                dr1 = Comando1.ExecuteReader();
                while (dr1.Read())
                {
                    Paciente = dr1.GetString("agenda_paciente");
                    Id_Paciente = dr1.GetString("agenda_idpaciente");

                    if (Paciente == Usuario_Cliente && Id_Paciente1 == Id_Paciente)
                    {
                        Data = dr1.GetString("agenda_data");
                        Hora = dr1.GetString("agenda_hora");
                        Id_Consulta = dr1.GetString("agenda_id");

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
                        painelConsulta.Visible = true;
                        Grid_Consultas.Visible = true;
                    }
                    else if (Paciente != Usuario_Cliente || Id_Paciente1 != Id_Paciente)
                    {
                        painelNConsulta.Visible = true;
                    }
                }
                conexão1.Close();                          
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
    }
}

