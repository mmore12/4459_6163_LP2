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
using System.Xml.Schema;

namespace BO
{
    /// <summary>
    /// Purpose: A classe Funcionário, que deriva da classe base Pessoa, tem como objetivo representar qualquer funcionário da instituição
    /// Esse funcionário poderá ter várias tarefas e poderão ser considerados mais que um funcionários para canis maiores
    /// 
    /// Funções de classe ainda não implementada, mas definida no diagrama de classes.
    /// </summary>
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

        /// <summary>
        /// Contrutor por defeito
        /// </summary>
        public Funcionario()
        {
            idFunc = ++totFunc;
        }

        /// <summary>
        /// Contrutor por defeito de funcionarios
        /// </summary>
        /// <param name="dataAdmissao">Data de admissão como funcionario</param>
        /// <param name="pNome">Primeiro Nome do fncionário</param>
        /// <param name="uNome">Ultimo Nome do funcionário</param>
        /// <param name="dataNasc">Data de Nascimento do funcionário</param>
        public Funcionario(DateTime dataAdmissao, string pNome, string uNome, DateTime dataNasc) : base(pNome, uNome, dataNasc)
        {
            idFunc = ++totFunc;
            this.dataAdmissao = dataAdmissao;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Propriedade de ID funcionário.
        /// É possível ler o ID mas não definir. Este é definido automaticamente.
        /// </summary>
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

        #endregion
    }
}
