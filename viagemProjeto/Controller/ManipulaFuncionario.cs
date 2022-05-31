using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;

namespace viagemProjeto.Controller
{
    class ManipulaFuncionario
    {
        public void cadastrarFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);
            }

            catch
            {

            }
        }

    }
}
