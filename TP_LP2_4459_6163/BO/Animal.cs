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
    /// Purpose: Classe para gerir um animal
    /// </summary>
    public class Animal
    {
        #region Attributes
        int id;
        string nome, genero;
        DateTime dataNasc;
        static int animalID;
        #endregion

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
        public Animal(string nome, string genero, DateTime dataNasc)
        {
            this.genero = genero;
            this.dataNasc = dataNasc;
            //auto incremento do ID do animal
            this.id = Interlocked.Increment(ref animalID);
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
        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override do metodo tostring
        /// </summary>
        /// <returns>Retorna todos os dados do animal</returns>
        public override string ToString()
        {
            string aux = ("Nome: " + nome + " Gênero: " + genero + " Data de Nascimento: " + dataNasc);
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

    }
}
