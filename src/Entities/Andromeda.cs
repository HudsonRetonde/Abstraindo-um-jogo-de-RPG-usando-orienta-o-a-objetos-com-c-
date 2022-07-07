using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Andromeda : Hero
    {
        public Andromeda(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(int Bonus){

            if (Bonus > 6) {
                return this.Name + " Coreente de Androomedaaa! A corrente é uma arma magnífica! Defesa e ataque em ple sincronia!! " + Bonus;     
            } else {
                return this.Name + " Coreente de Androomedaaa! Não pode ser! Minha corrente não causou nenhum dano!!! " + Bonus;
            }                     
        } 
    }
}