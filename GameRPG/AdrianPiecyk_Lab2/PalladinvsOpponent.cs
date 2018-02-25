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
    public partial class PalladinvsOpponent : Form
    {
        #region Analogicznie jak w oknie CharactervsOpponent
        Palladin palladin;
        Opponent monster;
        public PalladinvsOpponent()
        {
            InitializeComponent();
        }

        private void PalladinvsOpponent_Load(object sender, EventArgs e)
        {
            pictureBoxPalladin.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\palladin.jpg");
            pictureBoxMonster.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\monster.jpg");
            progressBarHPPalladin.Value = 100;
            progressBarManaPalladin.Value = 100;
            progressBarHPMonster.Value = 100;
            palladin = new Palladin("Patheon", 30, 130, 2400,700);
            textBoxADPalladin.Text =palladin.AttackDamage.ToString();
            textBoxAPPalladin.Text = palladin.AbilityPower.ToString();
            monster = new Opponent("GAZOL", 0, 0, 40, 10000);
            textBoxADMonster.Text = monster.AttackDamage.ToString();
        }

        private void buttonAttackPalladin_Click(object sender, EventArgs e)
        {
            monster.HP -= palladin.Attack();
            palladin.HP -= monster.Attack();

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
            if (palladin.HP <= 0)
            {
                palladin.HP = 0;
                progressBarHPPalladin.Value = palladin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPPalladin.Value = palladin.PercentHP();
            }
        }

        private void buttonSpearThrow_Click(object sender, EventArgs e)
        {
            palladin.Mana -= 150;
            palladin.HP -= monster.Attack();

            if (palladin.Mana <= 0)
            {
                buttonSpearThrow.Enabled = false;


            }
            else
            {
                progressBarManaPalladin.Value = palladin.PercentMana();
            }
            textBoxSpellsVoice.Text = palladin.Spellfirst();
            monster.HP -= 500;
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
            if (palladin.HP <= 0)
            {
                palladin.HP = 0;
                progressBarHPPalladin.Value = palladin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPPalladin.Value = palladin.PercentHP();
            }

        }

        private void buttonMasor_Click(object sender, EventArgs e)
        {
            palladin.Mana -= 250;
            palladin.HP -= monster.Attack();


            if (palladin.Mana <= 0)
            {
                buttonMasor.Enabled = false;

            }
            else
            {
                progressBarManaPalladin.Value = palladin.PercentMana();
            }
            textBoxSpellsVoice.Text = palladin.Spellsecond();
            monster.HP -= 700;
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
            if (palladin.HP <= 0)
            {
                palladin.HP = 0;
                progressBarHPPalladin.Value = palladin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPPalladin.Value = palladin.PercentHP();
            }
        }

        private void buttonFurious_Click(object sender, EventArgs e)
        {
            palladin.Mana -= 400;
            palladin.HP -= monster.Attack();


            if (palladin.Mana <= 0)
            {
                buttonFurious.Enabled = false;

            }
            else
            {
                progressBarManaPalladin.Value = palladin.PercentMana();
            }
            textBoxSpellsVoice.Text = palladin.Spellsecond();
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
            if (palladin.HP <= 0)
            {
                palladin.HP = 0;
                progressBarHPPalladin.Value = palladin.PercentHP();
                string message = "You are death, try again!";
                MessageBox.Show(message);
                this.Visible = false;
            }
            else
            {
                progressBarHPPalladin.Value = palladin.PercentHP();
            }
        }
    }
    #endregion
}
