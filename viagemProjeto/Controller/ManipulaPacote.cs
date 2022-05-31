using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;

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
            }

            catch
            {

            }
        }
    }
}
