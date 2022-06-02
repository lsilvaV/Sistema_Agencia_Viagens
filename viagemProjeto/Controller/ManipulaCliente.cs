using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;
using System.Windows.Forms;

namespace viagemProjeto.Controller
{
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Cliente.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                cmd.Parameters.AddWithValue("@imgCli", Cliente.ImgCli);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codCli", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de cliente efetuado com sucesso. Deseja efetuar outro cadastro?", 
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Cliente.Retorno = "Sim";
                    return;
                }
                else
                {
                    Cliente.Retorno = "Não";
                    return;
                }
            }

            catch
            {

            }
        }
    }
}
