using System;
using ConsoleTables; 

namespace Projet1Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Graphics
            if (Console.BackgroundColor == ConsoleColor.Black)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }

            var table = new ConsoleTable("                           ***** QUIZ - Questions Techniques en C# *****                              ");
            table.Write(Format.Alternative);
            Console.WriteLine();

            //instantiation

            Candidat candidat = new Candidat();

            Console.Write("\tVotre Nom: ");
            candidat.Lastname = Console.ReadLine();
            Console.Write("\tVotre Prénom : ");
            candidat.Firstname = Console.ReadLine();
            Console.Write("\tVotre Sexe M./Mme: ");
            candidat.Gender = Console.ReadLine();
            Console.WriteLine();

            candidat.Quiz(candidat.Firstname, candidat.Lastname, candidat.Gender);


        }
 
    }
    
}
