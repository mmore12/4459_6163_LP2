/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>CaronesE</author>
*   <date>5/19/2020 11:10:24 PM</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// Created by: CaronesE
    /// Created on: 5/19/2020 11:10:24 PM
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class Funcionario : Pessoa
    {
        #region Attributes

        static int totFunc;

        int idFunc;
        DateTime dataAdmissao;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// construtor da class que inicializa o total de funcionarios para atribuir automaticamente o ID
        /// </summary>
        static Funcionario()
        {
            totFunc = 0;
        }


        public Funcionario()
        {
            idFunc = ++totFunc;
        }

        public Funcionario(DateTime dataAdmissao, string pNome, string uNome, DateTime dataNasc) : base(pNome, uNome, dataNasc)
        {
            idFunc = ++totFunc;
            this.dataAdmissao = dataAdmissao;
        }
        #endregion

        #region Properties


        public int IdFunc {
            get { return idFunc; }
        }

        /// <summary>
        /// Manipula o atributo Data de admissao
        /// </summary>
        public DateTime DataAdmissao {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
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
        ~Funcionario()
        {
        }
        #endregion

        #endregion
    }
}
