using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{
    class Mage:Character
    {/// <summary>
    /// zmienne klasy
    /// </summary>
        private string firebomb = "Fire bomb RUN!!!!!!!";
        private string darkpulse = "AAAAAaaaaa Dark Pulse You're death!!!!!!!!!";
        private string manarestore = "MY mana back ahahahahaa";

        private int attackmag = 0;
        /// <summary>
        /// konstruktor domyslny
        /// </summary>
        public Mage()
        {

        }
        /// <summary>
        ///konstruktor z parametrami oraz ich ustawianie
        /// </summary>
      
        public Mage(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana):base(nameOfCharacter,abilityPower,attackDamage,hp,mana)
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
            attackmag = this.AttackDamage/2;
            return attackmag;
        }
        public override string Spellfirst()
        {
            return firebomb;
        }
        public override string Spellsecond()
        {
            return darkpulse;
        }
        public override string Spellthird()
        {
            return manarestore;
        }
    }
}
