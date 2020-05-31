/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using BO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    /// <summary>
    /// Classe para gerir dados do boletim sanitario e vacinas
    /// </summary>
    public class DadosBoletim
    {

        private static List<BoletimSanitario> boletins;
        private static List<Vacina> vacinas;

        /// <summary>
        /// iniciar as listas
        /// </summary>
        static DadosBoletim()
        {
            boletins = new List<BoletimSanitario>();
            //Vacinas obrigatorias
            vacinas = new List<Vacina>() {
            new Vacina("Primeira vacina", "Vacina das 6 semanas"),
            new Vacina("Vacina polivalente", "Vacina das 8 semanas"),
            new Vacina("Vacina antirrábica", "Imunológica"),
            new Vacina("Vacina Leishmaniose", "Imunológica")
            };
        }

        #region Dados para gerir Boletim Sanitario
        /// <summary>
        /// Adicionar uma vacina
        /// </summary>
        /// <param name="vacina">Vacina a adicionar</param>
        /// <returns>retorna true se a vacina for inserida, caso contrario, falso</returns>
        public static bool AddVacina(Vacina vacina)
        {
            foreach (Vacina vacina1 in vacinas)
            {
                //verifica se a vacina já existe
                if (vacina1.Id == vacina.Id)
                {
                    return false;
                }
            }
            vacinas.Add(vacina);
            return true;
        }

        /// <summary>
        /// Mostra todas as vacinas
        /// </summary>
        /// <returns>Imprime na consola todas as vacinas presentes na lista</returns>
        public static string GetAllVacinas()
        {
            //verifica se a lista tem vacinas
            if (vacinas != null)
            {
                for (int i = 0; i < vacinas.Count; i++)
                {
                    //imprime na consola todas as vacinas disponiveis.
                    Console.WriteLine(vacinas[i]);
                }
            }
            return null;
        }

        /// <summary>
        /// Adicionar um boletim sanitario
        /// </summary>
        /// <param name="bol">boletim a adicionar</param>
        /// <returns>retorna true se o boletim for inserido, caso contrario, retorna false</returns>
        public static bool AddBoletim(BoletimSanitario bol)
        {
            foreach (BoletimSanitario boletimSanitario in boletins)
            {
                //verifica se o boletim daquele animal já existe
                if (boletimSanitario.IdAnimal == bol.IdAnimal)
                {
                    return false;
                }
            }
            boletins.Add(bol);
            return true;
        }
        /// <summary>
        /// Adiciona tratamentos a um boletim
        /// </summary>
        /// <param name="boletim">boletim para adicionar os tratamentos</param>
        /// <param name="tratamento">tratamentos a inserir</param>
        /// <returns>verdadeiro caso o boletim exista, caso contrario falso</returns>
        public static bool AddTratamentoBoletim(BoletimSanitario boletim, ArrayList tratamento)
        {
            //percorre a lista de boletins
            for(int i = 0; i<= boletins.Count; i++)
            {
                //verifica se o boletim existe
                if (boletim.IdAnimal == boletins[i].IdAnimal)
                {
                    //percorre o arraylist de tratamentos
                    for (int z = 0; z <= boletins[i].Tratamentos.Count; z++)
                    {
                        boletins[i].Tratamentos.Add(tratamento[z]);
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion
    }
}
