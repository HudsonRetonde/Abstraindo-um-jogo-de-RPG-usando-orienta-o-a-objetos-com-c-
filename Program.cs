// See https://aka.ms/new-console-template for more information
using System;
using Extraindo_jogo.src.Entites;

namespace dotenet___poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero Arus = new Hero("Aros", 23, "Knight");
            Hero wizard = new Extraindo_jogo.src.Entities.Wizard("Jennica", 23, "White Wizard");
          

            Console.WriteLine(wizard.Attack());
        }
    }


}

