/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// </summary>
    public abstract class Pessoa
    {
        #region Attributes

        static int totPessoas;

        int id;
        string uNome;
        string pNome;
        DateTime dataNasc;


        #endregion

        #region Methods

        #region Constructors


        static Pessoa()
        {
            totPessoas = 0;
        }

        /// <summary>
        /// construtor por defeito
        /// </summary>
        public Pessoa()
        {
            ++totPessoas;
        }

        public Pessoa(string pNome, string uNome, DateTime dataNasc)
        {
            ++totPessoas;

            this.pNome = pNome;
            this.uNome = uNome;
            this.dataNasc = dataNasc;
        }
        
        #endregion

        #region Properties

        public string PNome {
            get { return pNome; }
            set { pNome = value; }
        }

        public string UNome {
            get { return uNome; }
            set { uNome = value; }
        }

        public DateTime DataNasc {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #endregion


    }
}
