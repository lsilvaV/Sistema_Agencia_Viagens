using System;
using System.Drawing;
using System.Windows.Forms;
using viagemProjeto.Model;
using viagemProjeto.Controller;
using System.IO;

namespace viagemProjeto.View.Pesquisar
{
    public partial class PesquisarCliente : Form
    {
        public PesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pbxImg.Image = null;
            }
            else
            {
                Cliente.CodCli = Convert.ToInt32(tbxCod.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisaCodCli();
            }

            if (Cliente.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pbxImg.Image = null;
                tbxCod.Focus();
                tbxCod.SelectAll();
                return;
            }
            else
            {
                tbxCod.Text = Convert.ToString(Cliente.CodCli);
                tbxNomeCli.Text = Cliente.NomeCli;
                tbxEmailCli.Text = Cliente.EmailCli;
                tbxSenhaCli.Text = Cliente.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Cliente.ImgCli);
                pbxImg.Image = Image.FromStream(ms);
            }
        }

        private void btnAlterarCli_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pbxImg.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja alterar os dados do cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.CodCli = Convert.ToInt32(tbxCod.Text);
                    Cliente.NomeCli = tbxNomeCli.Text;
                    Cliente.EmailCli = tbxEmailCli.Text;
                    Cliente.SenhaCli = tbxSenhaCli.Text;

                    MemoryStream ms = new MemoryStream((byte[])Cliente.ImgCli);
                    pbxImg.Image.Save(ms, pbxImg.Image.RawFormat);
                    Cliente.ImgCli = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCli();
                }

                return;
            }
        }
        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pbxImg.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja excluir o cliente " + tbxCod.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.CodCli = Convert.ToInt32(tbxCod.Text);

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCli();
                }

                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pbxImg.Image = null;
                return;
            }
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            ofdImg.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (ofdImg.ShowDialog() == DialogResult.OK)
            {
                pbxImg.Image = Image.FromFile(ofdImg.FileName);
            }
        }
    }
}
