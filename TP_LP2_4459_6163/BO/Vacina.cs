/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:13:24 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/19/2020 11:13:24 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Vacina
    {
        #region Estado
        string nome;
        string tipo;
        int id;
        #endregion

        #region Properties
        /// <summary>
        /// Nome da vacina
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Tipo de vacina
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Id da vacina
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Contrutores
        /// <summary>
        /// Criar uma vacina com nome, tipo e quantidade
        /// </summary>
        /// <param name="n">nome da vacina</param>
        /// <param name="t">tipo de vacina</param>
        /// <param name="q">quantidade de vacina</param>
        public Vacina(string nome, string tipo, int id)
        {
            this.nome = nome;
            this.tipo = tipo;
            this.id = id;
        }
        #endregion
    }
}
