
namespace TG
{
    partial class Principal_Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Cliente));
            this.btn_MostrarClientes = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.painel_menu = new System.Windows.Forms.Panel();
            this.btn_MeuPerfil = new System.Windows.Forms.Button();
            this.btn_Perfil = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.painel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_MostrarClientes.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_Sair.Click += new System.EventHandler(this.button3_Click);
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
            this.painel_menu.TabIndex = 4;
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
            this.btn_MeuPerfil.Location = new System.Drawing.Point(3, 261);
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
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.White;
            this.lbl_nome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_nome.Location = new System.Drawing.Point(781, 58);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(123, 24);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Your Name T";
            this.lbl_nome.Visible = false;
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.BackColor = System.Drawing.Color.White;
            this.lbl_senha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_senha.Location = new System.Drawing.Point(781, 82);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(123, 24);
            this.lbl_senha.TabIndex = 61;
            this.lbl_senha.Text = "Pass Name T";
            this.lbl_senha.Visible = false;
            this.lbl_senha.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.White;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Data.Location = new System.Drawing.Point(496, 303);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(53, 20);
            this.lbl_Data.TabIndex = 63;
            this.lbl_Data.Text = "Data:";
            this.lbl_Data.Click += new System.EventHandler(this.lbl_Data_Click);
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.BackColor = System.Drawing.Color.White;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_Hora.Location = new System.Drawing.Point(551, 260);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(91, 33);
            this.lbl_Hora.TabIndex = 62;
            this.lbl_Hora.Text = "Hora:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(363, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 73);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(459, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 76);
            this.label1.TabIndex = 64;
            this.label1.Text = "Yin Yang";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Principal_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.painel_menu);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.Name = "Principal_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal_Cliente";
            this.Load += new System.EventHandler(this.Principal_Cliente_Load);
            this.painel_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MostrarClientes;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel painel_menu;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Button btn_Perfil;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MeuPerfil;
        private System.Windows.Forms.Timer timer1;
    }
}