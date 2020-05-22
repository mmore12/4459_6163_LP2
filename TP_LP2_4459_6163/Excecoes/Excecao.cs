/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using System;

namespace Excecoes
{
    /// <summary>
    /// Classe para gerir excecoes
    /// </summary>
    public class Excecao : ApplicationException
    {
        /// <summary>
        /// Construtor by default
        /// </summary>
        public Excecao() : base("Erro")
        {

        }
        /// <summary>
        /// Construtor que recebe uma string
        /// </summary>
        /// <param name="e"></param>
        public Excecao(string e) : base(e)
        {
        }
        /// <summary>
        /// Construtor que recebe uma string e uma exception
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        public Excecao(string s, Exception e)
        {
            throw new Excecao("Erro: " + s + " " + e.Message);
        }
    }
}
