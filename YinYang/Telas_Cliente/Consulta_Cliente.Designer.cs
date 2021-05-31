
namespace TG.Telas_Cliente
{
    partial class Consulta_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_Consultas = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.painel_menu = new System.Windows.Forms.Panel();
            this.btn_MeuPerfil = new System.Windows.Forms.Button();
            this.btn_Perfil = new System.Windows.Forms.Button();
            this.btn_MostrarClientes = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.painelConsulta = new System.Windows.Forms.Panel();
            this.lbl_Consultas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelNConsulta = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Consultas)).BeginInit();
            this.painel_menu.SuspendLayout();
            this.painelConsulta.SuspendLayout();
            this.painelNConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_Consultas
            // 
            this.Grid_Consultas.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.Grid_Consultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(225)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Consultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Grid_Consultas.ColumnHeadersHeight = 40;
            this.Grid_Consultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_Consultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.Grid_Consultas.EnableHeadersVisualStyles = false;
            this.Grid_Consultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(225)))), ((int)(((byte)(50)))));
            this.Grid_Consultas.Location = new System.Drawing.Point(261, 213);
            this.Grid_Consultas.Name = "Grid_Consultas";
            this.Grid_Consultas.ReadOnly = true;
            this.Grid_Consultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Consultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Grid_Consultas.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(225)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.Grid_Consultas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Grid_Consultas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Consultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Consultas.Size = new System.Drawing.Size(590, 234);
            this.Grid_Consultas.TabIndex = 48;
            this.Grid_Consultas.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Consulta";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "ID Paciente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 102;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Paciente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 92;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Data da Consulta";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 137;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "Horário da Consulta";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 154;
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
            // painelConsulta
            // 
            this.painelConsulta.BackColor = System.Drawing.Color.White;
            this.painelConsulta.Controls.Add(this.lbl_Consultas);
            this.painelConsulta.ForeColor = System.Drawing.Color.LimeGreen;
            this.painelConsulta.Location = new System.Drawing.Point(183, 107);
            this.painelConsulta.Name = "painelConsulta";
            this.painelConsulta.Size = new System.Drawing.Size(751, 100);
            this.painelConsulta.TabIndex = 47;
            this.painelConsulta.Visible = false;
            // 
            // lbl_Consultas
            // 
            this.lbl_Consultas.AutoSize = true;
            this.lbl_Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Consultas.Location = new System.Drawing.Point(252, 17);
            this.lbl_Consultas.Name = "lbl_Consultas";
            this.lbl_Consultas.Size = new System.Drawing.Size(222, 55);
            this.lbl_Consultas.TabIndex = 45;
            this.lbl_Consultas.Text = "Consulta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 42);
            this.label1.TabIndex = 45;
            this.label1.Text = "Você Não Possui Consulta Marcada";
            // 
            // painelNConsulta
            // 
            this.painelNConsulta.BackColor = System.Drawing.Color.White;
            this.painelNConsulta.Controls.Add(this.label1);
            this.painelNConsulta.ForeColor = System.Drawing.Color.LimeGreen;
            this.painelNConsulta.Location = new System.Drawing.Point(183, 1);
            this.painelNConsulta.Name = "painelNConsulta";
            this.painelNConsulta.Size = new System.Drawing.Size(751, 100);
            this.painelNConsulta.TabIndex = 138;
            this.painelNConsulta.Visible = false;
            // 
            // Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.painelNConsulta);
            this.Controls.Add(this.painelConsulta);
            this.Controls.Add(this.painel_menu);
            this.Controls.Add(this.Grid_Consultas);
            this.Name = "Consulta_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta_Cliente";
            this.Load += new System.EventHandler(this.Consulta_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Consultas)).EndInit();
            this.painel_menu.ResumeLayout(false);
            this.painelConsulta.ResumeLayout(false);
            this.painelConsulta.PerformLayout();
            this.painelNConsulta.ResumeLayout(false);
            this.painelNConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Consultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel painel_menu;
        private System.Windows.Forms.Button btn_MeuPerfil;
        private System.Windows.Forms.Button btn_Perfil;
        private System.Windows.Forms.Button btn_MostrarClientes;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel painelConsulta;
        private System.Windows.Forms.Label lbl_Consultas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel painelNConsulta;
    }
}