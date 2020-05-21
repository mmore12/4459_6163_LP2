/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:08:51 PM</date>
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
    /// Created on: 5/19/2020 11:08:51 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Animal
    {
        #region Attributes
        int id = 0;
        string nome, raca, genero;
        DateTime data_Nasc;
        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Animal()
        {
        }
        /// <summary>
        /// Construtor para criar um animal com todos os elementos
        /// </summary>
        /// <param name="n">nome do animal</param>
        /// <param name="r">raça do animal</param>
        /// <param name="g">gênero do animal</param>
        /// <param name="d">data nascimento do animal</param>
        public Animal(string n, string r, string g, DateTime d)
        {
            nome = n;
            raca = r;
            genero = g;
            data_Nasc = d;
            id++;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie para manipular ID do animal
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propertie para manipular nome do animal
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Propertie para manipular raça do animal
        /// </summary>
        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        /// <summary>
        /// Propertie para manipular genero do animal
        /// </summary>
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        /// <summary>
        /// Propertie para manipular data nascimento do animal
        /// </summary>
        public DateTime Data_Nasc
        {
            get { return data_Nasc; }
            set { data_Nasc = value; }
        }
        #endregion

        #region Functions
        #endregion

        #region Overrides
        /// <summary>
        /// Override do metodo tostring
        /// </summary>
        /// <returns>Retorna todos os dados do animal</returns>
        public override string ToString()
        {
            string aux = ("Nome: " + nome + " Raça: " + raca + " Gênero: " + genero + " Data de Nascimento: " + data_Nasc);
            return aux;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Animal()
        {
        }
        #endregion

        #endregion

    }
}
