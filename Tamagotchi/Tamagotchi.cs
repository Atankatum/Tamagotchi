using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private bool isAlive = true;
        private List<string> words = new List<string>() {"Hola", "Que tal", "Buenos dias"};
        private Random generator = new Random();
        public string name = "";
        public void Feed()
        {
            hunger = hunger - 5;
            Console.WriteLine(name + " fue alimentado!" + "\n" + name + " ahora tiene " + hunger + " hambre");
            Console.ReadLine();     
        }
        public void Name ()
        {
            while (name.Length < 3)
            {
                System.Console.WriteLine("Ingrese un nombre, al menos 2 caracteres");
                name = Console.ReadLine();
            }

        }
        public void PrintStats
        {
            
        }
     }
}
