using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using viagemProjeto.Model;
using viagemProjeto.Controller;
using viagemProjeto.View.Cadastrar;


namespace viagemProjeto.View
{
    public partial class CadastrarFun : Form
    {
        public CadastrarFun()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "")
            {
                MessageBox.Show("Preencha todas as informações!", "Atenção");
            }
            else
            {
                Funcionario.NomeFun = tbxNome.Text;
                Funcionario.EmailFun = tbxEmail.Text;
                Funcionario.SenhaFun = tbxSenha.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFun();
            }

            if (Funcionario.Retorno == "Sim")
            {
                limparTela();
            }
            else if (Funcionario.Retorno == "Não")
            {
                this.Close();
            }

        }

        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }
    }
}
