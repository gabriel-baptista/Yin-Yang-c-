
namespace TG.Telas_Cliente
{
    partial class Alterar_Senha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painel_menu = new System.Windows.Forms.Panel();
            this.btn_MeuPerfil = new System.Windows.Forms.Button();
            this.btn_Perfil = new System.Windows.Forms.Button();
            this.btn_MostrarClientes = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_senha_confirmada = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new ePOSOne.btnProduct.Button_WOC();
            this.painel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // painel_menu
            // 
            this.painel_menu.BackColor = System.Drawing.Color.LimeGreen;
            this.painel_menu.Controls.Add(this.btn_MeuPerfil);
            this.painel_menu.Controls.Add(this.btn_Perfil);
            this.painel_menu.Controls.Add(this.btn_MostrarClientes);
            this.painel_menu.Controls.Add(this.btn_Sair);
            this.painel_menu.Location = new System.Drawing.Point(0, 1);
            this.painel_menu.Name = "painel_menu";
            this.painel_menu.Size = new System.Drawing.Size(180, 566);
            this.painel_menu.TabIndex = 137;
            // 
            // btn_MeuPerfil
            // 
            this.btn_MeuPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MeuPerfil.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_MeuPerfil.FlatAppearance.BorderSize = 0;
            this.btn_MeuPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_MeuPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MeuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MeuPerfil.ForeColor = System.Drawing.Color.White;
            this.btn_MeuPerfil.Location = new System.Drawing.Point(0, 263);
            this.btn_MeuPerfil.Name = "btn_MeuPerfil";
            this.btn_MeuPerfil.Size = new System.Drawing.Size(180, 40);
            this.btn_MeuPerfil.TabIndex = 4;
            this.btn_MeuPerfil.Text = "Meu Perfil";
            this.btn_MeuPerfil.UseVisualStyleBackColor = true;
            this.btn_MeuPerfil.Click += new System.EventHandler(this.btn_MeuPerfil_Click);
            // 
            // btn_Perfil
            // 
            this.btn_Perfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Perfil.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Perfil.FlatAppearance.BorderSize = 0;
            this.btn_Perfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Perfil.ForeColor = System.Drawing.Color.White;
            this.btn_Perfil.Location = new System.Drawing.Point(-3, 188);
            this.btn_Perfil.Name = "btn_Perfil";
            this.btn_Perfil.Size = new System.Drawing.Size(180, 40);
            this.btn_Perfil.TabIndex = 3;
            this.btn_Perfil.Text = "Alterar Senha";
            this.btn_Perfil.UseVisualStyleBackColor = true;
            this.btn_Perfil.Click += new System.EventHandler(this.btn_Perfil_Click);
            // 
            // btn_MostrarClientes
            // 
            this.btn_MostrarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MostrarClientes.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_MostrarClientes.FlatAppearance.BorderSize = 0;
            this.btn_MostrarClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_MostrarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MostrarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MostrarClientes.ForeColor = System.Drawing.Color.White;
            this.btn_MostrarClientes.Location = new System.Drawing.Point(0, 115);
            this.btn_MostrarClientes.Name = "btn_MostrarClientes";
            this.btn_MostrarClientes.Size = new System.Drawing.Size(180, 40);
            this.btn_MostrarClientes.TabIndex = 0;
            this.btn_MostrarClientes.Text = "Mostrar Consultas";
            this.btn_MostrarClientes.UseVisualStyleBackColor = true;
            this.btn_MostrarClientes.Click += new System.EventHandler(this.btn_MostrarClientes_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(0, 471);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(180, 40);
            this.btn_Sair.TabIndex = 2;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.ForeColor = System.Drawing.Color.LimeGreen;
            this.tb_senha.Location = new System.Drawing.Point(578, 225);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(134, 21);
            this.tb_senha.TabIndex = 145;
            // 
            // tb_senha_confirmada
            // 
            this.tb_senha_confirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha_confirmada.ForeColor = System.Drawing.Color.LimeGreen;
            this.tb_senha_confirmada.Location = new System.Drawing.Point(578, 283);
            this.tb_senha_confirmada.Name = "tb_senha_confirmada";
            this.tb_senha_confirmada.PasswordChar = '*';
            this.tb_senha_confirmada.Size = new System.Drawing.Size(134, 21);
            this.tb_senha_confirmada.TabIndex = 144;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_login.ForeColor = System.Drawing.Color.LimeGreen;
            this.tb_login.Location = new System.Drawing.Point(578, 168);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(134, 21);
            this.tb_login.TabIndex = 142;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(577, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 141;
            this.label4.Text = "Confirmar Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(577, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 140;
            this.label3.Text = "Senha Nova";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(575, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 139;
            this.label2.Text = "Login Novo";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(409, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 21);
            this.textBox1.TabIndex = 149;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox2.Location = new System.Drawing.Point(409, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 21);
            this.textBox2.TabIndex = 148;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(406, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 147;
            this.label1.Text = "Senha Antigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(406, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 146;
            this.label5.Text = "Login Antigo";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.ButtonColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(708, 471);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.OnHoverButtonColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Confirmar.Size = new System.Drawing.Size(170, 40);
            this.btn_Confirmar.TabIndex = 150;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.TextColor = System.Drawing.Color.White;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_senha_confirmada);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.painel_menu);
            this.Name = "Alterar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar_Senha";
            this.Load += new System.EventHandler(this.Alterar_Senha_Load);
            this.painel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painel_menu;
        private System.Windows.Forms.Button btn_MeuPerfil;
        private System.Windows.Forms.Button btn_Perfil;
        private System.Windows.Forms.Button btn_MostrarClientes;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_senha_confirmada;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private ePOSOne.btnProduct.Button_WOC btn_Confirmar;
    }
}