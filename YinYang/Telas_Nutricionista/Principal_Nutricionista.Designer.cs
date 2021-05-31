
namespace TG
{
    partial class Principal_Nutricionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Nutricionista));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.btn_PlanoAlimentar = new System.Windows.Forms.Button();
            this.btn_VisualizarConsultas = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.painelAlteracoes = new System.Windows.Forms.Panel();
            this.btn_AlterarInfoCliente = new System.Windows.Forms.Button();
            this.btn_ExcluirCliente = new System.Windows.Forms.Button();
            this.btn_Alteracoes = new System.Windows.Forms.Button();
            this.painelPossiveisCadastros = new System.Windows.Forms.Panel();
            this.btn_CadastrarUsuario = new System.Windows.Forms.Button();
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.btn_Cadastros = new System.Windows.Forms.Button();
            this.painel_Logo = new System.Windows.Forms.Panel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.painel_VaiMudar = new System.Windows.Forms.Panel();
            this.Grid_Clientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_Hora = new System.Windows.Forms.TextBox();
            this.lbl_DefinaHorario = new System.Windows.Forms.Label();
            this.btn_Confirmar = new ePOSOne.btnProduct.Button_WOC();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.iconeData2 = new TG.IconeData();
            this.Pb_Pesquisa = new System.Windows.Forms.PictureBox();
            this.painelPrincipal.SuspendLayout();
            this.painelAlteracoes.SuspendLayout();
            this.painelPossiveisCadastros.SuspendLayout();
            this.painel_Logo.SuspendLayout();
            this.painel_VaiMudar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.painelPrincipal.AutoScroll = true;
            this.painelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.painelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.painelPrincipal.Controls.Add(this.btn_PlanoAlimentar);
            this.painelPrincipal.Controls.Add(this.btn_VisualizarConsultas);
            this.painelPrincipal.Controls.Add(this.btn_Sair);
            this.painelPrincipal.Controls.Add(this.painelAlteracoes);
            this.painelPrincipal.Controls.Add(this.btn_Alteracoes);
            this.painelPrincipal.Controls.Add(this.painelPossiveisCadastros);
            this.painelPrincipal.Controls.Add(this.btn_Cadastros);
            this.painelPrincipal.Controls.Add(this.painel_Logo);
            this.painelPrincipal.Location = new System.Drawing.Point(0, 1);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(180, 566);
            this.painelPrincipal.TabIndex = 26;
            // 
            // btn_PlanoAlimentar
            // 
            this.btn_PlanoAlimentar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PlanoAlimentar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_PlanoAlimentar.FlatAppearance.BorderSize = 0;
            this.btn_PlanoAlimentar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_PlanoAlimentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlanoAlimentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlanoAlimentar.Location = new System.Drawing.Point(0, 334);
            this.btn_PlanoAlimentar.Name = "btn_PlanoAlimentar";
            this.btn_PlanoAlimentar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_PlanoAlimentar.Size = new System.Drawing.Size(180, 40);
            this.btn_PlanoAlimentar.TabIndex = 96;
            this.btn_PlanoAlimentar.Text = "Plano Alimentar";
            this.btn_PlanoAlimentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PlanoAlimentar.UseVisualStyleBackColor = true;
            this.btn_PlanoAlimentar.Click += new System.EventHandler(this.btn_PlanoAlimentar_Click);
            // 
            // btn_VisualizarConsultas
            // 
            this.btn_VisualizarConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VisualizarConsultas.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_VisualizarConsultas.FlatAppearance.BorderSize = 0;
            this.btn_VisualizarConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_VisualizarConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_VisualizarConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VisualizarConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VisualizarConsultas.ForeColor = System.Drawing.Color.White;
            this.btn_VisualizarConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VisualizarConsultas.Location = new System.Drawing.Point(0, 294);
            this.btn_VisualizarConsultas.Name = "btn_VisualizarConsultas";
            this.btn_VisualizarConsultas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_VisualizarConsultas.Size = new System.Drawing.Size(180, 40);
            this.btn_VisualizarConsultas.TabIndex = 9;
            this.btn_VisualizarConsultas.Text = "Visualizar Consultas";
            this.btn_VisualizarConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VisualizarConsultas.UseVisualStyleBackColor = true;
            this.btn_VisualizarConsultas.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(0, 471);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(180, 40);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click_2);
            // 
            // painelAlteracoes
            // 
            this.painelAlteracoes.Controls.Add(this.btn_AlterarInfoCliente);
            this.painelAlteracoes.Controls.Add(this.btn_ExcluirCliente);
            this.painelAlteracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelAlteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painelAlteracoes.ForeColor = System.Drawing.Color.White;
            this.painelAlteracoes.Location = new System.Drawing.Point(0, 214);
            this.painelAlteracoes.Name = "painelAlteracoes";
            this.painelAlteracoes.Size = new System.Drawing.Size(180, 80);
            this.painelAlteracoes.TabIndex = 7;
            // 
            // btn_AlterarInfoCliente
            // 
            this.btn_AlterarInfoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AlterarInfoCliente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_AlterarInfoCliente.FlatAppearance.BorderSize = 0;
            this.btn_AlterarInfoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_AlterarInfoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlterarInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarInfoCliente.Location = new System.Drawing.Point(0, 40);
            this.btn_AlterarInfoCliente.Name = "btn_AlterarInfoCliente";
            this.btn_AlterarInfoCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_AlterarInfoCliente.Size = new System.Drawing.Size(180, 40);
            this.btn_AlterarInfoCliente.TabIndex = 7;
            this.btn_AlterarInfoCliente.Text = "Atualizar Informações";
            this.btn_AlterarInfoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AlterarInfoCliente.UseVisualStyleBackColor = true;
            this.btn_AlterarInfoCliente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_ExcluirCliente
            // 
            this.btn_ExcluirCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ExcluirCliente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_ExcluirCliente.FlatAppearance.BorderSize = 0;
            this.btn_ExcluirCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_ExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCliente.Location = new System.Drawing.Point(0, 0);
            this.btn_ExcluirCliente.Name = "btn_ExcluirCliente";
            this.btn_ExcluirCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_ExcluirCliente.Size = new System.Drawing.Size(180, 40);
            this.btn_ExcluirCliente.TabIndex = 6;
            this.btn_ExcluirCliente.Text = "Excluir Cliente";
            this.btn_ExcluirCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ExcluirCliente.UseVisualStyleBackColor = true;
            this.btn_ExcluirCliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Alteracoes
            // 
            this.btn_Alteracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.btn_Alteracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Alteracoes.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Alteracoes.FlatAppearance.BorderSize = 0;
            this.btn_Alteracoes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Alteracoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Alteracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alteracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alteracoes.ForeColor = System.Drawing.Color.White;
            this.btn_Alteracoes.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alteracoes.Image")));
            this.btn_Alteracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alteracoes.Location = new System.Drawing.Point(0, 174);
            this.btn_Alteracoes.Name = "btn_Alteracoes";
            this.btn_Alteracoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Alteracoes.Size = new System.Drawing.Size(180, 40);
            this.btn_Alteracoes.TabIndex = 0;
            this.btn_Alteracoes.Text = "Alterações Clientes";
            this.btn_Alteracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Alteracoes.UseVisualStyleBackColor = false;
            this.btn_Alteracoes.Click += new System.EventHandler(this.button3_Click);
            // 
            // painelPossiveisCadastros
            // 
            this.painelPossiveisCadastros.Controls.Add(this.btn_CadastrarUsuario);
            this.painelPossiveisCadastros.Controls.Add(this.btn_CadastrarCliente);
            this.painelPossiveisCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelPossiveisCadastros.Location = new System.Drawing.Point(0, 94);
            this.painelPossiveisCadastros.Name = "painelPossiveisCadastros";
            this.painelPossiveisCadastros.Size = new System.Drawing.Size(180, 80);
            this.painelPossiveisCadastros.TabIndex = 6;
            // 
            // btn_CadastrarUsuario
            // 
            this.btn_CadastrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.btn_CadastrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadastrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_CadastrarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_CadastrarUsuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_CadastrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_CadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadastrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarUsuario.Location = new System.Drawing.Point(0, 40);
            this.btn_CadastrarUsuario.Name = "btn_CadastrarUsuario";
            this.btn_CadastrarUsuario.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_CadastrarUsuario.Size = new System.Drawing.Size(180, 40);
            this.btn_CadastrarUsuario.TabIndex = 1;
            this.btn_CadastrarUsuario.Text = "Cadastrar Usuário";
            this.btn_CadastrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastrarUsuario.UseVisualStyleBackColor = false;
            this.btn_CadastrarUsuario.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.btn_CadastrarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CadastrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_CadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btn_CadastrarCliente.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_CadastrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_CadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(0, 0);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(180, 40);
            this.btn_CadastrarCliente.TabIndex = 2;
            this.btn_CadastrarCliente.Text = "Cadastrar Cliente";
            this.btn_CadastrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CadastrarCliente.UseVisualStyleBackColor = false;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Cadastros
            // 
            this.btn_Cadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(45)))));
            this.btn_Cadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Cadastros.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Cadastros.FlatAppearance.BorderSize = 0;
            this.btn_Cadastros.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Cadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))), ((int)(((byte)(50)))));
            this.btn_Cadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastros.ForeColor = System.Drawing.Color.White;
            this.btn_Cadastros.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cadastros.Image")));
            this.btn_Cadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cadastros.Location = new System.Drawing.Point(0, 54);
            this.btn_Cadastros.Name = "btn_Cadastros";
            this.btn_Cadastros.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Cadastros.Size = new System.Drawing.Size(180, 40);
            this.btn_Cadastros.TabIndex = 0;
            this.btn_Cadastros.Text = "Cadastros";
            this.btn_Cadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastros.UseVisualStyleBackColor = false;
            this.btn_Cadastros.Click += new System.EventHandler(this.button7_Click);
            // 
            // painel_Logo
            // 
            this.painel_Logo.Controls.Add(this.lbl_nome);
            this.painel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painel_Logo.Location = new System.Drawing.Point(0, 0);
            this.painel_Logo.Name = "painel_Logo";
            this.painel_Logo.Size = new System.Drawing.Size(180, 54);
            this.painel_Logo.TabIndex = 6;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(47, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(82, 18);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "USUÁRIO";
            this.lbl_nome.Visible = false;
            // 
            // painel_VaiMudar
            // 
            this.painel_VaiMudar.BackColor = System.Drawing.Color.White;
            this.painel_VaiMudar.Controls.Add(this.Pb_Pesquisa);
            this.painel_VaiMudar.Controls.Add(this.Grid_Clientes);
            this.painel_VaiMudar.Controls.Add(this.tb_Hora);
            this.painel_VaiMudar.Controls.Add(this.lbl_DefinaHorario);
            this.painel_VaiMudar.Controls.Add(this.btn_Confirmar);
            this.painel_VaiMudar.Controls.Add(this.tb_Pesquisa);
            this.painel_VaiMudar.Controls.Add(this.iconeData2);
            this.painel_VaiMudar.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painel_VaiMudar.ForeColor = System.Drawing.Color.White;
            this.painel_VaiMudar.Location = new System.Drawing.Point(186, 1);
            this.painel_VaiMudar.Name = "painel_VaiMudar";
            this.painel_VaiMudar.Size = new System.Drawing.Size(749, 557);
            this.painel_VaiMudar.TabIndex = 29;
            this.painel_VaiMudar.Paint += new System.Windows.Forms.PaintEventHandler(this.painel_VaiMudar_Paint);
            // 
            // Grid_Clientes
            // 
            this.Grid_Clientes.AllowUserToAddRows = false;
            this.Grid_Clientes.AllowUserToResizeColumns = false;
            this.Grid_Clientes.AllowUserToResizeRows = false;
            this.Grid_Clientes.BackgroundColor = System.Drawing.Color.White;
            this.Grid_Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Grid_Clientes.ColumnHeadersHeight = 40;
            this.Grid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Grid_Clientes.EnableHeadersVisualStyles = false;
            this.Grid_Clientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(225)))), ((int)(((byte)(50)))));
            this.Grid_Clientes.Location = new System.Drawing.Point(3, 76);
            this.Grid_Clientes.Name = "Grid_Clientes";
            this.Grid_Clientes.ReadOnly = true;
            this.Grid_Clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 51.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Clientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Grid_Clientes.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.Grid_Clientes.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Grid_Clientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Clientes.Size = new System.Drawing.Size(743, 382);
            this.Grid_Clientes.TabIndex = 95;
            this.Grid_Clientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Consultas_CellContentClick);
            this.Grid_Clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Clientes_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Paciente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 123;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Usuário";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 123;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 124;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CPF";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 124;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Idade";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 124;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sexo";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 124;
            // 
            // tb_Hora
            // 
            this.tb_Hora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Hora.BackColor = System.Drawing.SystemColors.Window;
            this.tb_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Hora.ForeColor = System.Drawing.Color.LimeGreen;
            this.tb_Hora.Location = new System.Drawing.Point(371, 496);
            this.tb_Hora.Name = "tb_Hora";
            this.tb_Hora.Size = new System.Drawing.Size(102, 21);
            this.tb_Hora.TabIndex = 94;
            // 
            // lbl_DefinaHorario
            // 
            this.lbl_DefinaHorario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DefinaHorario.AutoSize = true;
            this.lbl_DefinaHorario.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_DefinaHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DefinaHorario.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_DefinaHorario.Location = new System.Drawing.Point(368, 477);
            this.lbl_DefinaHorario.Name = "lbl_DefinaHorario";
            this.lbl_DefinaHorario.Size = new System.Drawing.Size(65, 18);
            this.lbl_DefinaHorario.TabIndex = 93;
            this.lbl_DefinaHorario.Text = "Horário";
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
            this.btn_Confirmar.Location = new System.Drawing.Point(502, 477);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.OnHoverBorderColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.OnHoverButtonColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Confirmar.Size = new System.Drawing.Size(170, 40);
            this.btn_Confirmar.TabIndex = 92;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.TextColor = System.Drawing.Color.White;
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_Pesquisa.Location = new System.Drawing.Point(255, 44);
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(181, 21);
            this.tb_Pesquisa.TabIndex = 82;
            // 
            // iconeData2
            // 
            this.iconeData2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconeData2.BorderColor = System.Drawing.Color.LimeGreen;
            this.iconeData2.BorderSize = 0;
            this.iconeData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.iconeData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.iconeData2.Location = new System.Drawing.Point(82, 482);
            this.iconeData2.MinimumSize = new System.Drawing.Size(4, 35);
            this.iconeData2.Name = "iconeData2";
            this.iconeData2.Size = new System.Drawing.Size(251, 35);
            this.iconeData2.SkinColor = System.Drawing.Color.LimeGreen;
            this.iconeData2.TabIndex = 81;
            this.iconeData2.TextColor = System.Drawing.Color.White;
            // 
            // Pb_Pesquisa
            // 
            this.Pb_Pesquisa.BackColor = System.Drawing.Color.White;
            this.Pb_Pesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pb_Pesquisa.BackgroundImage")));
            this.Pb_Pesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pb_Pesquisa.Location = new System.Drawing.Point(442, 37);
            this.Pb_Pesquisa.Name = "Pb_Pesquisa";
            this.Pb_Pesquisa.Size = new System.Drawing.Size(31, 33);
            this.Pb_Pesquisa.TabIndex = 115;
            this.Pb_Pesquisa.TabStop = false;
            this.Pb_Pesquisa.Click += new System.EventHandler(this.Pb_Pesquisa_Click);
            // 
            // Principal_Nutricionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.painel_VaiMudar);
            this.Controls.Add(this.painelPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.Name = "Principal_Nutricionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_principal";
            this.Load += new System.EventHandler(this.Principal_Nutricionista_Load);
            this.painelPrincipal.ResumeLayout(false);
            this.painelAlteracoes.ResumeLayout(false);
            this.painelPossiveisCadastros.ResumeLayout(false);
            this.painel_Logo.ResumeLayout(false);
            this.painel_Logo.PerformLayout();
            this.painel_VaiMudar.ResumeLayout(false);
            this.painel_VaiMudar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelPrincipal;
        private System.Windows.Forms.Panel painelAlteracoes;
        private System.Windows.Forms.Button btn_AlterarInfoCliente;
        private System.Windows.Forms.Button btn_ExcluirCliente;
        private System.Windows.Forms.Button btn_Alteracoes;
        private System.Windows.Forms.Panel painelPossiveisCadastros;
        private System.Windows.Forms.Button btn_CadastrarUsuario;
        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.Button btn_Cadastros;
        private System.Windows.Forms.Panel painel_Logo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel painel_VaiMudar;
        private System.Windows.Forms.Button btn_VisualizarConsultas;
        private System.Windows.Forms.TextBox tb_Hora;
        private System.Windows.Forms.Label lbl_DefinaHorario;
        private ePOSOne.btnProduct.Button_WOC btn_Confirmar;
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private IconeData iconeData2;
        private System.Windows.Forms.DataGridView Grid_Clientes;
        private System.Windows.Forms.Button btn_PlanoAlimentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox Pb_Pesquisa;
    }
}