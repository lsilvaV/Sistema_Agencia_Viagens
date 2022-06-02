using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using viagemProjeto.Model;
using viagemProjeto.Controller;


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

            else
            {
                Cliente.NomeCli = tbxNome.Text;
                Cliente.EmailCli = tbxEmail.Text;
                Cliente.SenhaCli = tbxSenha.Text;

                if (pbxImg.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    pbxImg.Image.Save(memoryStream, pbxImg.Image.RawFormat);
                    Cliente.ImgCli = memoryStream.ToArray();
                }

                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.cadastrarCliente();

            }


            if (Cliente.Retorno == "Sim")
            {
                limpaTela();
            }
            else if(Cliente.Retorno == "Não")
            {
                this.Close();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ofdImg.Filter = "Escolha uma imagem (*.jpg;*.jpeg;*.jpeg)" + "| *.jpg; *.jpeg; *.png";

            if (ofdImg.ShowDialog() == DialogResult.OK)
            {
                pbxImg.Image = Image.FromFile(ofdImg.FileName);
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

            pbxImg.Image = null;
        }
    }
}
