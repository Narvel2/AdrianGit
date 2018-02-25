using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{
    class Palladin:Character
    {/// <summary>
     /// zmienne klasy
     /// </summary>
        private string spearthrow = "Taste my spear!!!!!!";
        private string masor = "Don't run away";
        private string furious = "I'm fast and furious!";

        private int attackwarr = 0;


        /// <summary>
        /// konstruktor domyslny
        /// </summary>
        public Palladin()
        {

        }
       
        public Palladin(string nameOfCharacter, int abilityPower, int attackDamage, int hp, int mana):base(nameOfCharacter,abilityPower,attackDamage,hp,mana)
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
            return spearthrow;
        }
        public override string Spellsecond()
        {
            return masor;
        }
        public override string Spellthird()
        {
            return furious;
        }
    }
}
