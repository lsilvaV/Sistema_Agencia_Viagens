
namespace viagemProjeto.View.Pesquisar
{
    partial class PesquisarCliente
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.btnAlterarCli = new System.Windows.Forms.Button();
            this.lblBuscarCli = new System.Windows.Forms.Label();
            this.btnBuscarImg = new System.Windows.Forms.Button();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.tbxSenhaCli = new System.Windows.Forms.TextBox();
            this.tbxEmailCli = new System.Windows.Forms.TextBox();
            this.tbxNomeCli = new System.Windows.Forms.TextBox();
            this.lblSenhaCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.tbxCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.ofdImg = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(182, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pesquisar Clientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 308);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeletarCli);
            this.tabPage1.Controls.Add(this.btnAlterarCli);
            this.tabPage1.Controls.Add(this.lblBuscarCli);
            this.tabPage1.Controls.Add(this.btnBuscarImg);
            this.tabPage1.Controls.Add(this.pbxImg);
            this.tabPage1.Controls.Add(this.tbxSenhaCli);
            this.tabPage1.Controls.Add(this.tbxEmailCli);
            this.tabPage1.Controls.Add(this.tbxNomeCli);
            this.tabPage1.Controls.Add(this.lblSenhaCli);
            this.tabPage1.Controls.Add(this.lblEmailCli);
            this.tabPage1.Controls.Add(this.lblNomeCli);
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
            // btnDeletarCli
            // 
            this.btnDeletarCli.Location = new System.Drawing.Point(352, 217);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarCli.TabIndex = 23;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // btnAlterarCli
            // 
            this.btnAlterarCli.Location = new System.Drawing.Point(271, 217);
            this.btnAlterarCli.Name = "btnAlterarCli";
            this.btnAlterarCli.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCli.TabIndex = 22;
            this.btnAlterarCli.Text = "Alterar";
            this.btnAlterarCli.UseVisualStyleBackColor = true;
            this.btnAlterarCli.Click += new System.EventHandler(this.btnAlterarCli_Click);
            // 
            // lblBuscarCli
            // 
            this.lblBuscarCli.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCli.Location = new System.Drawing.Point(451, 61);
            this.lblBuscarCli.Name = "lblBuscarCli";
            this.lblBuscarCli.Size = new System.Drawing.Size(75, 14);
            this.lblBuscarCli.TabIndex = 21;
            this.lblBuscarCli.Text = "Imagem:";
            this.lblBuscarCli.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscarImg
            // 
            this.btnBuscarImg.Location = new System.Drawing.Point(451, 164);
            this.btnBuscarImg.Name = "btnBuscarImg";
            this.btnBuscarImg.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarImg.TabIndex = 19;
            this.btnBuscarImg.Text = "Buscar";
            this.btnBuscarImg.UseVisualStyleBackColor = true;
            this.btnBuscarImg.Click += new System.EventHandler(this.btnBuscarImg_Click);
            // 
            // pbxImg
            // 
            this.pbxImg.BackColor = System.Drawing.Color.Transparent;
            this.pbxImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImg.Location = new System.Drawing.Point(451, 78);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(75, 75);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImg.TabIndex = 18;
            this.pbxImg.TabStop = false;
            // 
            // tbxSenhaCli
            // 
            this.tbxSenhaCli.Location = new System.Drawing.Point(153, 164);
            this.tbxSenhaCli.Name = "tbxSenhaCli";
            this.tbxSenhaCli.Size = new System.Drawing.Size(273, 22);
            this.tbxSenhaCli.TabIndex = 17;
            // 
            // tbxEmailCli
            // 
            this.tbxEmailCli.Location = new System.Drawing.Point(152, 121);
            this.tbxEmailCli.Name = "tbxEmailCli";
            this.tbxEmailCli.Size = new System.Drawing.Size(274, 22);
            this.tbxEmailCli.TabIndex = 16;
            // 
            // tbxNomeCli
            // 
            this.tbxNomeCli.Location = new System.Drawing.Point(152, 78);
            this.tbxNomeCli.Name = "tbxNomeCli";
            this.tbxNomeCli.Size = new System.Drawing.Size(274, 22);
            this.tbxNomeCli.TabIndex = 15;
            // 
            // lblSenhaCli
            // 
            this.lblSenhaCli.AutoSize = true;
            this.lblSenhaCli.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaCli.Location = new System.Drawing.Point(95, 167);
            this.lblSenhaCli.Name = "lblSenhaCli";
            this.lblSenhaCli.Size = new System.Drawing.Size(52, 14);
            this.lblSenhaCli.TabIndex = 14;
            this.lblSenhaCli.Text = "Senha:";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCli.Location = new System.Drawing.Point(99, 124);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(50, 14);
            this.lblEmailCli.TabIndex = 13;
            this.lblEmailCli.Text = "E-mail:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCli.Location = new System.Drawing.Point(99, 81);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(48, 14);
            this.lblNomeCli.TabIndex = 12;
            this.lblNomeCli.Text = "Nome:";
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
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(3, 26);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(108, 14);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Digite o Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvCliente);
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
            // dgvCliente
            // 
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.email,
            this.foto});
            this.dgvCliente.Location = new System.Drawing.Point(0, 64);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowTemplate.Height = 25;
            this.dgvCliente.Size = new System.Drawing.Size(592, 200);
            this.dgvCliente.TabIndex = 5;
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
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
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
            this.lblNome.Location = new System.Drawing.Point(6, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(100, 14);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Digite o Nome:";
            // 
            // ofdImg
            // 
            this.ofdImg.FileName = "ofdImg";
            // 
            // PesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "PesquisarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.TextBox tbxCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxSenhaCli;
        private System.Windows.Forms.TextBox tbxEmailCli;
        private System.Windows.Forms.TextBox tbxNomeCli;
        private System.Windows.Forms.Label lblSenhaCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.Button btnAlterarCli;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblBuscarCli;
        private System.Windows.Forms.Button btnBuscarImg;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn foto;
        private System.Windows.Forms.OpenFileDialog ofdImg;
    }
}