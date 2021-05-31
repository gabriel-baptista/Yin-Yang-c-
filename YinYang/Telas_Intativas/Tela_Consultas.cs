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
    public partial class Tela_Consultas : Form
    {
        string hora, id, data, data_Convertida, data_DBConvertida, dataDB, hora_Convertida, hora_DBConvertida, horaDB;

        public Tela_Consultas()
        {
            InitializeComponent();
        }

        private void Tela_Consultas_Load(object sender, EventArgs e)
        {

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

        private void iconeData2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_PesquisarCliente_Click(object sender, EventArgs e)
        {
            string cpf_Digitado = tb_cpf.Text, CPFBD;

            if (cpf_Digitado == "")
            {
                MessageBox.Show("Por favor Preencha o Campo Corretamente");
            }
            else
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
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
                            tb_idade_cliente.Text = dr.GetString("idade_cliente");
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

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void tb_Hora_Enter(object sender, EventArgs e)
        {
        }

        private void tb_Hora_Leave(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Cliente cadastrar_Cliente = new Cadastrar_Cliente();
            cadastrar_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrar_Usuario = new Cadastrar_Usuario();
            cadastrar_Usuario.ShowDialog();
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
            Mostrar_Perfil Atualizar_Info_Paciente = new Mostrar_Perfil(lbl_nome.Text);
            Atualizar_Info_Paciente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btnAlteracoes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelAlteracoes);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            double stats = 0;
            hora = tb_Hora.Text;
            id = tb_id_cliente.Text;
            data = iconeData2.Text;

            DateTime dt = Convert.ToDateTime(data);
            data_Convertida = dt.ToString("yyyy-MM-dd");

            DateTime hr = Convert.ToDateTime(hora);
            hora_Convertida = hr.ToString("H:mm:ss");

            if (tb_cpf.Text == "")
            {
                MessageBox.Show("Por Favor Preencha o Campo de Pesquisa Digitando o CPF do Cliente!");
            }
            else
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                    MySqlCommand Comando = new MySqlCommand("SELECT * from consulta", conexão);
                    conexão.Open();

                    MySqlDataReader dr;
                    dr = Comando.ExecuteReader();

                    while (dr.Read())
                    {
                        dataDB = dr.GetString("agenda_data");
                        horaDB = dr.GetString("agenda_hora");

                        DateTime dt2 = Convert.ToDateTime(dataDB);
                        data_DBConvertida = dt2.ToString("yyyy-MM-dd");

                        DateTime hr2 = Convert.ToDateTime(horaDB);
                        hora_DBConvertida = hr2.ToString("H:mm:ss");

                        if (data_Convertida != data_DBConvertida && hora_Convertida != hora_DBConvertida)
                        {
                            stats = 0;
                        }
                        else if (data_Convertida == data_DBConvertida && hora_Convertida == hora_DBConvertida)
                        {
                            stats = 1;
                        }

                    }
                    conexão.Close();
                    if (stats == 0)
                    {
                        try
                        {
                            MySqlConnection conexão2 = new MySqlConnection("server=localhost; port=3307; user Id=root; database=projetoDB; password=usbw;");
                            MySqlCommand Comando2 = new MySqlCommand("INSERT into consulta (agenda_idpaciente, agenda_data, agenda_hora, agenda_paciente, agenda_status) VALUES('" + id + "','" + data_Convertida + "','" + hora_Convertida + "','" + this.tb_nome_cliente.Text + "','0')", conexão2);

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
        }
        private void tb_Hora_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}