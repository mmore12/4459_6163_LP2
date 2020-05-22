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
    /// Purpose: Classe para gerir um cao
    /// </summary>
    public class Cao : Animal
    {
        #region Attributes
        string porte, personalidade, raca;
        #endregion

        #region Constructors
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Cao()
        {
        }
        /// <summary>
        /// Construtor do animal
        /// </summary>
        /// <param name="nome">nome do animal</param>
        /// <param name="raca">raça do animal</param>
        /// <param name="genero">genero do animal</param>
        /// <param name="data_Nasc">Data nascimento do animal</param>
        /// <param name="porte">porte do animal</param>
        /// <param name="personalidade">personalidade do animal</param>
        public Cao(string nome, string raca, string genero, DateTime data_Nasc, string porte, string personalidade) : base(nome, genero, data_Nasc)
        {
            this.raca = raca;
            this.porte = porte;
            this.personalidade = personalidade;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Propertie para manipular raça do animal
        /// </summary>
        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        /// <summary>
        /// Propertie para manipular porte do animal
        /// </summary>
        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }
        /// <summary>
        /// Propertie para manipular personalidade do animal
        /// </summary>
        public string Personalidade
        {
            get { return personalidade; }
            set { personalidade = value; }
        }
        #endregion

        #region Overrides
        /// <summary>
        /// Override do metodo tostring para imprimir um cao
        /// </summary>
        /// <returns>Imprime um cao na consola</returns>
        public override string ToString()
        {
            string aux = ("ID: " + base.Id + " Nome: " + base.Nome + " Raça: " + raca + " Gênero: " + base.Genero + " Data de Nascimento: " 
                + base.DataNasc + " Porte: " + porte + " Personalidade: " + personalidade);
            return aux;
        }
        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~Cao()
        {
        }
        #endregion

    }
}
