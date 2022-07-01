using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viagemProjeto.Controller;
using viagemProjeto.Model;

namespace viagemProjeto.View.Pesquisar
{
    public partial class PesquisarVen : Form
    {
        public PesquisarVen()
        {
            InitializeComponent();
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (tbxCodVen.Text == "")
            {
                MessageBox.Show("Digite um código do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodCli.Text = string.Empty;
                tbxCodVen.Focus();
                tbxCodVen.SelectAll();
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                tbxValorPago.Text = string.Empty;
            }
            else
            {
                Venda.CodVen = Convert.ToInt32(tbxCodVen.Text);
                ManipulaVenda manipulaVenda = new ManipulaVenda();
                manipulaVenda.pesquisaCodVen();
            }

            if (Venda.Retorno == "Não")
            {
                tbxCodVen.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodVen.Focus();
                tbxCodVen.SelectAll();
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                tbxValorPago.Text = string.Empty;
                return;
            }
            else
            {
                tbxCodVen.Text = Convert.ToString(Venda.CodVen);
                tbxCodCli.Text = Venda.CodCliFK.ToString();
                tbxCodFun.Text = Venda.CodFunFK.ToString();
                tbxCodPac.Text = Venda.CodPacFK.ToString();
                tbxValorPago.Text = Venda.PagoVen.ToString();
            }
        }

        private void btnDeletarVen_Click(object sender, EventArgs e)
        {
            if (tbxCodVen.Text == "")
            {
                MessageBox.Show("Digite um código de venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodCli.Text = string.Empty;
                tbxCodVen.Focus();
                tbxCodVen.SelectAll();
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                tbxValorPago.Text = string.Empty;
            }
            else
            {
                var resposta = MessageBox.Show("Deseja deletar os dados da venda?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Venda.CodVen = Convert.ToInt32(tbxCodVen.Text);
                    ManipulaVenda manipulaVenda = new ManipulaVenda();
                    manipulaVenda.deletarVen();
                }

                tbxCodVen.Text = string.Empty;
                tbxCodCli.Text = string.Empty;
                tbxCodVen.Focus();
                tbxCodVen.SelectAll();
                tbxCodFun.Text = string.Empty;
                tbxCodPac.Text = string.Empty;
                tbxValorPago.Text = string.Empty;

                return;
            }
        }
    }
}
