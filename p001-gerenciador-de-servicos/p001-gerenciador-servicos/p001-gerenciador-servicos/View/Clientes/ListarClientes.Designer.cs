namespace p001_gerenciador_servicos
{
    partial class ListarClientes
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
            this.listViewCLI = new System.Windows.Forms.ListView();
            this.CLI_COD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLI_NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLI_SNOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLI_CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLI_EMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLI_CELULAR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.tb_listar_cliente_cod = new System.Windows.Forms.TextBox();
            this.bttn_listar_cliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE CLIENTES";
            // 
            // listViewCLI
            // 
            this.listViewCLI.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLI_COD,
            this.CLI_NOME,
            this.CLI_SNOME,
            this.CLI_CPF,
            this.CLI_EMAIL,
            this.CLI_CELULAR});
            this.listViewCLI.Location = new System.Drawing.Point(12, 130);
            this.listViewCLI.Name = "listViewCLI";
            this.listViewCLI.Size = new System.Drawing.Size(753, 384);
            this.listViewCLI.TabIndex = 1;
            this.listViewCLI.UseCompatibleStateImageBehavior = false;
            this.listViewCLI.View = System.Windows.Forms.View.Details;
            // 
            // CLI_COD
            // 
            this.CLI_COD.Text = "#";
            this.CLI_COD.Width = 40;
            // 
            // CLI_NOME
            // 
            this.CLI_NOME.Text = "Nome";
            this.CLI_NOME.Width = 130;
            // 
            // CLI_SNOME
            // 
            this.CLI_SNOME.Text = "Sobrenome";
            this.CLI_SNOME.Width = 130;
            // 
            // CLI_CPF
            // 
            this.CLI_CPF.DisplayIndex = 4;
            this.CLI_CPF.Text = "CPF";
            this.CLI_CPF.Width = 150;
            // 
            // CLI_EMAIL
            // 
            this.CLI_EMAIL.DisplayIndex = 3;
            this.CLI_EMAIL.Text = "E-Mail";
            this.CLI_EMAIL.Width = 170;
            // 
            // CLI_CELULAR
            // 
            this.CLI_CELULAR.Text = "Celular";
            this.CLI_CELULAR.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecionar registro:";
            // 
            // tb_listar_cliente_cod
            // 
            this.tb_listar_cliente_cod.Location = new System.Drawing.Point(112, 89);
            this.tb_listar_cliente_cod.Name = "tb_listar_cliente_cod";
            this.tb_listar_cliente_cod.Size = new System.Drawing.Size(58, 20);
            this.tb_listar_cliente_cod.TabIndex = 3;
            // 
            // bttn_listar_cliente
            // 
            this.bttn_listar_cliente.Location = new System.Drawing.Point(189, 86);
            this.bttn_listar_cliente.Name = "bttn_listar_cliente";
            this.bttn_listar_cliente.Size = new System.Drawing.Size(47, 23);
            this.bttn_listar_cliente.TabIndex = 4;
            this.bttn_listar_cliente.Text = "Listar";
            this.bttn_listar_cliente.UseVisualStyleBackColor = true;
            this.bttn_listar_cliente.Click += new System.EventHandler(this.bttn_listar_cliente_Click);
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 526);
            this.Controls.Add(this.bttn_listar_cliente);
            this.Controls.Add(this.tb_listar_cliente_cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewCLI);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ListarClientes";
            this.Load += new System.EventHandler(this.ListarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewCLI;
        private System.Windows.Forms.ColumnHeader CLI_COD;
        private System.Windows.Forms.ColumnHeader CLI_NOME;
        private System.Windows.Forms.ColumnHeader CLI_SNOME;
        private System.Windows.Forms.ColumnHeader CLI_EMAIL;
        private System.Windows.Forms.ColumnHeader CLI_CPF;
        private System.Windows.Forms.ColumnHeader CLI_CELULAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_listar_cliente_cod;
        private System.Windows.Forms.Button bttn_listar_cliente;
    }
}