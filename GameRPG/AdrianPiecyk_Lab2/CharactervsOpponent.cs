using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2
{
    public partial class WarriorvsOpponent : Form 
    {
        /// <summary>
        /// Deklaruje 2 obiekty klasy Warrior i Opponent
        /// </summary>
        Warrior warrior;
        Opponent monster;
        public WarriorvsOpponent()
        {
            InitializeComponent();
        }


        private void WarriorvsOpponent_Load(object sender, EventArgs e)
        {
            /// <summary>
            /// Ustawiam zjecia ze sciezek oraz ustawiam domyslnie wartsci dla paskow HP i Many na 100 oraz tworze 2 nowe obiekty warriora i monstera inicjujac ich odrazu wartosciami ktore podajew konstruktorze 
            /// </summary>
            pictureBoxWarrior2.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\warrior.jpg");
            pictureBoxMonster.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\monster.jpg");
            progressBarHPWarrior.Value = 100;
            progressBarManaWarrior.Value = 100;
            progressBarHPMonster.Value = 100;
            warrior = new Warrior("Aarax", 30, 110, 3000, 400);
            textBoxADWarrior.Text = warrior.AttackDamage.ToString();
            textBoxAPWarrior.Text = warrior.AbilityPower.ToString();
            monster = new Opponent("GAZOL",0,0,40,10000);
            textBoxADMonster.Text = monster.AttackDamage.ToString();
           

        }
        

        private void buttonAttackWarrior_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Po nacisnieciu przycisku HP monstera i warriora zostaja pomniejszone w zaleznosci od wartosci jakie znajduja sie w funkcji Attack() w klasie Warrior i Opponent
            /// </summary>
            monster.HP -= warrior.Attack();
            warrior.HP -= monster.Attack();
            /// <summary>
            /// Sprawdzam czy zycie potwora jest mniejsze badz rowne 0 jesli tak to uzytkownik wygrywa i wyskakuje komunikat oraz chowa sie dotychczasowe okno jesli zycie jest >0 do progressbar monstera jest przypisywana funkcja PercentHP() wywolywana dla obiektu monster
            /// </summary>
            if (monster.HP <= 0)
            {
                monster.HP = 0;
                progressBarHPMonster.Value = monster.PercentHP();
                string message = "Good job my friend your opponent has been killed!";
                MessageBox.Show(message);
                this.Visible = false;
  

            }
            else
            {
                progressBarHPMonster.Value = monster.PercentHP();
            }
            /// <summary>
            /// Sprawdzam czy zycie warriora jest mniejsze badz rowne 0 jesli tak to uzytkownik rpzegrywa i wyskakuje komunikat oraz chowa sie dotychczasowe okno jesli zycie jest >0 do progressbar uzytkownika jest przypisywana funkcja PercentHP() wywolywana dla obiektu warrior
            /// </summary>
            if (warrior.HP<=0)
            {
                warrior.HP = 0;
                progressBarHPWarrior.Value = warrior.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPWarrior.Value = warrior.PercentHP();
            }


        }
        

        
        private void buttonBerserker_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// pomniejszam mane i hp sprawdzam poziom many jesli jest mniejszy od 0 to wylaczam przycisk reszta tak jak wyzej
            /// </summary>
            warrior.Mana -= 150;
            warrior.HP -= monster.Attack();

            if (warrior.Mana<=0)
            {
                buttonBerserker.Enabled = false;

                
            }
            else
            {
                progressBarManaWarrior.Value = warrior.PercentMana();
            }
            textBoxSpellsVoice.Text=warrior.Spellfirst();
            monster.HP -= 600;
            if (monster.HP <= 0)
            {
                monster.HP = 0;
                progressBarHPMonster.Value = monster.PercentHP();
                string message = "Good job my friend your opponent has been killed!";
                MessageBox.Show(message);
                this.Visible = false;

            }
            else
            {
                progressBarHPMonster.Value = monster.PercentHP();
            }
            if (warrior.HP <= 0)
            {
                warrior.HP = 0;
                progressBarHPWarrior.Value = warrior.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPWarrior.Value = warrior.PercentHP();
            }



        }

        private void buttonDemacia_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Tak jak wyzej identycznie
            /// </summary>
            warrior.Mana -= 250;
            warrior.HP -= monster.Attack();


            if (warrior.Mana <= 0)
            {
                buttonDemacia.Enabled = false;

            }
            else
            {
                progressBarManaWarrior.Value = warrior.PercentMana();
            }
            textBoxSpellsVoice.Text = warrior.Spellsecond();
            monster.HP -= 1000;
            if (monster.HP <= 0)
            {
                monster.HP = 0;
                progressBarHPMonster.Value = monster.PercentHP();
                string message = "Good job my friend your opponent has been killed!";
                MessageBox.Show(message);
                this.Visible = false;
                

            }
            else
            {
                progressBarHPMonster.Value = monster.PercentHP();
            }
            if (warrior.HP <= 0)
            {
                warrior.HP = 0;
                progressBarHPWarrior.Value = warrior.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPWarrior.Value = warrior.PercentHP();
            }

        }

        private void buttonHPbooster_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Tak jak wyzej tylko z ta roznica ze Value przekracza wartosc max jaka jest 100 i wtedy wyrzuca blad nie starczylo mi czasu azeby sie z tym uporac
            /// </summary>
            warrior.HP += 100;
            warrior.Mana -= 100;
            textBoxSpellsVoice.Text = warrior.Spellthird();

            if (warrior.Mana <= 0)
            {
                buttonHPbooster.Enabled = false;
               

            }
            else
            {
                textBoxAPWarrior.Text = warrior.AbilityPower.ToString();
                progressBarHPWarrior.Value = warrior.PercentHP();
            }
            if (warrior.HP <= 0)
            {
                warrior.HP = 0;
                progressBarHPWarrior.Value = warrior.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPWarrior.Value = warrior.PercentHP();
            }

        }
    }
}
