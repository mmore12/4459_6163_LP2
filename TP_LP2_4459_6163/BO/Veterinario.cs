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
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// </summary>
    public class Veterinario : Pessoa
    {
        #region Attributes
        DateTime dataAdmissao;
        int id;
        #endregion

        #region Methods

        #region Constructors

        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Veterinario()
        {
        }
        /// <summary>
        /// Criar um veterinário
        /// </summary>
        /// <param name="data">data admissao</param>
        /// <param name="i">id do veterinario</param>
        /// <param name="n">nome proveniente da classe pessoas</param>
        /// <param name="ida">idade proveniente da classe pessoas</param>
        /// <param name="f">funcao proveniente da classe pessoas</param>
        public Veterinario(DateTime data, int i, string n, DateTime ida, string f) : base(n, f, ida)
        {
            dataAdmissao = data;
            id = i;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Manipula a Data de admissao do veterinario
        /// </summary>
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        /// <summary>
        /// Manipula o Id do veterinario
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        #endregion

        #region Functions
        #endregion

        #region Overrides
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Veterinario()
        {
        }
        #endregion

        #endregion
    }
}
