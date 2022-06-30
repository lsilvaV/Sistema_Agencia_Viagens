
namespace viagemProjeto.View.Pesquisar
{
    partial class PesquisarFun
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFun = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnDeletarFun = new System.Windows.Forms.Button();
            this.btnAlterarFun = new System.Windows.Forms.Button();
            this.tbxSenhaFun = new System.Windows.Forms.TextBox();
            this.tbxNomeFun = new System.Windows.Forms.TextBox();
            this.lblSenhaFun = new System.Windows.Forms.Label();
            this.tbxEmailFun = new System.Windows.Forms.TextBox();
            this.lblEmailFun = new System.Windows.Forms.Label();
            this.lblNomeFun = new System.Windows.Forms.Label();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.tbxCod = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCod = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFun)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvFun);
            this.tabPage2.Controls.Add(this.btnBuscarNome);
            this.tabPage2.Controls.Add(this.tbxNome);
            this.tabPage2.Controls.Add(this.lblNome);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nome";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFun
            // 
            this.dgvFun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.email});
            this.dgvFun.Location = new System.Drawing.Point(0, 64);
            this.dgvFun.Name = "dgvFun";
            this.dgvFun.RowHeadersVisible = false;
            this.dgvFun.RowTemplate.Height = 25;
            this.dgvFun.Size = new System.Drawing.Size(592, 200);
            this.dgvFun.TabIndex = 5;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Location = new System.Drawing.Point(490, 20);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(96, 23);
            this.btnBuscarNome.TabIndex = 4;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(112, 20);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(372, 22);
            this.tbxNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 14);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Digite o Nome:";
            // 
            // btnDeletarFun
            // 
            this.btnDeletarFun.Location = new System.Drawing.Point(409, 212);
            this.btnDeletarFun.Name = "btnDeletarFun";
            this.btnDeletarFun.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarFun.TabIndex = 23;
            this.btnDeletarFun.Text = "Deletar";
            this.btnDeletarFun.UseVisualStyleBackColor = true;
            this.btnDeletarFun.Click += new System.EventHandler(this.btnDeletarFun_Click);
            // 
            // btnAlterarFun
            // 
            this.btnAlterarFun.Location = new System.Drawing.Point(328, 212);
            this.btnAlterarFun.Name = "btnAlterarFun";
            this.btnAlterarFun.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFun.TabIndex = 22;
            this.btnAlterarFun.Text = "Alterar";
            this.btnAlterarFun.UseVisualStyleBackColor = true;
            this.btnAlterarFun.Click += new System.EventHandler(this.btnAlterarFun_Click);
            // 
            // tbxSenhaFun
            // 
            this.tbxSenhaFun.Location = new System.Drawing.Point(153, 164);
            this.tbxSenhaFun.Name = "tbxSenhaFun";
            this.tbxSenhaFun.Size = new System.Drawing.Size(331, 22);
            this.tbxSenhaFun.TabIndex = 17;
            // 
            // tbxNomeFun
            // 
            this.tbxNomeFun.Location = new System.Drawing.Point(152, 78);
            this.tbxNomeFun.Name = "tbxNomeFun";
            this.tbxNomeFun.Size = new System.Drawing.Size(332, 22);
            this.tbxNomeFun.TabIndex = 15;
            // 
            // lblSenhaFun
            // 
            this.lblSenhaFun.AutoSize = true;
            this.lblSenhaFun.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaFun.Location = new System.Drawing.Point(98, 170);
            this.lblSenhaFun.Name = "lblSenhaFun";
            this.lblSenhaFun.Size = new System.Drawing.Size(52, 14);
            this.lblSenhaFun.TabIndex = 14;
            this.lblSenhaFun.Text = "Senha:";
            // 
            // tbxEmailFun
            // 
            this.tbxEmailFun.Location = new System.Drawing.Point(152, 121);
            this.tbxEmailFun.Name = "tbxEmailFun";
            this.tbxEmailFun.Size = new System.Drawing.Size(332, 22);
            this.tbxEmailFun.TabIndex = 16;
            // 
            // lblEmailFun
            // 
            this.lblEmailFun.AutoSize = true;
            this.lblEmailFun.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailFun.Location = new System.Drawing.Point(102, 127);
            this.lblEmailFun.Name = "lblEmailFun";
            this.lblEmailFun.Size = new System.Drawing.Size(50, 14);
            this.lblEmailFun.TabIndex = 13;
            this.lblEmailFun.Text = "E-mail:";
            // 
            // lblNomeFun
            // 
            this.lblNomeFun.AutoSize = true;
            this.lblNomeFun.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFun.Location = new System.Drawing.Point(102, 84);
            this.lblNomeFun.Name = "lblNomeFun";
            this.lblNomeFun.Size = new System.Drawing.Size(48, 14);
            this.lblNomeFun.TabIndex = 12;
            this.lblNomeFun.Text = "Nome:";
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
            // tbxCod
            // 
            this.tbxCod.Location = new System.Drawing.Point(112, 23);
            this.tbxCod.Name = "tbxCod";
            this.tbxCod.Size = new System.Drawing.Size(372, 22);
            this.tbxCod.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeletarFun);
            this.tabPage1.Controls.Add(this.btnAlterarFun);
            this.tabPage1.Controls.Add(this.tbxSenhaFun);
            this.tabPage1.Controls.Add(this.tbxEmailFun);
            this.tabPage1.Controls.Add(this.tbxNomeFun);
            this.tabPage1.Controls.Add(this.lblSenhaFun);
            this.tabPage1.Controls.Add(this.lblEmailFun);
            this.tabPage1.Controls.Add(this.lblNomeFun);
            this.tabPage1.Controls.Add(this.btnBuscarCod);
            this.tabPage1.Controls.Add(this.tbxCod);
            this.tabPage1.Controls.Add(this.lblCod);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 29);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(108, 14);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Digite o Código:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 308);
            this.tabControl1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(168, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(324, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Pesquisar Funcionários";
            // 
            // PesquisarFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "PesquisarFun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Funcionários";
            this.Load += new System.EventHandler(this.PesquisarFun_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFun)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFun;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnDeletarFun;
        private System.Windows.Forms.Button btnAlterarFun;
        private System.Windows.Forms.TextBox tbxSenhaFun;
        private System.Windows.Forms.TextBox tbxNomeFun;
        private System.Windows.Forms.Label lblSenhaFun;
        private System.Windows.Forms.TextBox tbxEmailFun;
        private System.Windows.Forms.Label lblEmailFun;
        private System.Windows.Forms.Label lblNomeFun;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox tbxCod;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}