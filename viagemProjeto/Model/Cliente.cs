﻿using System;

namespace viagemProjeto.Model
{
    class Cliente
    {
        private static int codCli;
        private static string nomeCli;
        private static string emailCli;
        private static string senhaCli;
        private static Array imgCli;
        private static string retorno;

        public static int CodCli { get => codCli; set => codCli = value; }
        public static string NomeCli { get => nomeCli; set => nomeCli = value; }
        public static string EmailCli { get => emailCli; set => emailCli = value; }
        public static string SenhaCli { get => senhaCli; set => senhaCli = value; }
        public static Array ImgCli { get => imgCli; set => imgCli = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
