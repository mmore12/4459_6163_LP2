/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para gerir vacinas tomadas pelos animais
    /// </summary>
    class BoletimVacina
    {
        #region Estado
        Vacina[] vacinas;
        Cao cao;
        Veterinario veterinario;
        DateTime dataTomada;
        #endregion

        #region Properties
        /// <summary>
        /// Manipular data da administraçao da vacina
        /// </summary>
        public DateTime DataTomada
        {
            get { return dataTomada; }
            set { dataTomada = value; }
        }
        /// <summary>
        /// Manipular veterinario associado ao cao
        /// </summary>
        public Veterinario Veterinario
        {
            get { return veterinario; }
            set { veterinario = value; }
        }
        /// <summary>
        /// Manipular cao associado ao boletim do cao
        /// </summary>
        public Cao Cao
        {
            get { return cao; }
            set { cao = value; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Construir um boletim para um  cao
        /// </summary>
        /// <param name="c">cao que leva as vacinas</param>
        /// <param name="v">veterinario responsavel pelo cao</param>
        /// <param name="data">data da administraçao da vacina</param>
        public BoletimVacina (Cao c, Veterinario v, DateTime data)
        {
            cao = c;
            veterinario = v;
            data = dataTomada;
        }
        #endregion
    }
}
