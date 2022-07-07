using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Lançou magia!";
        }
        }
}
