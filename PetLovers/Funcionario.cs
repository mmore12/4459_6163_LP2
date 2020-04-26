/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para adicionar funcionarios ao canil, classe filho da classe pessoa
    /// </summary>
    class Funcionario : Pessoa
    {
        #region Estado
        DateTime dataAdmissao;
        #endregion

        #region Properties
        /// <summary>
        /// Manipula o atributo Data de admissao
        /// </summary>
        public DateTime DataAdmissao
        {
            get { return dataAdmissao; }
            set { dataAdmissao = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Criar um funcionario
        /// </summary>
        /// <param name="data">data de admissao</param>
        /// <param name="n">nome do funcionario herdado da classe pessoas</param>
        /// <param name="i">idade do funcionario herdado da classe pessoas</param>
        /// <param name="f">funcao do funcionario herdado da classe pessoas</param>
        public Funcionario (DateTime data, string n, DateTime i, string f) : base(n, i, f)
        {
            dataAdmissao = data;
        }
        #endregion

    }
}
