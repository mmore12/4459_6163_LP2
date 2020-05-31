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
    /// Classe para gerir regras relativas aos boletins e vacinas
    /// </summary>
    public class RegrasBoletim
    {
        #region Regras para gerir Vacinas     
        /// <summary>
        /// Insere vacina na lista de vacinas
        /// </summary>
        /// <param name="v">vacina a inserir</param>
        /// <returns>adiciona a vacina caso seja true, senao retorna falso</returns>
        public static bool InsereVacina(Vacina v)
        {
            try
            {
                //adiciona apenas se a vacina ainda não existir
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
        #endregion

        #region Regras para gerir boletins

        /// <summary>
        /// Insere boletim na lista de boletins
        /// </summary>
        /// <param name="boletim">boletim a inserir</param>
        /// <returns>verdadeiro caso o boletim seja inserido, falso caso já exista</returns>
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
        /// Insere tratamento a um boletim já existente
        /// </summary>
        /// <param name="boletim">boletim para inserir tratamento</param>
        /// <param name="tratamento">tratamento a inserir</param>
        /// <returns>verdadeiro se o boletim existir, falso se o boletim não existir</returns>
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
