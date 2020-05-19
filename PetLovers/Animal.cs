/*
*	<copyright file="PetLovers.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/17/2020 11:16:04 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace PetLovers
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/17/2020 11:16:04 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Animal
    {
        #region Attributes
        int id;
        string nome, raca, genero;
        DateTime data_Nasc;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie to manage the animal ID
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Propertie to manage the name of animal
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Propertie to manage the breed of animal
        /// </summary>
        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        /// <summary>
        /// Propertie to manage the animal genre
        /// </summary>
        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        /// <summary>
        /// Propertie to manage the animal birth date
        /// </summary>
        public DateTime Data_Nasc
        {
            get { return data_Nasc; }
            set { data_Nasc = value; }
        }
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Animal()
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Overrides
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
