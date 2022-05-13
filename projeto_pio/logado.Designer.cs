namespace projeto_pio
{
    partial class logado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logado));
            this.tabela_dados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nome_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha_grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_dados
            // 
            this.tabela_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_grid,
            this.celular_grid,
            this.email_grid,
            this.endereco_grid,
            this.numero_grid,
            this.cpf_grid,
            this.senha_grid});
            this.tabela_dados.Location = new System.Drawing.Point(64, 84);
            this.tabela_dados.Name = "tabela_dados";
            this.tabela_dados.RowTemplate.Height = 25;
            this.tabela_dados.Size = new System.Drawing.Size(560, 133);
            this.tabela_dados.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 39);
            this.label1.TabIndex = 32;
            this.label1.Text = "Meus Dados";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(419, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 72);
            this.button4.TabIndex = 37;
            this.button4.Text = "Consultar";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(347, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 72);
            this.button3.TabIndex = 36;
            this.button3.Text = "Listar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(276, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 72);
            this.button2.TabIndex = 35;
            this.button2.Text = "Excluir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(205, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 72);
            this.button1.TabIndex = 34;
            this.button1.Text = "Alterar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 38;
            this.button5.Text = "SAIR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // nome_grid
            // 
            this.nome_grid.HeaderText = "Nome";
            this.nome_grid.Name = "nome_grid";
            // 
            // celular_grid
            // 
            this.celular_grid.HeaderText = "Celular";
            this.celular_grid.Name = "celular_grid";
            // 
            // email_grid
            // 
            this.email_grid.HeaderText = "Email";
            this.email_grid.Name = "email_grid";
            // 
            // endereco_grid
            // 
            this.endereco_grid.HeaderText = "Endereço";
            this.endereco_grid.Name = "endereco_grid";
            // 
            // numero_grid
            // 
            this.numero_grid.HeaderText = "Numero";
            this.numero_grid.Name = "numero_grid";
            // 
            // cpf_grid
            // 
            this.cpf_grid.HeaderText = "CPF";
            this.cpf_grid.Name = "cpf_grid";
            // 
            // senha_grid
            // 
            this.senha_grid.HeaderText = "Senha";
            this.senha_grid.Name = "senha_grid";
            // 
            // logado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tabela_dados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "logado";
            this.Text = "logado";
            ((System.ComponentModel.ISupportInitialize)(this.tabela_dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha_grid;
    }
}