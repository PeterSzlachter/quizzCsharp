using System;
using System.Diagnostics;
using System.Text;
using System.Timers;
//using static System.Net.Mime.MediaTypeNames;

namespace Projet1_Peter
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name, firstname;
            string start;
            int qnum = 1;
            int correctAnswer = 0;
            string answer;
            double percentage = 0;
            
            Stopwatch watch = new Stopwatch();              
            Console.WriteLine("Entrer votre prénom et votre nom pour qu'on vous identifie");
            firstname = Console.ReadLine();
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Bienvenu(e) {firstname} {name} au test de connaissance sur le C# !");
            Console.WriteLine("Dans ce test vous devez répondre à 10 questions, vous disposez de 45 secondes par question pour répondre");
            Console.WriteLine("Bonne chance !");
            Console.WriteLine("Commencer ? Taper oui");
            start = Console.ReadLine().ToLower();


            while (start == "oui")
            {
                switch(qnum)

                {
                    case 1:
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Question {qnum} : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        watch.Start();
                        answer = Console.ReadLine().ToUpper();

                        if (answer == "B")
                        { 
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        } 

                        else { qnum = 1; }
                        Console.Clear();
                        break;


                    case 2:
                        Console.WriteLine($"Question {qnum} : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 2; }
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Question 3 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 3; }
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("Question 4 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 4; }
                        Console.Clear();
                        break; ;

                    case 5:
                        Console.WriteLine("Question 5 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 5; }
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Question 6 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 6; }
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Question 7 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 7; }
                        Console.Clear();
                        break;
                    case 8:
                        Console.WriteLine("Question 8 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 8; }
                        Console.Clear();
                        break;
                    case 9:
                        Console.WriteLine("Question 9 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 9; }
                        Console.Clear();
                        break;
                    case 10:
                        Console.WriteLine("Question 10 : Quel est le type de variable avec le domaine de valeur le plus large ?");
                        Console.WriteLine("A: String\nB: Double\nC: Int\nD: Decimal");
                        answer = Console.ReadLine().ToUpper();
                        watch.Stop();
                        if (answer == "B")
                        {
                            correctAnswer++;
                            qnum++;
                        }

                        else if (answer == "A" || answer == "C" || answer == "D")
                        {
                            Console.Clear();
                            qnum++;
                        }

                        else { qnum = 10; }
                        Console.Clear();
                        break;

                    default: 
                        Console.WriteLine("Erreur de saisie");
                        break;
                }
            }
            TimeSpan time = watch.Elapsed;
            percentage = (Convert.ToDouble(correctAnswer) / 10) * 100;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Vous avez {correctAnswer} bonne(s) réponse(s) soit {percentage}% de réussite avec un chrono de {time.ToString(@"hh\:mm\:ss")}"); 

        }
    }
}

// public autorise l'accès de ce qui suit depuis l'extérieur
// private restreint l'accès de ce qui suit à l'usage exclusif dans le bloc où il a été déclaré.
// https://docs.microsoft.com/fr-fr/dotnet/standard/base-types/custom-timespan-format-strings?redirectedfrom=MSDN -> Chrono

