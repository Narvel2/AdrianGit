using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{
    class Opponent:Character
    {
        public Opponent()
        {
                
        }
        public Opponent(string nameOfCharacter,int abilityPower ,int mana,int attackDamage,int hp): base(nameOfCharacter, abilityPower,  attackDamage,  hp,  mana)
        {
            NameOfCharacter = nameOfCharacter;
            AttackDamage = attackDamage;
            AbilityPower = 0;
            Mana = 0;
            HP = hp;
            MAXHP = hp;

        }
        public override int Attack()
        {
            Random randomattackmonster = new Random();
            attack=randomattackmonster.Next(10, 70);
            return attack;
        }
    }
}
