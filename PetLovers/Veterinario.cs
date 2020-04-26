/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para criar um veterinario, classe filho da classe pessoa
    /// </summary>
    class Veterinario : Pessoa
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
        /// Criar um veterinário
        /// </summary>
        /// <param name="data">data admissao</param>
        /// <param name="n">nome proveniente da classe pessoas</param>
        /// <param name="i">idade proveniente da classe pessoas</param>
        /// <param name="f">funcao proveniente da classe pessoas</param>
        public Veterinario (DateTime data, string n, DateTime i, string f) : base (n,i,f)
        {
            dataAdmissao = data;
        }
        #endregion
    }
}
