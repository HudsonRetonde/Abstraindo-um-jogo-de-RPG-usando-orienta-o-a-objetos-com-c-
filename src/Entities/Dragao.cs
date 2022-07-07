using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Extraindo_jogo.src.Entites;

namespace Extraindo_jogo.src.Entities
{
    public class Dragao : Hero
    {
        public Dragao(string Name, int Level, string HeroType) : base(Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public string Attack(int Bonus){

            if (Bonus > 6) {
                return this.Name + " Cóolera do Dragãooooo! Esse é o meu golpe mais poderoso!!! " + Bonus;     
            } else {
                return this.Name + " Cóolera do Dragãooooo! Não pode ser! Minha Cólera do Drão, o golpe mais poderoso ensinado pelo mestre Ancião, não fez nenhum arraão!!! " + Bonus;
            }                     
        } 
    }
    
}