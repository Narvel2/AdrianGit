using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{
    class Assassin:Character
    {
        public string shuriken = "SHURIKEN!!!!!!";
        public string dragonswift = "AAAAAaaaaa Dragon Switft!!!!!!!!!";
        public string shadowattack = "Die! Faster DIE!";

        public int attackwarr = 0;



        public Assassin()
        {

        }
        public Assassin(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana):base(nameOfCharacter,abilityPower,attackDamage,hp,mana)
        {
            NameOfCharacter = nameOfCharacter;
            AbilityPower = abilityPower;
            AttackDamage = attackDamage;
            HP = hp;
            Mana = mana;
            MAXHP = hp;
        }
        public override int Attack()
        {
            attackwarr = this.AttackDamage;
            return attackwarr;
        }
        public override string Spellfirst()
        {
            return shuriken;
        }
        public override string Spellsecond()
        {
            return dragonswift;
        }
        public override string Spellthird()
        {
            return shadowattack;
        }
    }
}
