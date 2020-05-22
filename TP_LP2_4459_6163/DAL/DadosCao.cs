/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using BO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Classe para gerir dados de um cao
    /// </summary>
    public class DadosCao
    {

        private static List<Cao> caes;
        
        /// <summary>
        /// inicia lista de caes
        /// </summary>
        static DadosCao()
        {
            caes = new List<Cao>();
        }

        #region Dados para gerir caes
        /// <summary>
        /// Adicionar um cao
        /// </summary>
        /// <param name="c">Cao a adicionar</param>
        /// <returns>verdade se adicionou o cao ou falso se falhar</returns>
        public static bool AddCao(Cao c)
        {
            foreach (Cao cao in caes)
            {
                //verifica se o cao já existe
                if (cao.Id == c.Id)
                {
                    return false;
                }
            }
            caes.Add(c);
            return true;
        }

        /// <summary>
        /// Procura um cao
        /// </summary>
        /// <param name="id">id do cao a procurar</param>
        /// <returns>retorna o cao procurado</returns>
        public static string GetCao(int id)
        {
            //procura se o ID do cao existe
            if (caes.Find(c => c.Id == id) != null)
            {     
                //imprime o cao encontrado
                Console.WriteLine(caes.Find(c => c.Id == id));
            }
            return null;
        }
        #endregion


        
    }
}
