/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using BO;
using DAL;
using Excecoes;
using System.Collections;

namespace BR
{
    /// <summary>
    /// 
    /// </summary>
    public class RegrasBoletim
    {
        #region Regras para gerir um boletim sanitario     
        /// <summary>
        /// Insere vacina na lista de vacinas
        /// </summary>
        /// <param name="v">vacina a inserir</param>
        /// <returns>adiciona a vacina caso seja true, senao retorna falso</returns>
        public static bool InsereVacina(Vacina v)
        {
            try
            {
                //adiciona apenas se a vainca ainda não existir
                if (DadosBoletim.AddVacina(v))
                    return true;
                else throw new Excecao("Vacina já existe!");
            }
            catch (Excecao e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Procura todas as vacinas
        /// </summary>
        /// <returns>Imprime todas as vacinas na consola</returns>
        public static string ProcuraTodasVacinas()
        {
            return DadosBoletim.GetAllVacinas();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boletim"></param>
        /// <returns></returns>
        public static bool InsereBoletim(BoletimSanitario boletim)
        {
            try
            {
                //apenas adiciona se o boletim não existir
                if (DadosBoletim.AddBoletim(boletim))
                    return true;
                else throw new Excecao("Boletim já existe!");
            }
            catch (Excecao e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="boletim"></param>
        /// <param name="tratamento"></param>
        /// <returns></returns>
        public static bool InsereTratamentoBoletim(BoletimSanitario boletim, ArrayList tratamento)
        {
            try
            {
                //apenas adiciona se o boletim existir
                if (DadosBoletim.AddTratamentoBoletim(boletim, tratamento))
                    return true;
                else throw new Excecao("Boletim inexistente!");
            }
            catch (Excecao e)
            {
                throw e;
            }
        }
        #endregion
    }
}
