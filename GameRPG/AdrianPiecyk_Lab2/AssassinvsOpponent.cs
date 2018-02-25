using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2
{
    public partial class AssassinvsOpponent : Form
    {
        #region Tak samo jak w oknie CharactervOpponent wszystko tak samo tylko dla assassin a nie warriora
        Assassin assassin;
        Opponent monster;
        public AssassinvsOpponent()
        {
            InitializeComponent();
        }

        private void AssassinvsOpponent_Load(object sender, EventArgs e)
        {
            pictureBoxAssassin.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\assassin.jpg");
            pictureBoxMonster.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\monster.jpg");
            progressBarHPAssassin.Value = 100;
            progressBarManaAssassin.Value = 100;
            progressBarHPMonster.Value = 100;
            assassin = new Assassin("JED", 50, 170, 2200, 900);
            textBoxADAssassin.Text = assassin.AttackDamage.ToString();
            textBoxAPAssassin.Text = assassin.AbilityPower.ToString();
            monster = new Opponent("GAZOL", 0, 0, 40, 10000);
            textBoxADMonster.Text = monster.AttackDamage.ToString();
        }

        private void buttonShuriken_Click(object sender, EventArgs e)
        {
            assassin.Mana -= 50;
            assassin.HP -= monster.Attack();

            if (assassin.Mana <= 0)
            {
                buttonShuriken.Enabled = false;


            }
            else
            {
                progressBarManaAssassin.Value = assassin.PercentMana();
            }
            textBoxSpellsVoice.Text = assassin.Spellfirst();
            monster.HP -= 100;
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
            if (assassin.HP <= 0)
            {
                assassin.HP = 0;
                progressBarHPAssassin.Value = assassin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPAssassin.Value = assassin.PercentHP();
            }
        }

        private void buttonAttackAssassin_Click(object sender, EventArgs e)
        {
            monster.HP -= assassin.Attack();
            assassin.HP -= monster.Attack();

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
            if (assassin.HP <= 0)
            {
                assassin.HP = 0;
                progressBarHPAssassin.Value = assassin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPAssassin.Value = assassin.PercentHP();
            }
        }

        private void buttonDragonSwift_Click(object sender, EventArgs e)
        {

            assassin.Mana -= 250;
            assassin.HP -= monster.Attack();


            if (assassin.Mana <= 0)
            {
                buttonDragonSwift.Enabled = false;

            }
            else
            {
                progressBarManaAssassin.Value = assassin.PercentMana();
            }
            textBoxSpellsVoice.Text = assassin.Spellsecond();
            monster.HP -= 400;
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
            if (assassin.HP <= 0)
            {
                assassin.HP = 0;
                progressBarHPAssassin.Value = assassin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPAssassin.Value = assassin.PercentHP();
            }
        }

        private void buttonShadowAttack_Click(object sender, EventArgs e)
        {

            assassin.Mana -= 400;
            assassin.HP -= monster.Attack();


            if (assassin.Mana <= 0)
            {
                buttonShadowAttack.Enabled = false;

            }
            else
            {
                progressBarManaAssassin.Value = assassin.PercentMana();
            }
            textBoxSpellsVoice.Text = assassin.Spellsecond();
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
            if (assassin.HP <= 0)
            {
                assassin.HP = 0;
                progressBarHPAssassin.Value = assassin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPAssassin.Value = assassin.PercentHP();
            }
        }
    }
    #endregion
}
