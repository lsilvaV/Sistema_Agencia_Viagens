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
            }
            else
            {
                Cliente.CodCli = Convert.ToInt32(tbxCod.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisaCodCli();

                tbxCod.Text = Convert.ToString(Cliente.CodCli);
                tbxNomeCli.Text = Cliente.NomeCli;
                tbxEmailCli.Text = Cliente.EmailCli;
                tbxSenhaCli.Text = Cliente.SenhaCli;

                MemoryStream ms = new MemoryStream((byte[])Cliente.ImgCli);
                pbxImg.Image = Image.FromStream(ms);

             
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
        }
    }
}
