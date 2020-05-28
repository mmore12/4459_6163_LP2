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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes;
using System.IO;

namespace BR
{
    /// <summary>
    /// Regras negocio para gerir o parque
    /// </summary>
    [Serializable]
    public class RegrasParque
    {
        #region Regras para gerir caes
        /// <summary>
        /// Regra negocio para inserir um cao
        /// </summary>
        /// <param name="c">cão a inserir</param>
        /// <returns>adiciona o cao e retorna verdadeiro, caso contrario retorna falso</returns>
        public static bool InsereCao (Cao c)
        {
            return DadosCao.AddCao(c);
        }

        /// <summary>
        /// Procura um cao pelo ID
        /// </summary>
        /// <param name="id">ID do cão</param>
        /// <returns>retorna o cão, caso o encontre, se nao encontrar gera uma excecao</returns>
        public static string ProcuraCao(int id)
        {
            try
            {
                //verifica se o ID é positivo
                if (id >= 0 && DadosCao.GetCao(id)!=null)
                {
                    return DadosCao.GetCao(id);
                }
                else
                    throw new Excecao("Número invalido ou negativo!");
            }
            catch (Excecao e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }          
        }

        public static bool RegistarCao(string nomeFicheiro)
        {
            try
            {
                return DadosCao.SaveCao(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public static bool MostrarCao(string nomeFicheiro)
        {
            try
            {
                return DadosCao.MostraCao(nomeFicheiro);
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public static string ShowCaes()
        {
            return DadosCao.MeuToString();
        }
        #endregion

        #region Regras para gerir um boletim sanitario     
        /// <summary>
        /// Insere vacina na lista de vacinas
        /// </summary>
        /// <param name="v">vacina a inserir</param>
        /// <returns>adiciona a vacina caso seja true, senao retorna falso</returns>
        public static bool InsereVacina(Vacina v)
        {
            //apenas adiciona caso o ID seja positivo, não é permitido ID's negativos
            if (v.Id >= 0)
                return DadosBoletim.AddVacina(v);
            else return false;
          
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
    }
}
