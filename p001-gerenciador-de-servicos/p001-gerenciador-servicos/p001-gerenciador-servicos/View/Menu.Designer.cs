namespace p001_gerenciador_servicos
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROFISSIONAISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sERVIÇOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRARTRABALHOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.pROFISSIONAISToolStripMenuItem,
            this.sERVIÇOSToolStripMenuItem,
            this.rELATORIOSToolStripMenuItem,
            this.rEGISTRARTRABALHOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.lISTARToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            this.cADASTRARToolStripMenuItem.Click += new System.EventHandler(this.cADASTRARToolStripMenuItem_Click);
            // 
            // lISTARToolStripMenuItem
            // 
            this.lISTARToolStripMenuItem.Name = "lISTARToolStripMenuItem";
            this.lISTARToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.lISTARToolStripMenuItem.Text = "LISTAR";
            this.lISTARToolStripMenuItem.Click += new System.EventHandler(this.lISTARToolStripMenuItem_Click);
            // 
            // pROFISSIONAISToolStripMenuItem
            // 
            this.pROFISSIONAISToolStripMenuItem.Name = "pROFISSIONAISToolStripMenuItem";
            this.pROFISSIONAISToolStripMenuItem.Size = new System.Drawing.Size(134, 25);
            this.pROFISSIONAISToolStripMenuItem.Text = "PROFISSIONAIS";
            this.pROFISSIONAISToolStripMenuItem.Click += new System.EventHandler(this.pROFISSIONAISToolStripMenuItem_Click);
            // 
            // sERVIÇOSToolStripMenuItem
            // 
            this.sERVIÇOSToolStripMenuItem.Name = "sERVIÇOSToolStripMenuItem";
            this.sERVIÇOSToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.sERVIÇOSToolStripMenuItem.Text = "SERVIÇOS";
            // 
            // rELATORIOSToolStripMenuItem
            // 
            this.rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
            this.rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(111, 25);
            this.rELATORIOSToolStripMenuItem.Text = "RELATORIOS";
            // 
            // rEGISTRARTRABALHOToolStripMenuItem
            // 
            this.rEGISTRARTRABALHOToolStripMenuItem.Name = "rEGISTRARTRABALHOToolStripMenuItem";
            this.rEGISTRARTRABALHOToolStripMenuItem.Size = new System.Drawing.Size(184, 25);
            this.rEGISTRARTRABALHOToolStripMenuItem.Text = "REGISTRAR TRABALHO";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROFISSIONAISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sERVIÇOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARTRABALHOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTARToolStripMenuItem;
    }
}

