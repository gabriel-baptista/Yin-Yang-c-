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
    public partial class Alterar_Senha : Form
    {
        string Id_Cliente;
        int senha_confirmada;

        public Alterar_Senha(string usuario, string senha, string id)
        {
            InitializeComponent();
            textBox2.Text = usuario;
            textBox1.Text = senha;
            Id_Cliente = id;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alterar_Senha_Load(object sender, EventArgs e)
        {

        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == "" || tb_senha.Text == "" || tb_senha_confirmada.Text == "")
            {
                MessageBox.Show("Complete os Campos Corretamente!");
            }
            else
            {
                if (tb_senha_confirmada.Text == tb_senha.Text)
                {
                    senha_confirmada = 1;
                }
                else
                {
                    MessageBox.Show("As Senhas não Correspondem!");
                }
            }
            if (senha_confirmada == 1)
            {
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("UPDATE cliente set user_cliente ='" + this.tb_login.Text + "', senha_cliente = '" + this.tb_senha.Text + "' WHERE cliente_id = '" + Id_Cliente + "'", conexão);

                    conexão.Open();

                    Comando.ExecuteNonQuery();
                    conexão.Close();
                    MessageBox.Show("Atualizado com Sucesso!");
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

        private void btn_MostrarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consulta_Cliente consulta_Cliente = new Consulta_Cliente();
            consulta_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btn_Perfil_Click(object sender, EventArgs e)
        {

        }

        private void btn_MeuPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Cliente perfil_Cliente = new Perfil_Cliente();
            perfil_Cliente.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Cliente principal_Cliente = new Principal_Cliente();
            principal_Cliente.ShowDialog();
            this.Dispose();
        }
    }
}
