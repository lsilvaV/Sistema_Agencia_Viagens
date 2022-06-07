using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viagemProjeto.View.Cadastrar;

namespace viagemProjeto.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrarCli_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCli = new CadastrarCliente();
            cadastrarCli.ShowDialog();
        }

        private void btnCadastrarFun_Click(object sender, EventArgs e)
        {
            CadastrarFun cadastrarFun = new CadastrarFun();
            cadastrarFun.ShowDialog();
        }

        private void btnCadastrarPac_Click(object sender, EventArgs e)
        {
            CadastrarPac cadastrarPac = new CadastrarPac();
            cadastrarPac.ShowDialog();
        }
    }
}
