using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{
    class Warrior:Character
    {/// <summary>
     /// zmienne klasy
     /// </summary>
        protected string berserker = "BERSERKERRRRRRRRR!!!!!!";
        protected string demacia = "AAAAAaaaaa DEMACIA MY FRIEND!!!!!!!!!";
        protected string hpBooster = "MORE more HP HEAL ME!";

        protected int attackwarr = 0;


        /// <summary>
        /// konstruktor domyslny
        /// </summary>
        public Warrior()
        {

        }
        /// <summary>
        ///konstruktor z parametrami oraz ich ustawianie
        /// </summary>
        public Warrior(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana):base(nameOfCharacter,abilityPower,attackDamage,hp,mana)
        {
            NameOfCharacter = nameOfCharacter;
            AbilityPower = abilityPower;
            AttackDamage = attackDamage;
            HP = hp;
            Mana = mana;
            MAXHP = hp;
        }
        /// <summary>
        /// nadpisywanie metody atack
        /// </summary>
        public override int Attack()
        {
            attackwarr = this.AttackDamage;
            return attackwarr;
        }
        public override string Spellfirst()
        {
            return berserker;
        }
        public override string Spellsecond()
        {
            return demacia;
        }
        public override string Spellthird()
        {
            return hpBooster;
        }

    }
}
