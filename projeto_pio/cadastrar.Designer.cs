﻿
namespace projeto_pio
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            this.mask__telefone = new System.Windows.Forms.MaskedTextBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_endereço = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mask__telefone
            // 
            this.mask__telefone.Location = new System.Drawing.Point(158, 129);
            this.mask__telefone.Mask = "(00)0000-0000";
            this.mask__telefone.Name = "mask__telefone";
            this.mask__telefone.Size = new System.Drawing.Size(76, 23);
            this.mask__telefone.TabIndex = 46;
            // 
            // mask_celular
            // 
            this.mask_celular.Location = new System.Drawing.Point(372, 129);
            this.mask_celular.Mask = "(00)00000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(80, 23);
            this.mask_celular.TabIndex = 45;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inserir.Image = ((System.Drawing.Image)(resources.GetObject("btn_inserir.Image")));
            this.btn_inserir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_inserir.Location = new System.Drawing.Point(388, 299);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(55, 63);
            this.btn_inserir.TabIndex = 44;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(158, 307);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(208, 23);
            this.txt_senha.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Senha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(213, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 27);
            this.label10.TabIndex = 41;
            this.label10.Text = "Cadastro de usuario";
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(158, 270);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(108, 23);
            this.txt_rg.TabIndex = 40;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(342, 270);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(110, 23);
            this.txt_cpf.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "RG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "CPF:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(297, 238);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(155, 23);
            this.txt_bairro.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Bairro:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(158, 238);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(86, 23);
            this.txt_numero.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Numero:";
            // 
            // txt_endereço
            // 
            this.txt_endereço.Location = new System.Drawing.Point(158, 204);
            this.txt_endereço.Name = "txt_endereço";
            this.txt_endereço.Size = new System.Drawing.Size(294, 23);
            this.txt_endereço.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Endereço:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(158, 167);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(294, 23);
            this.txt_email.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Celular:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Telefone:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(158, 88);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(294, 23);
            this.txt_nome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nome Completo:";
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mask__telefone);
            this.Controls.Add(this.mask_celular);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_rg);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_endereço);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mask__telefone;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_endereço;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
    }
}