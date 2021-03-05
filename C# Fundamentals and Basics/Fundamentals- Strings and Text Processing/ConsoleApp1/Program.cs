using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///string - referent type
            ///string - immutable;///They are read only 
            string text = "Exam";
            string newText = "Retake Exam";
            string third= String.Concat(text, newText);

            string txt = new string(new char[] { '1', '2', '3', '4' });
            Console.WriteLine(txt.ToCharArray());


            string texte = "Hello, from, Softuni, my name, is ,Pesho";
            int indexOfComma = texte.LastIndexOf(',');
            Console.WriteLine(indexOfComma);


            ///Substring
            string substring = texte.Substring(texte.Length-6);
            //text.IndexOf(', ', )
            string substring2 = new string(texte.Reverse().ToArray());

            Console.WriteLine(substring);

            ////Split()
            ///
            char[] separators = { '!', ',' };
            string[] words = text.Split(separators);


        }
    }
}
