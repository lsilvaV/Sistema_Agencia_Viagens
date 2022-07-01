
namespace viagemProjeto.View.Pesquisar
{
    partial class PesquisarVen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxValorPago = new System.Windows.Forms.TextBox();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.btnDeletarVen = new System.Windows.Forms.Button();
            this.tbxCodPac = new System.Windows.Forms.TextBox();
            this.tbxCodFun = new System.Windows.Forms.TextBox();
            this.tbxCodCli = new System.Windows.Forms.TextBox();
            this.lblCodPac = new System.Windows.Forms.Label();
            this.lblCodFun = new System.Windows.Forms.Label();
            this.lblCodCli = new System.Windows.Forms.Label();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.tbxCodVen = new System.Windows.Forms.TextBox();
            this.lblCodVen = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 90);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 308);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbxValorPago);
            this.tabPage1.Controls.Add(this.lblValorPago);
            this.tabPage1.Controls.Add(this.btnDeletarVen);
            this.tabPage1.Controls.Add(this.tbxCodPac);
            this.tabPage1.Controls.Add(this.tbxCodFun);
            this.tabPage1.Controls.Add(this.tbxCodCli);
            this.tabPage1.Controls.Add(this.lblCodPac);
            this.tabPage1.Controls.Add(this.lblCodFun);
            this.tabPage1.Controls.Add(this.lblCodCli);
            this.tabPage1.Controls.Add(this.btnBuscarCod);
            this.tabPage1.Controls.Add(this.tbxCodVen);
            this.tabPage1.Controls.Add(this.lblCodVen);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbxValorPago
            // 
            this.tbxValorPago.Location = new System.Drawing.Point(178, 215);
            this.tbxValorPago.Name = "tbxValorPago";
            this.tbxValorPago.Size = new System.Drawing.Size(331, 22);
            this.tbxValorPago.TabIndex = 25;
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.BackColor = System.Drawing.Color.Transparent;
            this.lblValorPago.Location = new System.Drawing.Point(93, 218);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(79, 14);
            this.lblValorPago.TabIndex = 24;
            this.lblValorPago.Text = "Valor Pago:";
            // 
            // btnDeletarVen
            // 
            this.btnDeletarVen.Location = new System.Drawing.Point(434, 252);
            this.btnDeletarVen.Name = "btnDeletarVen";
            this.btnDeletarVen.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarVen.TabIndex = 23;
            this.btnDeletarVen.Text = "Deletar";
            this.btnDeletarVen.UseVisualStyleBackColor = true;
            this.btnDeletarVen.Click += new System.EventHandler(this.btnDeletarVen_Click);
            // 
            // tbxCodPac
            // 
            this.tbxCodPac.Location = new System.Drawing.Point(178, 172);
            this.tbxCodPac.Name = "tbxCodPac";
            this.tbxCodPac.Size = new System.Drawing.Size(331, 22);
            this.tbxCodPac.TabIndex = 17;
            // 
            // tbxCodFun
            // 
            this.tbxCodFun.Location = new System.Drawing.Point(177, 129);
            this.tbxCodFun.Name = "tbxCodFun";
            this.tbxCodFun.Size = new System.Drawing.Size(332, 22);
            this.tbxCodFun.TabIndex = 16;
            // 
            // tbxCodCli
            // 
            this.tbxCodCli.Location = new System.Drawing.Point(177, 86);
            this.tbxCodCli.Name = "tbxCodCli";
            this.tbxCodCli.Size = new System.Drawing.Size(332, 22);
            this.tbxCodCli.TabIndex = 15;
            // 
            // lblCodPac
            // 
            this.lblCodPac.AutoSize = true;
            this.lblCodPac.BackColor = System.Drawing.Color.Transparent;
            this.lblCodPac.Location = new System.Drawing.Point(53, 175);
            this.lblCodPac.Name = "lblCodPac";
            this.lblCodPac.Size = new System.Drawing.Size(123, 14);
            this.lblCodPac.TabIndex = 14;
            this.lblCodPac.Text = "Código do Pacote:";
            // 
            // lblCodFun
            // 
            this.lblCodFun.AutoSize = true;
            this.lblCodFun.BackColor = System.Drawing.Color.Transparent;
            this.lblCodFun.Location = new System.Drawing.Point(24, 132);
            this.lblCodFun.Name = "lblCodFun";
            this.lblCodFun.Size = new System.Drawing.Size(152, 14);
            this.lblCodFun.TabIndex = 13;
            this.lblCodFun.Text = "Código do Funcionário:";
            // 
            // lblCodCli
            // 
            this.lblCodCli.AutoSize = true;
            this.lblCodCli.BackColor = System.Drawing.Color.Transparent;
            this.lblCodCli.Location = new System.Drawing.Point(52, 89);
            this.lblCodCli.Name = "lblCodCli";
            this.lblCodCli.Size = new System.Drawing.Size(124, 14);
            this.lblCodCli.TabIndex = 12;
            this.lblCodCli.Text = "Código do Cliente:";
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Location = new System.Drawing.Point(490, 23);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarCod.TabIndex = 7;
            this.btnBuscarCod.Text = "Buscar";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // tbxCodVen
            // 
            this.tbxCodVen.Location = new System.Drawing.Point(112, 23);
            this.tbxCodVen.Name = "tbxCodVen";
            this.tbxCodVen.Size = new System.Drawing.Size(372, 22);
            this.tbxCodVen.TabIndex = 6;
            // 
            // lblCodVen
            // 
            this.lblCodVen.AutoSize = true;
            this.lblCodVen.Location = new System.Drawing.Point(3, 27);
            this.lblCodVen.Name = "lblCodVen";
            this.lblCodVen.Size = new System.Drawing.Size(108, 14);
            this.lblCodVen.TabIndex = 5;
            this.lblCodVen.Text = "Digite o Código:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(199, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Pesquisar Venda";
            // 
            // PesquisarVen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "PesquisarVen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Venda";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDeletarVen;
        private System.Windows.Forms.TextBox tbxCodPac;
        private System.Windows.Forms.TextBox tbxCodFun;
        private System.Windows.Forms.TextBox tbxCodCli;
        private System.Windows.Forms.Label lblCodPac;
        private System.Windows.Forms.Label lblCodFun;
        private System.Windows.Forms.Label lblCodCli;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox tbxCodVen;
        private System.Windows.Forms.Label lblCodVen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbxValorPago;
        private System.Windows.Forms.Label lblValorPago;
    }
}