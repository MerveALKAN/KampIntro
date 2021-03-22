using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {


            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";
            string kurs5 = "C#";

            Console.WriteLine(kurs1); 
            Console.WriteLine(kurs2); 
            Console.WriteLine(kurs3); 
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array -dizi 
            string [] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "programlamaya başlangıç için temel kurs" ,
            "java" , "python", "C#" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");
    
            foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }
            
            Console.WriteLine("sayfasonu - footer");
        }
    }
}
