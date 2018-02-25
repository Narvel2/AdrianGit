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
    public partial class MagevsOpponent : Form
    {
        #region Tak samo jak w oknie CharactervsOpponent tylko dla obiektu mag
        Opponent monster;
        Mage mag;
        public MagevsOpponent()
        {
            InitializeComponent();
        }

        private void MagevsOpponent_Load(object sender, EventArgs e)
        {
            pictureBoxMage.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\mage.png");
            pictureBoxMonster.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\monster.jpg");
            progressBarHPMage.Value = 100;
            progressBarManaMage.Value = 100;
            progressBarHPMonster.Value = 100;
            mag = new Mage("Darsy", 1100, 100, 1500, 1600);
            textBoxADMage.Text = mag.AttackDamage.ToString();
            textBoxAPMage.Text = mag.AbilityPower.ToString();
            monster = new Opponent("GAZOL", 0, 0, 40, 10000);
            textBoxADMonster.Text = monster.AttackDamage.ToString();

        }

        private void buttonAttackMage_Click(object sender, EventArgs e)
        {
            monster.HP -= mag.Attack();
            mag.HP -= monster.Attack();

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
            if (mag.HP <= 0)
            {
                mag.HP = 0;
                progressBarHPMage.Value = mag.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPMage.Value = mag.PercentHP();
            }

        }

        private void buttonFireBomb_Click(object sender, EventArgs e)
        {
            mag.Mana -= 150;
            mag.HP -= monster.Attack();

            if (mag.Mana <= 0)
            {
                buttonFireBomb.Enabled = false;

            }
            else
            {
                progressBarManaMage.Value = mag.PercentMana();
            }
            textBoxSpellsVoice.Text = mag.Spellfirst();
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
            if (mag.HP <= 0)
            {
                mag.HP = 0;
                progressBarHPMage.Value = mag.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPMage.Value = mag.PercentHP();
            }

        }

        private void buttonDarkPulse_Click(object sender, EventArgs e)
        {
            mag.Mana -= 200;
            mag.HP -= monster.Attack();
            if (mag.Mana <= 0)
            {
                buttonDarkPulse.Enabled = false;

            }
            else
            {
                progressBarManaMage.Value = mag.PercentMana();
            }
            textBoxSpellsVoice.Text = mag.Spellsecond();
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
            if (mag.HP <= 0)
            {
                mag.HP = 0;
                progressBarHPMage.Value = mag.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPMage.Value = mag.PercentHP();
            }

        }

        private void buttonManaRestore_Click(object sender, EventArgs e)
        {
            mag.Mana += 300;
            mag.HP -= monster.Attack();

            textBoxSpellsVoice.Text = mag.Spellthird();

            if (mag.Mana <= 0)
            {
                buttonManaRestore.Enabled = false;
               

            }
            else
            {
                
                progressBarManaMage.Value = mag.PercentMana();
            }
            if (mag.HP <= 0)
            {
                mag.HP = 0;
                progressBarHPMage.Value = mag.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPMage.Value = mag.PercentHP();
            }
        }
    }
    #endregion
}
