/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para gerir cães
    /// </summary>
    class Cao
    {
        #region Estado
        string nome, sexo, raca;
        DateTime idade;
        Veterinario veterinario;
        BoletimVacina[] vacinaTomada;
        #endregion

        #region Properties
        /// <summary>
        /// Manipular nome do cao
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Manipular sexo do cao
        /// </summary>
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        /// <summary>
        /// Manipular raca do cao
        /// </summary>
        public string Raca
        {
            get { return raca; }
            set { raca = value; }
        }
        /// <summary>
        /// Manipular idade do cao
        /// </summary>
        public DateTime Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        #endregion

        #region Constructor
        public Cao(string n, string s, string r, DateTime i, Veterinario vet)
        {
            nome = n;
            sexo = s;
            raca = r;
            idade = i;
            veterinario = vet;
        }
        #endregion
    }
}
