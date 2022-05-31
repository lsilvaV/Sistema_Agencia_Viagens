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
            View.CadastrarCliente cadastrarCli = new View.CadastrarCliente();
            cadastrarCli.ShowDialog();
        }

        private void btnCadastrarFun_Click(object sender, EventArgs e)
        {
            View.CadastrarFun cadastrarFun = new View.CadastrarFun();
            cadastrarFun.ShowDialog();
        }

        private void btnCadastrarPac_Click(object sender, EventArgs e)
        {
            Cadastrar.CadastrarPac cadastrarPac = new Cadastrar.CadastrarPac();
            cadastrarPac.ShowDialog();
        }
    }
}
