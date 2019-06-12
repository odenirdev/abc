namespace p001_gerenciador_servicos
{
    partial class CadCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_snome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bttn_cadcliente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.mtb_nome = new System.Windows.Forms.MaskedTextBox();
            this.mtb_email = new System.Windows.Forms.MaskedTextBox();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtb_snome = new System.Windows.Forms.MaskedTextBox();
            this.mtb_cidade = new System.Windows.Forms.MaskedTextBox();
            this.mtb_endereco = new System.Windows.Forms.MaskedTextBox();
            this.mtb_numero = new System.Windows.Forms.MaskedTextBox();
            this.mtb_complemento = new System.Windows.Forms.MaskedTextBox();
            this.lb_nome_err = new System.Windows.Forms.Label();
            this.lb_snome_err = new System.Windows.Forms.Label();
            this.lb_cpf_err = new System.Windows.Forms.Label();
            this.lb_email_err = new System.Windows.Forms.Label();
            this.lb_celular_err = new System.Windows.Forms.Label();
            this.lb_cidade_err = new System.Windows.Forms.Label();
            this.lb_endereco_err = new System.Windows.Forms.Label();
            this.lb_numero_err = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRAR CLIENTE";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(20, 105);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(55, 20);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "Nome:";
            // 
            // lb_snome
            // 
            this.lb_snome.AutoSize = true;
            this.lb_snome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_snome.Location = new System.Drawing.Point(376, 105);
            this.lb_snome.Name = "lb_snome";
            this.lb_snome.Size = new System.Drawing.Size(96, 20);
            this.lb_snome.TabIndex = 3;
            this.lb_snome.Text = "Sobrenome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "E-Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "DADOS PESSOAIS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Endereço:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "N.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Comp.:";
            // 
            // bttn_cadcliente
            // 
            this.bttn_cadcliente.Location = new System.Drawing.Point(319, 413);
            this.bttn_cadcliente.Name = "bttn_cadcliente";
            this.bttn_cadcliente.Size = new System.Drawing.Size(139, 70);
            this.bttn_cadcliente.TabIndex = 22;
            this.bttn_cadcliente.Text = "CADASTRAR";
            this.bttn_cadcliente.UseVisualStyleBackColor = true;
            this.bttn_cadcliente.Click += new System.EventHandler(this.bttn_cadcliente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "ENDEREÇO";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(73, 142);
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(298, 20);
            this.mtb_cpf.TabIndex = 24;
            // 
            // mtb_nome
            // 
            this.mtb_nome.Location = new System.Drawing.Point(73, 107);
            this.mtb_nome.Name = "mtb_nome";
            this.mtb_nome.Size = new System.Drawing.Size(298, 20);
            this.mtb_nome.TabIndex = 25;
            // 
            // mtb_email
            // 
            this.mtb_email.Location = new System.Drawing.Point(83, 173);
            this.mtb_email.Name = "mtb_email";
            this.mtb_email.Size = new System.Drawing.Size(288, 20);
            this.mtb_email.TabIndex = 26;
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(101, 208);
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(269, 20);
            this.mtb_telefone.TabIndex = 27;
            // 
            // mtb_celular
            // 
            this.mtb_celular.Location = new System.Drawing.Point(84, 241);
            this.mtb_celular.Name = "mtb_celular";
            this.mtb_celular.Size = new System.Drawing.Size(287, 20);
            this.mtb_celular.TabIndex = 28;
            // 
            // mtb_snome
            // 
            this.mtb_snome.Location = new System.Drawing.Point(478, 107);
            this.mtb_snome.Name = "mtb_snome";
            this.mtb_snome.Size = new System.Drawing.Size(269, 20);
            this.mtb_snome.TabIndex = 29;
            // 
            // mtb_cidade
            // 
            this.mtb_cidade.Location = new System.Drawing.Point(84, 313);
            this.mtb_cidade.Name = "mtb_cidade";
            this.mtb_cidade.Size = new System.Drawing.Size(282, 20);
            this.mtb_cidade.TabIndex = 30;
            // 
            // mtb_endereco
            // 
            this.mtb_endereco.Location = new System.Drawing.Point(96, 362);
            this.mtb_endereco.Name = "mtb_endereco";
            this.mtb_endereco.Size = new System.Drawing.Size(269, 20);
            this.mtb_endereco.TabIndex = 31;
            // 
            // mtb_numero
            // 
            this.mtb_numero.Location = new System.Drawing.Point(405, 362);
            this.mtb_numero.Name = "mtb_numero";
            this.mtb_numero.Size = new System.Drawing.Size(92, 20);
            this.mtb_numero.TabIndex = 32;
            // 
            // mtb_complemento
            // 
            this.mtb_complemento.Location = new System.Drawing.Point(568, 364);
            this.mtb_complemento.Name = "mtb_complemento";
            this.mtb_complemento.Size = new System.Drawing.Size(174, 20);
            this.mtb_complemento.TabIndex = 33;
            // 
            // lb_nome_err
            // 
            this.lb_nome_err.AutoSize = true;
            this.lb_nome_err.ForeColor = System.Drawing.Color.Red;
            this.lb_nome_err.Location = new System.Drawing.Point(22, 92);
            this.lb_nome_err.Name = "lb_nome_err";
            this.lb_nome_err.Size = new System.Drawing.Size(11, 13);
            this.lb_nome_err.TabIndex = 34;
            this.lb_nome_err.Text = "*";
            // 
            // lb_snome_err
            // 
            this.lb_snome_err.AutoSize = true;
            this.lb_snome_err.ForeColor = System.Drawing.Color.Red;
            this.lb_snome_err.Location = new System.Drawing.Point(377, 92);
            this.lb_snome_err.Name = "lb_snome_err";
            this.lb_snome_err.Size = new System.Drawing.Size(11, 13);
            this.lb_snome_err.TabIndex = 35;
            this.lb_snome_err.Text = "*";
            // 
            // lb_cpf_err
            // 
            this.lb_cpf_err.AutoSize = true;
            this.lb_cpf_err.ForeColor = System.Drawing.Color.Red;
            this.lb_cpf_err.Location = new System.Drawing.Point(22, 129);
            this.lb_cpf_err.Name = "lb_cpf_err";
            this.lb_cpf_err.Size = new System.Drawing.Size(11, 13);
            this.lb_cpf_err.TabIndex = 36;
            this.lb_cpf_err.Text = "*";
            // 
            // lb_email_err
            // 
            this.lb_email_err.AutoSize = true;
            this.lb_email_err.ForeColor = System.Drawing.Color.Red;
            this.lb_email_err.Location = new System.Drawing.Point(22, 162);
            this.lb_email_err.Name = "lb_email_err";
            this.lb_email_err.Size = new System.Drawing.Size(11, 13);
            this.lb_email_err.TabIndex = 37;
            this.lb_email_err.Text = "*";
            // 
            // lb_celular_err
            // 
            this.lb_celular_err.AutoSize = true;
            this.lb_celular_err.ForeColor = System.Drawing.Color.Red;
            this.lb_celular_err.Location = new System.Drawing.Point(22, 228);
            this.lb_celular_err.Name = "lb_celular_err";
            this.lb_celular_err.Size = new System.Drawing.Size(11, 13);
            this.lb_celular_err.TabIndex = 39;
            this.lb_celular_err.Text = "*";
            // 
            // lb_cidade_err
            // 
            this.lb_cidade_err.AutoSize = true;
            this.lb_cidade_err.ForeColor = System.Drawing.Color.Red;
            this.lb_cidade_err.Location = new System.Drawing.Point(22, 298);
            this.lb_cidade_err.Name = "lb_cidade_err";
            this.lb_cidade_err.Size = new System.Drawing.Size(11, 13);
            this.lb_cidade_err.TabIndex = 40;
            this.lb_cidade_err.Text = "*";
            // 
            // lb_endereco_err
            // 
            this.lb_endereco_err.AutoSize = true;
            this.lb_endereco_err.ForeColor = System.Drawing.Color.Red;
            this.lb_endereco_err.Location = new System.Drawing.Point(22, 347);
            this.lb_endereco_err.Name = "lb_endereco_err";
            this.lb_endereco_err.Size = new System.Drawing.Size(11, 13);
            this.lb_endereco_err.TabIndex = 41;
            this.lb_endereco_err.Text = "*";
            // 
            // lb_numero_err
            // 
            this.lb_numero_err.AutoSize = true;
            this.lb_numero_err.ForeColor = System.Drawing.Color.Red;
            this.lb_numero_err.Location = new System.Drawing.Point(372, 347);
            this.lb_numero_err.Name = "lb_numero_err";
            this.lb_numero_err.Size = new System.Drawing.Size(11, 13);
            this.lb_numero_err.TabIndex = 42;
            this.lb_numero_err.Text = "*";
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.lb_numero_err);
            this.Controls.Add(this.lb_endereco_err);
            this.Controls.Add(this.lb_cidade_err);
            this.Controls.Add(this.lb_celular_err);
            this.Controls.Add(this.lb_email_err);
            this.Controls.Add(this.lb_cpf_err);
            this.Controls.Add(this.lb_snome_err);
            this.Controls.Add(this.lb_nome_err);
            this.Controls.Add(this.mtb_complemento);
            this.Controls.Add(this.mtb_numero);
            this.Controls.Add(this.mtb_endereco);
            this.Controls.Add(this.mtb_cidade);
            this.Controls.Add(this.mtb_snome);
            this.Controls.Add(this.mtb_celular);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.mtb_email);
            this.Controls.Add(this.mtb_nome);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttn_cadcliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_snome);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CadCliente";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_snome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bttn_cadcliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.MaskedTextBox mtb_nome;
        private System.Windows.Forms.MaskedTextBox mtb_email;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.MaskedTextBox mtb_celular;
        private System.Windows.Forms.MaskedTextBox mtb_snome;
        private System.Windows.Forms.MaskedTextBox mtb_cidade;
        private System.Windows.Forms.MaskedTextBox mtb_endereco;
        private System.Windows.Forms.MaskedTextBox mtb_numero;
        private System.Windows.Forms.MaskedTextBox mtb_complemento;
        private System.Windows.Forms.Label lb_nome_err;
        private System.Windows.Forms.Label lb_snome_err;
        private System.Windows.Forms.Label lb_cpf_err;
        private System.Windows.Forms.Label lb_email_err;
        private System.Windows.Forms.Label lb_celular_err;
        private System.Windows.Forms.Label lb_cidade_err;
        private System.Windows.Forms.Label lb_endereco_err;
        private System.Windows.Forms.Label lb_numero_err;
    }
}