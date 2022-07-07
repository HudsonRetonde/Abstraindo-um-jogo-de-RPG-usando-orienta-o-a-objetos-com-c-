using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Cisne : Hero
    {
        public Cisne(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(int Bonus){

            if (Bonus > 6) {
                return this.Name + " Póooo de Diamanteee! O frio da cibéria reunido em um único ataque! " + Bonus;     
            } else {
                return this.Name + " Póooo de Diamanteee! Meu ar congelado parece uma leve brisa!! " + Bonus;
            }                     
        } 
    }
    
}