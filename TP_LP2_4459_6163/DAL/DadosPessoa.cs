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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DAL
{
    /// <summary>
    /// Purpose:
    /// </summary>
    public class DadosPessoa
    {
        #region Attributes
        static List<Funcionario> listaFuncionarios = new List<Funcionario>();

        #endregion

        #region CARREGAR DADOS

        public static bool CarregaFuncionarios()
        {
            try {
                StreamReader reader = new StreamReader(File.OpenRead(Environment.CurrentDirectory + @"../../../../DAL/ficheiros/funcionarios.txt"));
                string cabecalho = reader.ReadLine();
                while (!reader.EndOfStream) {
                    string linha = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(linha)) {
                        string[] values = linha.Split(';');
                        Funcionario f = new Funcionario() {
                            DataAdmissao = DateTime.Parse(values[0]),
                            PNome = values[1],
                            UNome = values[2],
                            DataNasc = DateTime.Parse(values[3])
                        };
                        listaFuncionarios.Add(f);
                    }
                }
            } catch (Exception ex) {
                throw ex;
            }

            return true;

            #endregion
        }
    }
}
