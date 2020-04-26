/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para gerir pessoas
    /// </summary>
    class Pessoa
    {
        #region Estado
        string nome;
        DateTime idade;
        string funcao;
        #endregion

        #region Properties
        /// <summary>
        /// Propertie para obter ou colocar nome da pessoa
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Obter ou colocar idade da pessoa
        /// </summary>
        public DateTime Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        /// <summary>
        /// Obter ou colocar funcao da pessoa
        /// </summary>
        public string Funcao
        {
            get { return funcao; }
            set { funcao = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construtor para criar uma pessoa com nome, idade e função
        /// </summary>
        /// <param name="n">nome pessoa</param>
        /// <param name="i">idade da pessoa</param>
        /// <param name="f">funcao da pessoa</param>
        public Pessoa(string n, DateTime i, string f)
        {
            nome = n;
            idade = i;
            funcao = f;

        }
        #endregion
    }
}
