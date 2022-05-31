using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagemProjeto.Controller
{
    class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leonardo.svicente2\source\repos\viagemProjeto\viagemProjeto\bdagencia.mdf;Integrated Security=True";
        }
    }
}
