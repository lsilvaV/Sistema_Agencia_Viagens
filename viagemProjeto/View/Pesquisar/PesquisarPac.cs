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
    public partial class PesquisarPac : Form
    {
        public PesquisarPac()
        {
            InitializeComponent();
        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código de pacote.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCod.Text = string.Empty;
                tbxCod.Focus();
                tbxCod.SelectAll();
                tbxValor.Text = string.Empty;
                dtpDataIda.Text = string.Empty;
                dtpDataVolta.Text = string.Empty;
                rtbDesc.Text = string.Empty;
                cbxOrigem.SelectedItem = null;
                cbxDestino.SelectedItem = null;
                pbxImg.Image = null;
                
            }
            else
            {
                Pacote.CodPac = Convert.ToInt32(tbxCod.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisaCodPac();

                tbxCod.Text = Convert.ToString(Cliente.CodCli);
                tbxValor.Text = Convert.ToString (Pacote.ValorPac);
                dtpDataIda.Text = Convert.ToString(Pacote.DataPacIda);
                dtpDataVolta.Text = Convert.ToString(Pacote.DataPacVolta);
                rtbDesc.Text = Pacote.DescPac;
                cbxOrigem.SelectedItem = Pacote.OrigemPac;
                cbxDestino.SelectedItem = Pacote.DestinoPac;

                MemoryStream ms = new MemoryStream((byte[])Pacote.ImgPac);
                pbxImg.Image = Image.FromStream(ms);


            }

            if (Cliente.Retorno == "Não")
            {
                tbxCod.Text = string.Empty;
                tbxValor.Text = string.Empty;
                dtpDataIda.Text = string.Empty;
                dtpDataVolta.Text = string.Empty;
                rtbDesc.Text = string.Empty;
                cbxOrigem.SelectedItem = null;
                cbxDestino.SelectedItem = null;
                pbxImg.Image = null;
                tbxCod.Focus();
                tbxCod.SelectAll();
                return;
            }
        }
    }
}
