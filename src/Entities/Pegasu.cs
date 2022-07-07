using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Pegasu : Hero
    {
        public Pegasu(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou ataque!";
        }
        public string Attack(int Bonus){

            if (Bonus > 6) {
                return this.Name + " Meteoro de Pegasuuuuuu! Receba meus meteoros!!! " + Bonus;     
            } else {
                return this.Name + " Meteoro de Pegasuuuuuu! Não pode ser! Meus meteoros não estão surtindo efeito!!! " + Bonus;
            }
                     
        }
    }
}
