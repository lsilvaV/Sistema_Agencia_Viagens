
namespace viagemProjeto.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCli = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarCli = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFun = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarFun = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarFun = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPac = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastrarPac = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarPac = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegistrarVen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCli,
            this.btnFun,
            this.btnPac,
            this.btnVen,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCli
            // 
            this.btnCli.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarCli,
            this.btnPesquisarCli});
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(63, 20);
            this.btnCli.Text = "&Cliente";
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrarCli.Text = "Cadastrar";
            this.btnCadastrarCli.Click += new System.EventHandler(this.btnCadastrarCli_Click);
            // 
            // btnPesquisarCli
            // 
            this.btnPesquisarCli.Name = "btnPesquisarCli";
            this.btnPesquisarCli.Size = new System.Drawing.Size(180, 22);
            this.btnPesquisarCli.Text = "Pesquisar";
            // 
            // btnFun
            // 
            this.btnFun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarFun,
            this.btnPesquisarFun});
            this.btnFun.Name = "btnFun";
            this.btnFun.Size = new System.Drawing.Size(91, 20);
            this.btnFun.Text = "&Funcionário";
            // 
            // btnCadastrarFun
            // 
            this.btnCadastrarFun.Name = "btnCadastrarFun";
            this.btnCadastrarFun.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrarFun.Text = "Cadastrar";
            this.btnCadastrarFun.Click += new System.EventHandler(this.btnCadastrarFun_Click);
            // 
            // btnPesquisarFun
            // 
            this.btnPesquisarFun.Name = "btnPesquisarFun";
            this.btnPesquisarFun.Size = new System.Drawing.Size(180, 22);
            this.btnPesquisarFun.Text = "Pesquisar";
            // 
            // btnPac
            // 
            this.btnPac.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarPac,
            this.btnPesquisarPac});
            this.btnPac.Name = "btnPac";
            this.btnPac.Size = new System.Drawing.Size(62, 20);
            this.btnPac.Text = "&Pacote";
            // 
            // btnCadastrarPac
            // 
            this.btnCadastrarPac.Name = "btnCadastrarPac";
            this.btnCadastrarPac.Size = new System.Drawing.Size(180, 22);
            this.btnCadastrarPac.Text = "Cadastrar";
            this.btnCadastrarPac.Click += new System.EventHandler(this.btnCadastrarPac_Click);
            // 
            // btnPesquisarPac
            // 
            this.btnPesquisarPac.Name = "btnPesquisarPac";
            this.btnPesquisarPac.Size = new System.Drawing.Size(180, 22);
            this.btnPesquisarPac.Text = "Pesquisar";
            // 
            // btnVen
            // 
            this.btnVen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarVen});
            this.btnVen.Name = "btnVen";
            this.btnVen.Size = new System.Drawing.Size(58, 20);
            this.btnVen.Text = "&Venda";
            // 
            // btnRegistrarVen
            // 
            this.btnRegistrarVen.Name = "btnRegistrarVen";
            this.btnRegistrarVen.Size = new System.Drawing.Size(180, 22);
            this.btnRegistrarVen.Text = "Registrar";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(43, 20);
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema - Agência de Viagens";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCli;
        private System.Windows.Forms.ToolStripMenuItem btnFun;
        private System.Windows.Forms.ToolStripMenuItem btnPac;
        private System.Windows.Forms.ToolStripMenuItem btnVen;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarCli;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisarCli;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarFun;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisarFun;
        private System.Windows.Forms.ToolStripMenuItem btnCadastrarPac;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisarPac;
        private System.Windows.Forms.ToolStripMenuItem btnRegistrarVen;
    }
}