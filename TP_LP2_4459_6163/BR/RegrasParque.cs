using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excecoes;

namespace BR
{
    /// <summary>
    /// Regras negocio para gerir o parque
    /// </summary>
    public class RegrasParque
    {
        #region Regras para gerir caes
        /// <summary>
        /// Regra negocio para inserir um cao
        /// </summary>
        /// <param name="c">cão a inserir</param>
        /// <returns>adiciona o cao e retorna verdadeiro, caso contrario retorna falso</returns>
        public static bool InsereCao (Cao c)
        {
            //apenas adiciona caso o ID seja positivo, não é permitido ID's negativos
            if(c.Id < 0)
               return false;
            else
               return DadosParque.AddCao(c);
        }
        #endregion

        

        #region Regras para gerir um boletim sanitario

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public static bool InsereVacina(Vacina v)
        {
            //apenas adiciona caso o ID seja positivo, não é permitido ID's negativos
            if (v.Id >= 0)
                return DadosParque.AddVacina(v);
            else return false;
          
        }


        #endregion
    }
}
