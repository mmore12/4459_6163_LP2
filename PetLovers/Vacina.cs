/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/

namespace PetLovers
{
    /// <summary>
    /// Classe para gerir as vacinas
    /// </summary>
    class Vacina
    {
        #region Estado
        string nome;
        string tipo;
        int qtd;
        #endregion

        #region Properties
        /// <summary>
        /// Nome da vacina
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /// <summary>
        /// Tipo de vacina
        /// </summary>
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /// <summary>
        /// Quantidade em stock
        /// </summary>
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        #endregion

        #region Contrutores
        /// <summary>
        /// Criar uma vacina com nome, tipo e quantidade
        /// </summary>
        /// <param name="n">nome da vacina</param>
        /// <param name="t">tipo de vacina</param>
        /// <param name="q">quantidade de vacina</param>
        public Vacina(string n, string t, int q)
        {
            nome = n;
            tipo = t;
            qtd = q;
        }
        #endregion
    }
}
