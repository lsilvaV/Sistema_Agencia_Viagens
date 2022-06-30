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
    }
}
