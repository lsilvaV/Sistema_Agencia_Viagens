using System;
using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;
using System.Windows.Forms;

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

                SqlParameter nv = cmd.Parameters.AddWithValue("@codFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do funcionário efetuado com sucesso. Deseja efetuar outro cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.Retorno = "Sim";
                    return;
                }
                else
                {
                    Funcionario.Retorno = "Não";
                    return;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void pesquisaCodFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codFun", Funcionario.CodFun);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Funcionario.CodFun = Convert.ToInt32(arrayDados["codFun"]);
                    Funcionario.NomeFun = arrayDados["nomeFun"].ToString();
                    Funcionario.EmailFun = arrayDados["emailFun"].ToString();
                    Funcionario.SenhaFun = arrayDados["senhaFun"].ToString();
                    Funcionario.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionario.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codFun", Funcionario.CodFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O funcionário não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codFun", Funcionario.CodFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.SenhaFun);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionário alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O funcionário não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisaNomeFun()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaNomeFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
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