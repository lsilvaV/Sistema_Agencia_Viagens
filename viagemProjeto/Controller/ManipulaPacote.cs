using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;
using System.Windows.Forms;

namespace viagemProjeto.Controller
{
    class ManipulaPacote
    {
        public void cadastrarPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac) ;
                cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacote.DataPacIda);
                cmd.Parameters.AddWithValue("@dataPacVolta", Pacote.DataPacVolta);
                cmd.Parameters.AddWithValue("@descPac", Pacote.DescPac);
                cmd.Parameters.AddWithValue("@imgPac", Pacote.ImgPac);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de pacote efetuado com sucesso. Deseja efetuar outro cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Pacote.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacote.Retorno = "Não";
                    return;
                }
            }

            catch
            {

            }
        }
    }
}
