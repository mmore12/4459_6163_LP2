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
    /// A classe Pessoa tem como propósito definir os atributos bases de qualquer pessoa a intervir no sistema.
    /// Como não queremos instanciar nenhuma pessoa, esta permanecerá abstrata.
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

        /// <summary>
        /// De forma a permitir uma sequencialização do ID de sócio com base no número de sócios é initializada o a variável totPessoas no construtor da classe
        /// </summary>
        static Pessoa()
        {
            totPessoas = 0;
        }

        /// <summary>
        /// construtor por defeito
        /// </summary>
        public Pessoa()
        {
            id=++totPessoas;
        }

        /// <summary>
        /// Construtor completo de uma instancia da classe Pesso    
        /// De notar que id único da Pessoa é atribuído automáticamente e incrementado diretamente na construção da classe.
        /// </summary>
        /// <param name="pNome">Primeiro Nome da Pessoa</param>
        /// <param name="uNome">Ultimo Nome da Pessoa</param>
        /// <param name="dataNasc">Data de NAscimento da Pessoa</param>
        public Pessoa(string pNome, string uNome, DateTime dataNasc)
        {
            id= ++totPessoas;

            this.pNome = pNome;
            this.uNome = uNome;
            this.dataNasc = dataNasc;
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// Proriedade publica para o atributo Primeiro Nome
        /// </summary>
        public string PNome {
            get { return pNome; }
            set { pNome = value; }
        }

        /// <summary>
        /// Propriedade publica para o atributo Ultimo Nome
        /// </summary>
        public string UNome {
            get { return uNome; }
            set { uNome = value; }
        }

        /// <summary>
        /// Propriedade publica para a Data de Nascimento
        /// </summary>
        public DateTime DataNasc {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        #endregion

        #endregion


    }
}
