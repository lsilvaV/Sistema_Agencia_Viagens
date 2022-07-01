using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using viagemProjeto.Controller;
using viagemProjeto.Model;

namespace viagemProjeto.View.Registrar
{
    public partial class RegistrarVen : Form
    {
        public RegistrarVen()
        {
            InitializeComponent();
        }

        private void RegistrarVen_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um código de cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
            }
            else
            {
                Cliente.CodCli = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisaCodCli();
            }

            if (Cliente.Retorno == "Não")
            {
                tbxCodCli.Text = string.Empty;
                tbxNomeCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                return;
            }
            else
            {
                tbxCodCli.Text = Convert.ToString(Cliente.CodCli);
                tbxNomeCli.Text = Cliente.NomeCli;
            }
        }

        

        private void btnBuscarFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
            }
            else
            {
                Funcionario.CodFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisaCodFun();
            }

            if (Funcionario.Retorno == "Não")
            {
                tbxCodFun.Text = string.Empty;
                tbxNomeFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                return;
            }
            else
            {
                tbxCodFun.Text = Convert.ToString(Funcionario.CodFun);
                tbxNomeFun.Text = Funcionario.NomeFun;
            }
        }

        public void limpaTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um código do pacote.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxValorPac.Text = string.Empty;
            }
            else
            {
                Pacote.CodPac = Convert.ToInt32(tbxCodPac.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisaCodPac();
            }

            if (Pacote.Retorno == "Não")
            {
                tbxCodPac.Text = string.Empty;
                tbxValorPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                return;
            }
            else
            {
                tbxCodPac.Text = Convert.ToString(Pacote.CodPac);
                tbxValorPac.Text = Convert.ToString(Pacote.ValorPac);
            }
        }

        private void btnRegistrarVen_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "" && tbxNomeCli.Text == "" && tbxCodFun.Text == "" && tbxNomeFun.Text == "" && tbxCodPac.Text == "" && tbxValorPac.Text == "")
            {
                MessageBox.Show("Preencha todas as informações!");
            }

            else
            {
                Venda.CodCliFK = Convert.ToInt32(tbxCodCli.Text);
                Venda.CodFunFK = Convert.ToInt32(tbxCodFun.Text);
                Venda.CodPacFK = Convert.ToInt32(tbxCodPac.Text);
                Venda.PagoVen = Convert.ToInt32(tbxValorPac.Text);

                ManipulaVenda manipulaVenda = new ManipulaVenda();
                manipulaVenda.cadastrarVen();

            }

            if (Venda.Retorno == "Sim")
            {
                limpaTela();
            }
            else if (Venda.Retorno == "Não")
            {
                this.Close();
            }
        }
    }
}

