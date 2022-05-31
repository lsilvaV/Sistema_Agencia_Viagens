using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;

namespace viagemProjeto.Controller
{
    class ManipulaVenda
    {
        public void cadastrarVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarVen", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCliFK", Venda.CodCliFK);
                cmd.Parameters.AddWithValue("@codFunFK", Venda.CodFunFK);
                cmd.Parameters.AddWithValue("@codPacFK", Venda.CodPacFK);
                cmd.Parameters.AddWithValue("@pagoVen", Venda.PagoVen);
            }

            catch
            {

            }
        }
    }
}
