﻿/*
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
        #endregion
    }
}
