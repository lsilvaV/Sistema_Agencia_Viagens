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
            else
            {
                tbxCod.Text = Convert.ToString(Funcionario.CodFun);
                tbxNomeFun.Text = Funcionario.NomeFun;
                tbxEmailFun.Text = Funcionario.EmailFun;
                tbxSenhaFun.Text = Funcionario.SenhaFun;
            }
        }

        private void btnAlterarFun_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodFun = Convert.ToInt32(tbxCod.Text);
                    Funcionario.NomeFun = tbxNomeFun.Text;
                    Funcionario.EmailFun = tbxEmailFun.Text;
                    Funcionario.SenhaFun = tbxSenhaFun.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFun();
                }

                return;
            }
        }

        private void btnDeletarFun_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja deletar os dados do funcionário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodFun = Convert.ToInt32(tbxCod.Text);

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFun();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;

                return;
            }
        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "")
            {
                MessageBox.Show("Digite o nome do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Funcionario.NomeFun = tbxNome.Text;
            dgvFun.DataSource = ManipulaFuncionario.pesquisaNomeFun();

            dgvFun.Columns[0].Visible = false;
            dgvFun.Columns[1].Visible = false;
            dgvFun.Columns[2].Visible = false;
            dgvFun.Columns[3].HeaderCell.Value = "Código";
            dgvFun.Columns[4].HeaderCell.Value = "Nome";
            dgvFun.Columns[5].HeaderCell.Value = "E-mail";
            dgvFun.Columns[6].Visible = false;

        }
    }
}

