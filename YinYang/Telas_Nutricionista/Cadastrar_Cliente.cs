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
    public partial class Cadastrar_Cliente : Form
    {
        int sex;
        string sexo;

        public Cadastrar_Cliente()
        {   
            InitializeComponent();
        }
        public Cadastrar_Cliente(string Nome) : this()
        {
            //lbl_nome.Text = Nome;
        }
        public static void Apenas_Numeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
        }
        private void DesignPaineis()
        {
            painelPossiveisCadastros.Visible = false;
        }
        private void EsconderMenu()
        {
            if (painelPossiveisCadastros.Visible == true)
                painelPossiveisCadastros.Visible = false;
            if (painel_Alteracoes.Visible == true)
                painel_Alteracoes.Visible = false;
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
        private void Cadastrar_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista tela_principal = new Principal_Nutricionista();
            tela_principal.ShowDialog();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            sex = comboBox_sexo.SelectedIndex;   
            
            if (sex == -1 || tb_nome_cliente.Text == "" || msktb_cpf_cliente.Text == "" || tb_peso_inicial.Text == "" || tb_peso_atual.Text == "" || tb_idade.Text == "" || tb_massa_magra.Text == "" || tb_massa_gorda.Text == "" || tb_user_cliente.Text == "" || tb_senha_cliente.Text == "")
            {
                MessageBox.Show("Complete os Campos Corretamente!");
            }
            else
            {
                if (sex == 0)
                {
                    sexo = "Masculino";
                }
                else if (sex == 1)
                {
                    sexo = "Feminino";
                }
                try
                {
                    MySqlConnection conexão = new MySqlConnection("server=localhost; port=3306; user Id=root; database=projetoDB; password=;");
                    MySqlCommand Comando = new MySqlCommand("INSERT into cliente (nivel_acesso,nome_cliente,cpf_cliente,sexo_cliente,peso_cliente,peso_atual,idade_cliente,massa_magra,massa_gorda,user_cliente,senha_cliente) VALUES('cliente','" + this.tb_nome_cliente.Text + "','" + this.msktb_cpf_cliente.Text + "','" + sexo + "','" + this.tb_peso_inicial.Text + "','" + this.tb_peso_atual.Text + "','" + this.tb_idade.Text + "','" + this.tb_massa_magra.Text + "','" + this.tb_massa_gorda.Text + "','" + this.tb_user_cliente.Text + "','" + this.tb_senha_cliente.Text + "')", conexão);
                    conexão.Open();

                    Comando.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Feito com Sucesso!");
                    conexão.Close();
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

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Apenas_Numeros(sender, e);
        }

        private void tb_nome_cliente_Enter(object sender, EventArgs e)
        {
   
        }

        private void tb_nome_cliente_Leave(object sender, EventArgs e)
        {
           
        }

        private void tb_cpf_cliente_Enter(object sender, EventArgs e)
        {
        }

        private void tb_cpf_cliente_Leave(object sender, EventArgs e)
        {

        }

        private void tb_peso_inicial_Enter(object sender, EventArgs e)
        {

        }

        private void tb_peso_inicial_Leave(object sender, EventArgs e)
        {

        }

        private void tb_peso_atual_Enter(object sender, EventArgs e)
        {

        }

        private void tb_peso_atual_Leave(object sender, EventArgs e)
        {

        }

        private void tb_idade_Enter(object sender, EventArgs e)
        {

        }

        private void tb_idade_Leave(object sender, EventArgs e)
        {
 
        }

        private void tb_massa_magra_Enter(object sender, EventArgs e)
        {
 
        }

        private void tb_massa_magra_Leave(object sender, EventArgs e)
        {

        }

        private void tb_massa_magra_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_massa_gorda_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_massa_gorda_Enter(object sender, EventArgs e)
        {

        }

        private void tb_massa_gorda_Leave(object sender, EventArgs e)
        {

        }

        private void tb_nome_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_user_cliente_Enter(object sender, EventArgs e)
        {

        }

        private void tb_user_cliente_Leave(object sender, EventArgs e)
        {

        }

        private void btnAgendarConsultas_Click(object sender, EventArgs e)
        {
            MostrarMenu(painelPossiveisCadastros);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            EsconderMenu();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cadastrar_Usuario cadastrarUsuários = new Cadastrar_Usuario();
            cadastrarUsuários.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btnAgendarConsultas_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            MostrarMenu(painel_Alteracoes);
        }

        private void painelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal_Nutricionista principal_Nutricionista = new Principal_Nutricionista();
            principal_Nutricionista.ShowDialog();
            this.Dispose();
        }

        private void tb_senha_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_senha_cliente_Enter(object sender, EventArgs e)
        {

        }

        private void tb_senha_cliente_Leave(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil_Paciente_Nutri Excluir_Cliente = new Perfil_Paciente_Nutri();
            Excluir_Cliente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_Alterar_Infor_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mostrar_Perfil Atualizar_Info_Paciente = new Mostrar_Perfil();
            Atualizar_Info_Paciente.ShowDialog();
            this.Close();
            EsconderMenu();
        }

        private void btn_VisualizarConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Visualizar_Consultas visualizar_Consultas = new Visualizar_Consultas();
            visualizar_Consultas.ShowDialog();
            this.Dispose();
        }

        private void btn_PlanoAlimentar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Plano_Alimentar plano_Alimentar = new Plano_Alimentar();
            plano_Alimentar.ShowDialog();
            this.Dispose();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tela_Login tela_Login = new Tela_Login();
            tela_Login.ShowDialog();
            this.Dispose();
        }

        private void msktb_Cpf_Leave(object sender, EventArgs e)
        {
       
        }

        private void msktb_cpf_cliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
