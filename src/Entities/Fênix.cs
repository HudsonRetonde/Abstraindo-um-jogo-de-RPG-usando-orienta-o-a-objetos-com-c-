using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Fenix : Hero
    {
        public Fenix(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(int Bonus){

            if (Bonus > 6) {
                return this.Name + " Aveeee Fênixxxxx! Todo o meu ódio fomentado na ilha da Rainha da Morte em um único ataque! " + Bonus;     
            } else {
                return this.Name + " Aveeee Fênixxxxx! O que?? " + Bonus;
            }                     
        } 
    }
    
}