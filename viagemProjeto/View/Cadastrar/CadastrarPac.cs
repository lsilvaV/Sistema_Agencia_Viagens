using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using viagemProjeto.Model;
using viagemProjeto.Controller;

namespace viagemProjeto.View.Cadastrar
{
    public partial class CadastrarPac : Form
    {
        public CadastrarPac()
        {
            InitializeComponent();
        }

        private void CadastrarPac_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ofdImg.Filter = "Escolha uma imagem (*.jpg;*.jpeg;*.jpeg)" + "| *.jpg; *.jpeg; *.png";

            if (ofdImg.ShowDialog() == DialogResult.OK)
            {
                pbxImg.Image = Image.FromFile(ofdImg.FileName);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbxValor.Text == "" | cbxOrigem.SelectedItem == null | cbxDestino.SelectedItem == null | dtpDataIda.Value > dtpDataVolta.Value | rtbDesc.Text == string.Empty | pbxImg.Image == null)
            {
                MessageBox.Show("Preencha todas as informações corretamente!");
            }
            else
            {
                Pacote.ValorPac = Convert.ToDecimal(tbxValor.Text);
                Pacote.OrigemPac = cbxOrigem.Text;
                Pacote.DestinoPac = cbxOrigem.Text;
                Pacote.DataPacIda = dtpDataIda.Value;
                Pacote.DataPacVolta = dtpDataVolta.Value;
                Pacote.DescPac = rtbDesc.Text;
                

                if (pbxImg.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    pbxImg.Image.Save(memoryStream, pbxImg.Image.RawFormat);
                    Pacote.ImgPac = memoryStream.ToArray();
                }

                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.cadastrarPac();

                if (Pacote.Retorno == "Sim")
                {
                    limpaTela();
                }
                else if (Pacote.Retorno == "Não")
                {
                    this.Close();
                }

            }
        }

        public void limpaTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox | ctl is ComboBox | ctl is DateTimePicker | ctl is RichTextBox)
                {
                    ctl.Text = string.Empty;
                }      
            }

            pbxImg.Image = null;
        }
    }
}
