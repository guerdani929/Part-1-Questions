using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1_Questions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("DDDD    GGG ");
            Console.WriteLine("D   D  G   G");
            Console.WriteLine("D   D  G ");
            Console.WriteLine("D   D  GGGGG");
            Console.WriteLine("D   D  G   G");
            Console.WriteLine("D   D  G   G ");
            Console.WriteLine("DDDD    GGG ");


            string firstName = "Daniel";
            string favMovie = "The Matrix";

            firstName = firstName.ToLower();
            favMovie = favMovie.ToLower();

            Console.WriteLine($"Greetings {firstName} is your favourite movie {favMovie}?".ToLower());

            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);

            Console.WriteLine(favMovie.Contains("THE"));

            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");

            Console.WriteLine(favMovie);

       



            Console.ReadLine();
        }
    }
}
