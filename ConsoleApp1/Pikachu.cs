using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IPokemon
    {
        // interface method (does not have a body)
        void pokemonSound(); 
    }
    interface IElectricType
    {
        void attackList();
    }

    class Pikachu : IPokemon, IElectricType
    {
        public void pokemonSound()
        {
            // The body of pokemonSound() is provided here
            Console.WriteLine("Pikachoo!");
        }
        public void attackList()
        {
            Console.WriteLine("Thundershock");
            Console.WriteLine("Thunderwave");
            Console.WriteLine("Thunderbolt");
        }
    }
}

//Pikachu pika = new Pikachu();
//pika.pokemonSound();
//pika.attackList();
