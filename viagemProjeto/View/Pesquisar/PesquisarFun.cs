using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viagemProjeto.Model;
using viagemProjeto.Controller;
using System.IO;

namespace viagemProjeto.View.Pesquisar
{
    public partial class PesquisarFun : Form
    {
        public PesquisarFun()
        {
            InitializeComponent();
        }

        private void PesquisarFun_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }
            else
            {
                Funcionario.CodFun = Convert.ToInt32(tbxCod.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisaCodFun();

                tbxCod.Text = Convert.ToString(Funcionario.CodFun);
                tbxNomeFun.Text = Funcionario.NomeFun;
                tbxEmailFun.Text = Funcionario.EmailFun;
                tbxSenhaFun.Text = Funcionario.SenhaFun;
            }

            if (Funcionario.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                return;
            }
        }
    }
}

