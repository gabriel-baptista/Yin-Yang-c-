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
    public partial class Perfil_Cliente : Form
    {
        string Id_Cliente, Usuario_Cliente,Senha_Cliente, usuarioDB, senhaDB, Id_PacienteDB, opcao1, opcao2, opcao3, opcao4, opcao5, opcao6, opcao7, opcao8, opcao9, opcao10, opcao11, opcao12, opcao13,opcao14, opcao15;

        private void btn_MostrarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Cliente consulta_Cliente = new Consulta_Cliente();
            consulta_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btn_Perfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alterar_Senha alterar_Senha = new Alterar_Senha(Usuario_Cliente, lbl_senha.Text, Id_Cliente);
            alterar_Senha.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void btn_MeuPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        public Perfil_Cliente(string usuario, string senha, string id)
        {           
            InitializeComponent();
            Usuario_Cliente = usuario;
            Senha_Cliente = senha;
            Id_Cliente = id;
        }

        public Perfil_Cliente()
        {
        }

        private void msktb_cpf_cliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tb_cpf_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Perfil_Cliente_Load(object sender, EventArgs e)
        {
           
        }

        private void Entrar_Click(object sender, EventArgs e)
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
                    usuarioDB = dr.GetString("user_cliente");
                    senhaDB = dr.GetString("senha_cliente");

                    if (lbl_nome.Text == usuarioDB && lbl_senha.Text == senhaDB)
                    {
                        tb_id_cliente.Text = dr.GetString("cliente_id");
                        tb_peso_inicial.Text = dr.GetString("peso_cliente");
                        tb_massa_magra.Text = dr.GetString("massa_magra");
                        tb_massa_gorda.Text = dr.GetString("massa_gorda");
                        tb_idade_cliente.Text = dr.GetString("idade_cliente");
                        tb_sexo_cliente.Text = dr.GetString("sexo_cliente");
                        tb_peso_atual.Text = dr.GetString("peso_atual");
                        msktb_cpf_cliente.Text = dr.GetString("cpf_cliente");
                        string Id_Paciente = dr.GetString("cliente_id");

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

                            Grid_PlanoAlimentarPA.Rows.Clear();

                            while (dr1.Read())
                            {
                                Id_PacienteDB = dr1.GetString("id_cliente");
                                if (Id_PacienteDB == Id_Paciente)
                                {
                                    opcao1 = dr1.GetString("opcao1");
                                    opcao2 = dr1.GetString("opcao2");
                                    opcao3 = dr1.GetString("opcao3");

                                    int n1 = Grid_PlanoAlimentarPA.Rows.Add();

                                    Grid_PlanoAlimentarPA.Rows[n1].Cells[0].Value = opcao1;
                                    Grid_PlanoAlimentarPA.Rows[n1].Cells[1].Value = opcao2;
                                    Grid_PlanoAlimentarPA.Rows[n1].Cells[2].Value = opcao3;
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

                                    int n2 = Grid_PlanoAlimentarPA.Rows.Add();

                                    Grid_PlanoAlimentarPA.Rows[n2].Cells[0].Value = opcao4;
                                    Grid_PlanoAlimentarPA.Rows[n2].Cells[1].Value = opcao5;
                                    Grid_PlanoAlimentarPA.Rows[n2].Cells[2].Value = opcao6;
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

                                    int n3 = Grid_PlanoAlimentarPA.Rows.Add();

                                    Grid_PlanoAlimentarPA.Rows[n3].Cells[0].Value = opcao7;
                                    Grid_PlanoAlimentarPA.Rows[n3].Cells[1].Value = opcao8;
                                    Grid_PlanoAlimentarPA.Rows[n3].Cells[2].Value = opcao9;
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

                                    int n4 = Grid_PlanoAlimentarPA.Rows.Add();

                                    Grid_PlanoAlimentarPA.Rows[n4].Cells[0].Value = opcao10;
                                    Grid_PlanoAlimentarPA.Rows[n4].Cells[1].Value = opcao11;
                                    Grid_PlanoAlimentarPA.Rows[n4].Cells[2].Value = opcao12;
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

                                    int n5 = Grid_PlanoAlimentarPA.Rows.Add();

                                    Grid_PlanoAlimentarPA.Rows[n5].Cells[0].Value = opcao13;
                                    Grid_PlanoAlimentarPA.Rows[n5].Cells[1].Value = opcao14;
                                    Grid_PlanoAlimentarPA.Rows[n5].Cells[2].Value = opcao15;
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
