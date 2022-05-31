using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viagemProjeto.View
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxNome.Text == "" | tbxEmail.Text == "" | tbxSenha.Text == "" | pbxImg.Image == null)
            {
                MessageBox.Show("Preencha todas as informações!");
            }
        }
    }
}
