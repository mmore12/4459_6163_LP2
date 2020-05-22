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
using System.Threading;

namespace BO
{
    /// <summary>
    /// Purpose: Classe para gerir uma vacina
    /// </summary>
    public class Vacina
    {
        #region Estado
        string nome;
        string tipo;
        int id;
        static int vacinaId;
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
        /// Criar uma vacina com nome, tipo
        /// </summary>
        /// <param name="nome">Nome da vacina</param>
        /// <param name="tipo">Tipo da vacina</param>
        public Vacina(string nome, string tipo)
        {
            this.nome = nome;
            this.tipo = tipo;
            //auto incremento do ID da vacina
            this.id = Interlocked.Increment(ref vacinaId);
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Imprime a vacina na consola
        /// </summary>
        /// <returns>retorna a vacina imprimida</returns>
        public override string ToString()
        {
            string aux = ("ID: " + Id + " Nome: " + Nome + " Tipo Vacina: " + Tipo);
            return aux;
        }
        #endregion
    }
}
