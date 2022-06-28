using System;
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
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void pesquisaCodCli()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Cliente.CodCli = Convert.ToInt32(arrayDados["codCli"]);
                    Cliente.NomeCli = arrayDados["nomeCli"].ToString();
                    Cliente.EmailCli = arrayDados["emailCli"].ToString();
                    Cliente.SenhaCli = arrayDados["senhaCli"].ToString();
                    Cliente.ImgCli = (System.Array)arrayDados["imgCli"];
                    Cliente.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Cliente.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarCli()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O cliente não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarCli()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codCli", Cliente.CodCli);
                cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
                cmd.Parameters.AddWithValue("@emailCli", Cliente.EmailCli);
                cmd.Parameters.AddWithValue("@senhaCli", Cliente.SenhaCli);
                cmd.Parameters.AddWithValue("@imgCli", Cliente.ImgCli);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O cliente não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisaNomeCli()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaNomeCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeCli", Cliente.NomeCli);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
