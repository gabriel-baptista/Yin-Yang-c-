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
    public partial class Tela_Login : Form
    {
        String nome_cliente,id_cliente, id, nome, senha, usuarioBD, senhaBD, nivel_acessoBD, usuario_cliente, senha_cliente, senha_cliente_BD, cliente_BD;

        private void Tela_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            nome = tb_nome.Text;
            senha = tb_senha.Text;
            usuario_cliente = tb_nome.Text;
            senha_cliente = tb_senha.Text;
            double status =0, id1;
            double level = cb_nivel_acesso.SelectedIndex;
            

            if (level == 0)
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("SELECT * FROM usuarios ", conexão);
                    conexão.Open();

                    Comando.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = Comando.ExecuteReader();

                    while (dr.Read())
                    {
                        usuarioBD = dr.GetString("login_usuario");
                        senhaBD = dr.GetString("senha_usuario");
                        nivel_acessoBD = dr.GetString("nivel_acesso");

                        if (nome.Equals(usuarioBD) && senha.Equals(senhaBD) && nivel_acessoBD.Equals("nutricionista"))
                        {
                            status = 1;
                        }
                    }
                    if (status == 1)
                    {
                        this.Hide();
                        Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista(tb_nome.Text);   
                        principal_Nutricionista.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha Incorretos", "Tente novamente!");
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

            else if (level == 1)
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("SELECT * FROM cliente ", conexão);
                    conexão.Open();

                    Comando.CommandType = CommandType.Text;

                    MySqlDataReader dr;
                    dr = Comando.ExecuteReader();

                    while (dr.Read())
                    {
                        cliente_BD = dr.GetString("user_cliente");
                        senha_cliente_BD = dr.GetString("senha_cliente");
                        nivel_acessoBD = dr.GetString("nivel_acesso");

                        if (usuario_cliente.Equals(cliente_BD) && senha_cliente.Equals(senha_cliente_BD) && nivel_acessoBD.Equals("cliente"))
                        {
                            status = 2;
                            id = dr.GetString("cliente_id");
                            id1 = Int32.Parse(id);
                            usuario_cliente = dr.GetString("user_cliente");
                            nome_cliente = dr.GetString("nome_cliente");
                            id_cliente = dr.GetString("cliente_id");
                        }
                    }
                    if (status == 2)
                    {
                        this.Hide();
                        Principal_Cliente principal_Cliente = new Principal_Cliente(usuario_cliente, nome_cliente,tb_senha.Text,id_cliente);
                        principal_Cliente.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha Incorretos", "Tente novamente!");
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }        
    }
}
   

