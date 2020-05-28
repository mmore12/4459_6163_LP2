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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Classe para gerir dados de um cao
    /// </summary>
    [Serializable]
    public class DadosCao
    {

        private static List<Cao> caes;
        
        /// <summary>
        /// inicia lista de caes
        /// </summary>
        static DadosCao()
        {
            caes = new List<Cao>();
        }

        #region Dados para gerir caes
        /// <summary>
        /// Adicionar um cao
        /// </summary>
        /// <param name="c">Cao a adicionar</param>
        /// <returns>verdade se adicionou o cao ou falso se falhar</returns>
        public static bool AddCao(Cao c)
        {
            foreach (Cao cao in caes)
            {
                //verifica se o cao já existe
                if (cao.Id == c.Id)
                {
                    return false;
                }
            }
            caes.Add(c);
            return true;
        }

        /// <summary>
        /// Procura um cao
        /// </summary>
        /// <param name="id">id do cao a procurar</param>
        /// <returns>retorna o cao procurado</returns>
        public static string GetCao(int id)
        {
            //procura se o ID do cao existe
            if (caes.Find(c => c.Id == id) != null)
            {     
                //imprime o cao encontrado
                Console.WriteLine(caes.Find(c => c.Id == id));
            }
            return null;
        }

        /// <summary>
        /// Metodo para apresentar todos os caes presentes na lista de caes
        /// </summary>
        /// <returns>string com todos os caes dentro da lista</returns>
        public static string MeuToString()
        {
            string cao = "";
            foreach (Cao c in caes)
            {
                cao += String.Format("ID: " + c.Id + " Nome: " + c.Nome + " Raça: " + c.Raca + " Gênero: " + c.Genero + " Data de Nascimento: "
                + c.DataNasc + " Porte: " + c.Porte + " Personalidade: " + c.Personalidade + "\n");
            }
            return cao;

        }
        #endregion

        #region Registar cao em ficheiro
        /// <summary>
        /// Grava os caes num ficheiro binario
        /// </summary>
        /// <param name="nomeFicheiro">caminho do ficheiro</param>
        /// <returns>verdadeiro caso o ficheiro exista, falso caso nao exista</returns>
        public static bool SaveCao(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Create);
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, caes);
                    stream.Close();
                    return true;
                }
                catch (IOException e)
                {
                    throw e;
                }
                
            }
            return false;
        }

        /// <summary>
        /// Metodo para ler o ficheiro binario onde tem os caes inseridos
        /// </summary>
        /// <param name="nomeFicheiro">caminho do ficheiro</param>
        /// <returns>verdadeiro caso o ficheiro exista, falso caso nao exista</returns>
        public static bool MostraCao(string nomeFicheiro)
        {
            if(File.Exists(nomeFicheiro))
            {
                try
                {
                    Stream stream = File.Open(nomeFicheiro, FileMode.Open);
                    BinaryFormatter bin = new BinaryFormatter();
                    caes = (List<Cao>)bin.Deserialize(stream);
                    stream.Close();
                    return true;
                }
                catch(IOException e)
                {
                    throw e;
                }
                
            }
            return false;
        }


        //public static bool CarregaCao()
        //{
        //    StreamReader reader = new StreamReader(File.OpenRead(Environment.CurrentDirectory + @"C:\Users\BOUCAA\Documents\Visual Studio 2019\GITHUB\TP_LP2_4459_6163\DAL\Ficheiros\caes.txt"));
        //    string cabecalho = reader.ReadLine();
        //    while (!reader.EndOfStream)
        //    {
        //        string linha = reader.ReadLine();
        //        if (!String.IsNullOrWhiteSpace(linha))
        //        {
        //            string[] values = linha.Split(';');
        //            Cao cao = new Cao()
        //            {
        //                Id = int.Parse(values[0]),
        //                Nome = values[1],
        //                Genero = values[2],
        //                DataNasc = DateTime.Parse(values[3]),
        //                Porte = values[4],
        //                Personalidade = values[5],
        //                Raca = values[6]
        //            };
        //            caes.Add(cao);
        //        }
        //    }
        //    return true;
        //}

        #endregion



    }
}
