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
                dtpDataIda.Value = DateTime.Now;
                dtpDataVolta.Value = DateTime.Now;
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
            }
            
            if (Pacote.Retorno == "Não")

            {
                tbxCod.Text = string.Empty;
                tbxValor.Text = string.Empty;
                dtpDataIda.Value = DateTime.Now;
                dtpDataVolta.Value = DateTime.Now;
                rtbDesc.Text = string.Empty;
                cbxOrigem.SelectedItem = null;
                cbxDestino.SelectedItem = null;
                pbxImg.Image = null;
                tbxCod.Focus();
                tbxCod.SelectAll();
                return;
            }

            else
            {
                tbxCod.Text = Convert.ToString(Pacote.CodPac);
                tbxValor.Text = Convert.ToString(Pacote.ValorPac);
                dtpDataIda.Value = Pacote.DataPacIda;
                dtpDataVolta.Value = Pacote.DataPacVolta;
                rtbDesc.Text = Pacote.DescPac;
                cbxOrigem.SelectedItem = Pacote.OrigemPac;
                cbxDestino.SelectedItem = Pacote.DestinoPac;

                MemoryStream ms = new MemoryStream((byte[])Pacote.ImgPac);
                pbxImg.Image = Image.FromStream(ms);
            }
        }

        private void btnAlterarPac_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código do pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var resposta = MessageBox.Show("Deseja alterar os dados do Pacote?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.CodPac = Convert.ToInt32(tbxCod.Text);
                    Pacote.ValorPac = Convert.ToDecimal(tbxValor.Text);
                    Pacote.DataPacIda = Convert.ToDateTime(dtpDataIda.Value);
                    Pacote.DataPacVolta = Convert.ToDateTime(dtpDataVolta.Value);
                    Pacote.DescPac = rtbDesc.Text;
                    Pacote.OrigemPac = cbxOrigem.SelectedItem.ToString();
                    Pacote.DestinoPac = cbxDestino.SelectedItem.ToString();

                    MemoryStream ms = new MemoryStream((byte[])Pacote.ImgPac);
                    pbxImg.Image.Save(ms, pbxImg.Image.RawFormat);
                    Pacote.ImgPac = ms.ToArray();

                    ManipulaPacote manipulaPacote = new ManipulaPacote();
                    manipulaPacote.alterarPac();
                }

                return;
            }
        }

        private void btnDeletarPac_Click(object sender, EventArgs e)
        {
            if (tbxCod.Text == "")
            {
                MessageBox.Show("Digite um código do pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var resposta = MessageBox.Show("Deseja deletar os dados do Pacote?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.CodPac = Convert.ToInt32(tbxCod.Text);

                    ManipulaPacote manipulaPacote = new ManipulaPacote();
                    manipulaPacote.deletarPac();
                }

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

                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ofdImg.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (ofdImg.ShowDialog() == DialogResult.OK)
            {
                pbxImg.Image = Image.FromFile(ofdImg.FileName);
            }
        }

        private void btnBuscarOrigem_Click(object sender, EventArgs e)
        {
            if (tbxOrigem.Text == "")
            {
                MessageBox.Show("Digite a origem do pacote.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacote.OrigemPac = tbxOrigem.Text;

            dgvOrigem.DataSource = ManipulaPacote.pesquisaOrigemPac();

            dgvOrigem.Columns[0].Visible = false;
            dgvOrigem.Columns[1].Visible = false;
            dgvOrigem.Columns[2].Visible = false;
            dgvOrigem.Columns[3].Visible = false;
            dgvOrigem.Columns[4].Visible = false;
            dgvOrigem.Columns[5].HeaderCell.Value = "Código";
            dgvOrigem.Columns[6].HeaderCell.Value = "Valor";
            dgvOrigem.Columns[7].HeaderCell.Value = "Origem";
            dgvOrigem.Columns[8].Visible = false;
            dgvOrigem.Columns[9].HeaderCell.Value = "Data de Ida";
            dgvOrigem.Columns[10].HeaderCell.Value = "Data de Volta";
            dgvOrigem.Columns[11].Visible = false;
            dgvOrigem.Columns[12].Visible = false;
        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
            if (tbxDestino.Text == "")
            {
                MessageBox.Show("Digite o destino do pacote.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacote.DestinoPac = tbxDestino.Text;

            dgvDestino.DataSource = ManipulaPacote.pesquisaDestinoPac();

            dgvDestino.Columns[0].Visible = false;
            dgvDestino.Columns[1].Visible = false;
            dgvDestino.Columns[2].Visible = false;
            dgvDestino.Columns[3].Visible = false;
            dgvDestino.Columns[4].Visible = false;
            dgvDestino.Columns[5].HeaderCell.Value = "Código";
            dgvDestino.Columns[6].HeaderCell.Value = "Valor";
            dgvDestino.Columns[7].Visible = false;
            dgvDestino.Columns[8].HeaderCell.Value = "Destino";
            dgvDestino.Columns[9].HeaderCell.Value = "Data de Ida";
            dgvDestino.Columns[10].HeaderCell.Value = "Data de Volta";
            dgvDestino.Columns[11].Visible = false;
            dgvDestino.Columns[12].Visible = false;

        }
    }
}
