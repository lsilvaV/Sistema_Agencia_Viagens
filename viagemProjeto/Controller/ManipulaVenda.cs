using System;
using System.Data.SqlClient;
using System.Data;
using viagemProjeto.Model;
using System.Windows.Forms;

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

                SqlParameter nv = cmd.Parameters.AddWithValue("@codVen", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro da venda efetuado com sucesso. Deseja efetuar outro cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (resposta == DialogResult.Yes)
                {
                    Venda.Retorno = "Sim";
                    return;
                }
                else
                {
                    Venda.Retorno = "Não";
                    return;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void pesquisaCodVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodVen", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codVen", Venda.CodVen);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Venda.CodVen = Convert.ToInt32(arrayDados["codVen"]);
                    Venda.CodCliFK = Convert.ToInt32(arrayDados["codCliFK"]);
                    Venda.CodFunFK = Convert.ToInt32(arrayDados["codFunFK"]);
                    Venda.CodPacFK = Convert.ToInt32(arrayDados["codPacFK"]);
                    Venda.PagoVen = Convert.ToDecimal(arrayDados["pagoVen"]);
                    Venda.Retorno = "Sim";
                }

                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Venda.Retorno = "Não";
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void deletarVen()
        {
            SqlConnection cn = new SqlConnection(Conexao.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarVen", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codVen", Venda.CodVen); ;
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Venda excluida com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "A venda não pôde ser excluida.");
            }

            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
    }
}
