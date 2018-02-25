using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdrianPiecyk_Lab2
{/// <summary>
 /// Moja klasa bazowa Character 
 /// </summary>
    public class Character
    {
        /// <summary>
        /// Ustawienia Properties
        /// </summary>
        public string NameOfCharacter { get; set; }
        public int AbilityPower { get; set; }
        public int AttackDamage{ get; set; }
        public int HP { get; set; }
        public int Mana { get; set; }

        public int MAXHP { get; set; }
        public int MAXMana { get; set; }

        /// <summary>
        /// zmienne klasy ustawilem domyslnie public wiem ze nie powinno sie tak robic za pozno o tym pomyslalem aby zadbac o hermetyzacje
        /// </summary>
        public int attack = 0;
        public string spellcastfirst="";
        public string spellcastsecond = "";
        public string spellcastthird = "";
        /// <summary>
        /// Domyslny konstruktor
        /// </summary>
        public Character()
        {
                
        }
        /// <summary>
        /// Konstruktor z parametrami oraz odrazu ustawianie parametrow 
        /// </summary>
        public Character(string nameOfCharacter,int abilityPower,int attackDamage,int hp,int mana)
        {
            NameOfCharacter = nameOfCharacter;
            AbilityPower = abilityPower;
            AttackDamage = attackDamage;
            HP = hp;
            Mana = mana;
            MAXHP = hp;
            MAXMana = mana;
            

        }
        /// <summary>
        /// Funkcja wirtualna ataku ktora bedzie nadpisywana i modyfkowana w zaleznosci od klasy
        /// </summary>
        
        public virtual int Attack()
        {
            
            return attack;
        }
        /// <summary>
        /// Funkcja ktora zamienia hp na postac procentowa zaokrogla w dol math.floor
        /// </summary>
        public int PercentHP()
        {
            return (int)Math.Floor((double)HP / (double)MAXHP * (double)100);

        }/// <summary>
         /// Funkcja ktora zamienia mane na postac procentowa zaokrogla w dol math.floor
         /// </summary>
        public int PercentMana()
        {
            return (int)Math.Floor((double)Mana / (double)MAXMana * (double)100);
        }
        /// <summary>
        /// 3 Funkcje virtualna ktore beda nadpisywane sluza do ustawienia tekstow spelli
        /// </summary>
        public virtual string Spellfirst()
        {
            return spellcastfirst;
        }
        public virtual string Spellsecond()
        {
            return spellcastsecond;
        }
        public virtual string Spellthird()
        {
            return spellcastthird;
        }

    }
}
