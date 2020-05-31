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
using System.Threading;
using System.Collections;

namespace BR
{
    /// <summary>
    /// Regras negocio para gerir o parque
    /// </summary>
    [Serializable]
    public class RegrasCao
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
                //verifica se o ID é positivo e não nulo
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
        /// <summary>
        /// Regista o cao num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro">caminho do ficheiro</param>
        /// <returns>verdadeiro se o ficheiro existe, falso se nao existir</returns>
        public static bool RegistarCao(string nomeFicheiro)
        {
            if (File.Exists(nomeFicheiro))
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
            return false;
        }

        //public static bool RegistarCaoTxt()
        //{
        //    return DadosCao.CarregaCao();
        //}

        /// <summary>
        /// Le do ficheiro binario os caes presentes
        /// </summary>
        /// <param name="nomeFicheiro">caminho do ficheiro</param>
        /// <returns>verdadeiro se o ficheiro existe, falso se nao existir</returns>
        public static bool MostrarCao(string nomeFicheiro)
        {
            if (File.Exists(nomeFicheiro))
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
            return false;
        }

        /// <summary>
        /// Mostra os caes na consola
        /// </summary>
        /// <returns>string com todos os caes na lista</returns>
        public static string ShowCaes()
        {
            return DadosCao.MeuToString();
        }
        #endregion

        
    }
}
