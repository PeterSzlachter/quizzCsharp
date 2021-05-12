using System;
using System.Collections.Generic;
using System.Text;
using ConsoleTables; 

namespace Projet1Quiz
{
  public class Candidat
    {
        //FirstName
        public string Firstname { get; set; }
        //LastNom
        public string Lastname { get; set; }
        //Gender
        public string Gender { get; set; }

        //Quiz Function 
        public void Quiz(string fname, string lname, string gender)
        {
            Console.WriteLine("Veuillez répondre aux questions techniques ci-dessous: ");
            Console.WriteLine();

            //List of List 10 Questions * 4 Questions 
            List<List<string>> Qlist = new List<List<string>>();
            Qlist.Add(new List<string> { "\tCLR:\n\t1: Common Language Runtime", "\n\t2: Current Local Runtime", "\n\t3: Common Lacal Run", "\n\t4: Current Language Run" });
            Qlist.Add(new List<string> { "\tComment se lit le sigle C# ?", "\n\t1: CDièse", "\n\t2: Ctruc", "\n\t3: CSharp", "\n\t4: CShap" });
            Qlist.Add(new List<string> { "\tQu'est ce que enum : ", " \n\t1: Un type énuméré est un type valeur qui comporte un lot de constantes. Chaque type énuméré a un type sous-jacent : un type primitif déterminé en fonction des valeurs des constantes", "\n\t2: une valeur pas constante", "\n\t3: Fournit des méthodes de recherche", "\n\t4: un nombre" });
            Qlist.Add(new List<string> { "\tQue définit la variable string ?", "\n\t1: un nombre entier", "\n\t2: une chaîne de caractère", "\n\t3: une classe", "\n\t4: décimal" });
            Qlist.Add(new List<string> { "\tQuel est le type de variable avec le domaine de valeur le plus large ?", "\n\t1:string", "\n\t2: double", "\n\t3: long", "\n\t4: decimal" });
            Qlist.Add(new List<string> { "\tCIL ?", "\n\t1: Common Intermediate Language", "\n\t2: Current Intermediate Language", "\n\t3: Common Inter Language", "\n\t4: Current Int Local" });
            Qlist.Add(new List<string> { "\tQue signifie i*= 6 ?", "\n\t1: i = 6 * 6", "\n\t2: i = i^6", "\n\t3: i = i * 6 ", "\n\t4: i = 6" });
            Qlist.Add(new List<string> { "\tQuelle est l'opérateur OU(opérateur de comparaison logique) ?", "\n\t1: && ", "\n\t2: !", " \n\t 3: || ", "\n\t4: ?" });
            Qlist.Add(new List<string> { "\tQuelle est l'opérateur ET(opérateur de comparaison logique) entre les proposition ci-dessous ?", "\n\t1:  %", "\n\t2: !", " \n\t3: || ", "\n\t4: &&" });
            Qlist.Add(new List<string> { "\tint[] myArray = new int[] {10, 20, 30, 40}; Quel est la valeur de l'indice 1  du tableau myArray?", "\n\t1: 10", "\n\t2: 20", "\n\t3:30 ", "\n\t4: 40" });

            //Key of the question and the value of the good answer 
            Dictionary<int, string> questions4 = new Dictionary<int, string>();
            questions4.Add(0, "1: Common Language Runtime");
            questions4.Add(1, "3: CSharp");
            questions4.Add(2, "1: Un type énuméré est un type valeur qui comporte un lot de constantes. Chaque type énuméré a un type sous-jacent : un type primitif déterminé en fonction des valeurs des constantes");
            questions4.Add(3, "2: une chaîne de caractère");
            questions4.Add(4, "2: double");
            questions4.Add(5, "1: Common Intermediate Language");
            questions4.Add(6, "3: i = i * 6");
            questions4.Add(7, "3: ||");
            questions4.Add(8, "4: &&");
            questions4.Add(9, "2: 20");

            int Count = 0;
            List<string> replylist = new List<string>();
            List<string> goodreplylist = new List<string>();


            for (int i = 0; i < Qlist.Count; i++)
            {
                foreach (var question in Qlist[i])
                {
                    Console.WriteLine(question);
                }

                Console.WriteLine();
                Console.Write("Votre réponse: ");
                replylist.Add(Console.ReadLine());
                Console.WriteLine();

                if (replylist[i] == (questions4[i][0]).ToString())
                {
                    Count++;
                    goodreplylist.Add("la réponse de la question numéro " + i + " est " + questions4[i].ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} vous avez un score de {3}", gender, fname, lname, Count);
            var table = new ConsoleTable("la liste des bonnes réponses:");
            table.Write(Format.Alternative);

            Console.WriteLine();
            foreach (var goodresp in goodreplylist)
            {
                Console.WriteLine(goodresp);
            }                                                                  
        }
    }
}
