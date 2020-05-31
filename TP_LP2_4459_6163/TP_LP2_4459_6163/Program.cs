/*
*	<copyright file="BO.cs" company="IPCA">
*		Copyright (c) 2020 All Rights Reserved
*	</copyright>
* 	<author>Aurélien Bouça e Elden Carones</author>
*   <date>5/19/2020</date>
*	<description>Gerir um canil</description>
**/
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using BR;
using Excecoes;
using System.Collections;

namespace TP_LP2_4459_6163
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Cao
            Cao c = new Cao("Bolinhas", "terrier", "macho", DateTime.Today, "médio", "meigo");
            Cao c2 = new Cao("Pateco", "labrador", "macho", DateTime.Today, "médio", "brincalhao");

            try
            {
                if (RegrasCao.InsereCao(c) == true && RegrasCao.InsereCao(c2) == true)
                {
                    Console.WriteLine("ID: " + c.Id + "\n");
                    Console.WriteLine("ID: " + c2.Id + "\n");
                }
                else
                    Console.WriteLine("Insucesso");
            }
            catch (Excecao e)
            {

                Console.WriteLine(e.Message);
            }

            //Console.WriteLine(c.ToString());
            //Console.WriteLine(c2.ToString());

            //RegrasParque.ProcuraCao(2);

            RegrasCao.RegistarCao(@"C:\Users\BOUCAA\Documents\Visual Studio 2019\GITHUB\TP_LP2_4459_6163\DAL\Ficheiros\caes.bin");
            RegrasCao.MostrarCao(@"C:\Users\BOUCAA\Documents\Visual Studio 2019\GITHUB\TP_LP2_4459_6163\DAL\Ficheiros\caes.bin");
            Console.WriteLine(RegrasCao.ShowCaes());
            //RegrasParque.RegistarCaoTxt();
            #endregion

            #region Boletim Sanitario

            Vacina v = new Vacina("gripe", "imunologica");
            RegrasBoletim.InsereVacina(v);
            ArrayList aux = new ArrayList();
            aux.Add(v);
            //Vacinas disponiveis
            RegrasBoletim.ProcuraTodasVacinas();
            BoletimSanitario b = new BoletimSanitario(c);

            RegrasBoletim.InsereBoletim(b);
            RegrasBoletim.InsereTratamentoBoletim(b, aux);
            #endregion


            Console.ReadKey();
        }
    }
}
