using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Cat
    {
        //public string Name{ get; set;}

        //public string breed { get; set; }

        //public int age { get; set; }
        public Cat()//string name
        {
            //Name = name;///WHEN YOU TYPE SOME PARAMETER OF THE CONSTRUCTOR YOU SHOULD SET THE VALUE 
            //OR YOU DONT DO ANYTHING WITH IT (LIKE HERE)

            ///INICIALISING THE LIST IN THE CONSTRUCTOR SO WE DONT DO IT IN PROGRAM.CS
            ///BECAUSE OF THIS THE CONSTRUCTOR IS HELPFUL
            Kittens = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Kittens { get; set; }

        public int Age { get; set; }
        public double Fat { get; set; }
        public void Eat()
        {
            Fat += 200;
        }

    }
}
 