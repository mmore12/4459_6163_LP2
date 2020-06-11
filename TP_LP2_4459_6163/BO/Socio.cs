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
    /// Purpose: Permitir representar um sócio que deriva da classe base PEsoa
    /// </summary>
    public class Socio : Pessoa
    {
        #region Attributes
        static int totSocios;

        DateTime dataInsc;
        int idSocio;
        int categoria;
        
        enum CATEGORIA {
            JUNIOR,
            SENIOR,
            VOLUNTARIO
        }

        #endregion

        #region Methods

        #region Constructors


        static Socio()
        {
            totSocios = 0;
        }


        /// <summary>
        /// The default Constructor.
        /// </summary>
        public Socio()
        {
            idSocio = ++totSocios;
        }

        public Socio(DateTime dataInsc, string pNome, string uNome, DateTime dataNasc) : base(pNome, uNome, dataNasc)
        {
            idSocio = ++totSocios;
            // CATEGORIA deve ser implementada numa validação
            // 3 categorias que definirão mais tarde o preços das quotas.
            //categoria sera deverá chamar uma funcão que implementa a categoria do método.
        }

        #endregion

        #region Properties

        /// <summary>
        /// Propriedade para data de nascimento
        /// </summary>
        public DateTime DataInsc {
            get { return dataInsc; }
            set { dataInsc = value; }
        }

        /// <summary>
        /// ID Socio definido automaticamente podendo apenas ser lido
        /// </summary>
        public int IDSocio {
            get { return idSocio; }
        }

        /// <summary>
        /// A categoria de sócio apenas pode ser lida e será definida com base na data de nascimento e através de um enumerado.
        /// </summary>
        public int Categoria {
            get { return categoria; }
        }
    

        #endregion

        #endregion
    }
}
