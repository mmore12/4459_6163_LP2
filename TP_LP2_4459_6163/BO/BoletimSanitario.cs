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
        DateTime data_Vacina;
        int n_Ordem, id_Animal;
        //Arraylist para poder inserir tratamentos (vacinas, desparasitaçao, banhos)
        ArrayList tratamentos = new ArrayList();
        #endregion

        #region Constructors
        /// <summary>
        /// The default Constructor.
        /// </summary>
        public BoletimSanitario()
        {

        }
        /// <summary>
        /// Construtor de um boletim sanitario
        /// </summary>
        /// <param name="id_Animal">ID do animal</param>
        /// <param name="n_Ordem">Numero do veterinario</param>
        /// <param name="tratamentos">tratamos realizados</param>
        /// <param name="data_Vacina">data da vacina</param>
        public BoletimSanitario(int id_Animal, int n_Ordem, ArrayList tratamentos, DateTime data_Vacina)
        {
            this.id_Animal = id_Animal;
            this.n_Ordem = n_Ordem;
            this.tratamentos.Add(tratamentos);
            this.data_Vacina = data_Vacina;
        }

        #endregion

        #region Properties
        /// <summary>
        /// Manipular data da vacina
        /// </summary>
        public DateTime Data_Vacina
        {
            get { return data_Vacina; }
            set { data_Vacina = value; }
        }
        /// <summary>
        /// Manipular numero do veterinario
        /// </summary>
        public int N_Ordem
        {
            get { return n_Ordem; }
            set { n_Ordem = value; }
        }
        /// <summary>
        /// Manipular ID do animal
        /// </summary>
        public int Id_Animal
        {
            get { return id_Animal; }
            set { id_Animal = value; }
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
