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
            Kinigth Arus = new Kinigth("Aros", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
          

            Console.WriteLine(wizard.Attack());
        }
    }


}

