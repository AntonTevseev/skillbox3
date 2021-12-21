using System;
using static System.Console;
namespace HellApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Антон Тевсеев";
            int age = 17;
            string Email = "tevseevanton2@gmail.com";


            int programing = 5;
            double math = 4.2;
            double physics = 2.1;

            var score = (programing + math + physics) / 3;
            string stro = "Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} \nСредний бал: {3}";

            WriteLine(stro,
            FullName,
            age,
            Email,
            score);
            ReadKey();
        }
    }
}