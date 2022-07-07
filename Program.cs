// See https://aka.ms/new-console-template for more information
using System;
using Extraindo_jogo.src.Entites;
using Extraindo_jogo.src.Entities;

namespace dotenet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Pegasu seya = new Pegasu("Seya", 23, "Cavaleiro de Pégasu");
            Dragao shiryu = new Dragao("Shiryu", 23, "Cavaleiro de Dragão");
            Andromeda shun = new Andromeda("Shun", 23, "Cavaleiro de Andrômeda");
            Cisne hyoga = new Cisne("Hyoga", 23, "Cavaleiro de Cisne");
            Fenix ikki = new Fenix("Ikke", 30, "Cavaleiro de Fênix");
            
          

            Console.WriteLine(shiryu.Attack(1));
            Console.WriteLine(shiryu.Attack(7));
            Console.WriteLine(seya.Attack(2));
            Console.WriteLine(seya.Attack(8));
            Console.WriteLine(shun.Attack(3));
            Console.WriteLine(shun.Attack(9));
            Console.WriteLine(hyoga.Attack(2));
            Console.WriteLine(hyoga.Attack(8));
            Console.WriteLine(ikki.Attack(3));
            Console.WriteLine(ikki.Attack(9));
        }
    }


}

