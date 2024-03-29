﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagemProjeto.Model
{
    class Venda
    {
        private static int codVen;
        private static int codCliFK;
        private static int codFunFK;
        private static int codPacFK;
        private static decimal pagoVen;
        private static string retorno;

        public static int CodVen { get => codVen; set => codVen = value; }
        public static int CodCliFK { get => codCliFK; set => codCliFK = value; }
        public static int CodFunFK { get => codFunFK; set => codFunFK = value; }
        public static int CodPacFK { get => codPacFK; set => codPacFK = value; }
        public static decimal PagoVen { get => pagoVen; set => pagoVen = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
