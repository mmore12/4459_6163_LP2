/*------------------------------------------------------*
 *----------PETLOVERS - Trabalho Programação II---------*
 *------------------------------------------------------*         
 *----------Autores: Elden Carones e Aurélien Bouça-----*
 *------------------------------------------------------*/
using System;

namespace PetLovers
{
    /// <summary>
    /// Classe para gerir uma jaula
    /// </summary>
    class Jaula
    {
        #region Estado
        string nome;
        Funcionario funcionario;
        Cao cao;
        DateTime dataEntrada, dataSaida;
        #endregion

        #region Properties
        /// <summary>
        /// Funcao para manipular nome da jaula
        /// </summary>
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        /// <summary>
        /// Funcao para manipular data de entrada do cao
        /// </summary>
        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }
        /// <summary>
        /// Funcao para manipular data de saida do cao
        /// </summary>
        public DateTime DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        /// <summary>
        /// Funcao para manipular cao associado a uma jaula
        /// </summary>
        public Cao Cao
        {
            get { return cao; }
            set { cao = value; }
        }
        /// <summary>
        /// Funcao para manipular funcionario associado a uma jaula
        /// </summary>
        public Funcionario Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Construir uma jaula com um cao e funcionario
        /// </summary>
        /// <param name="n">nome da jaula</param>
        /// <param name="f">funcionario responsável</param>
        /// <param name="c">cão que ocupa jaula</param>
        /// <param name="dataE">data entrada</param>
        public Jaula(string n, Funcionario f, Cao c, DateTime dataE)
        {
            nome = n;
            funcionario = f;
            cao = c;
            dataEntrada = dataE;
        }
        /// <summary>
        /// Construtor para jaula desocupada
        /// </summary>
        /// <param name="n"></param>
        /// <param name="f"></param>
        public Jaula(string n, Funcionario f)
        {
            nome = n;
            funcionario = f;
        }
        #endregion


    }
}
