using System;
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

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void pesquisaCodPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacote.CodPac);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacote.CodPac = Convert.ToInt32(arrayDados["codPac"]);
                    Pacote.ValorPac = Convert.ToInt32(arrayDados["valorPac"]);
                    Pacote.OrigemPac = arrayDados["origemPac"].ToString();
                    Pacote.DestinoPac = arrayDados["destinoPac"].ToString();
                    Pacote.DataPacIda = Convert.ToDateTime(arrayDados["dataPacIda"]);
                    Pacote.DataPacVolta = Convert.ToDateTime(arrayDados["dataPacVolta"]);
                    Pacote.DescPac = arrayDados["descPac"].ToString();
                    Pacote.ImgPac = (System.Array)arrayDados["imgPac"];
                    Pacote.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacote.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacote.CodPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote excluido com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O pacote não pôde ser excluido.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacote.ValorPac);
                cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
                cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacote.DataPacIda);
                cmd.Parameters.AddWithValue("@dataPacVolta", Pacote.DataPacVolta);
                cmd.Parameters.AddWithValue("@descPac", Pacote.DescPac);
                cmd.Parameters.AddWithValue("@imgPac", Pacote.ImgPac);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacote alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "O pacote não foi alterado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public static BindingSource pesquisaOrigemPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaOrigemPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPac", Pacote.OrigemPac);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }

        public static BindingSource pesquisaDestinoPac()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaDestinoPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoPac", Pacote.DestinoPac);
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