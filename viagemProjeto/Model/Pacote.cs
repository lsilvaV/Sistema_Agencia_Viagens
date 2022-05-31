using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagemProjeto.Model
{
    class Pacote
    {
        private static int codPac;
        private static float valorPac;
        private static string origemPac;
        private static string destinoPac;
        private static DateTime dataPacIda;
        private static DateTime dataPacVolta;
        private static string descPac;
        private static Array imgPac;

        public static int CodPac { get => codPac; set => codPac = value; }
        public static float ValorPac { get => valorPac; set => valorPac = value; }
        public static string OrigemPac { get => origemPac; set => origemPac = value; }
        public static string DestinoPac { get => destinoPac; set => destinoPac = value; }
        public static DateTime DataPacIda { get => dataPacIda; set => dataPacIda = value; }
        public static DateTime DataPacVolta { get => dataPacVolta; set => dataPacVolta = value; }
        public static string DescPac { get => descPac; set => descPac = value; }
        public static Array ImgPac { get => imgPac; set => imgPac = value; }
    }
}
