/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BO
{
    /// <summary>
    /// Purpose:
    /// </summary>
    public class BoletimSanitario
    {
        #region Attributes
        DateTime dataVacina, dataCriacao;
        int idAnimal;
        //Arraylist para poder inserir tratamentos (vacinas, desparasitaçao, banhos)
        ArrayList tratamentos;
        #endregion

        #region Constructors
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public BoletimSanitario()
        {

        }

        public BoletimSanitario(Cao cao)
        {
            idAnimal = cao.Id;
            dataCriacao = DateTime.Today;
            new ArrayList();
        }



        #endregion

        #region Properties
        /// <summary>
        /// Manipular data da vacina
        /// </summary>
        public DateTime DataVacina
        {
            get { return dataVacina; }
            set { dataVacina = value; }
        }

        public DateTime DataCriacao
        {
            get { return dataCriacao; }
        }

        /// <summary>
        /// Manipular ID do animal
        /// </summary>
        public int Id_Animal
        {
            get { return idAnimal; }
            set { idAnimal = value; }
        }
        /// <summary>
        /// Manipular os tratamentos
        /// </summary>
        public ArrayList Tratamentos
        {
            get { return tratamentos; }
            set { tratamentos = value; }
        }

        #endregion

        #region Destructor
        /// <summary>
        /// The destructor.
        /// </summary>
        ~BoletimSanitario()
        {
        }
        #endregion

    }
}
