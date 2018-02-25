using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2
{
    public partial class ChooseCharacter : Form
    {
        public ChooseCharacter()
        {
            InitializeComponent();
        }

        private void ChooseCharacter_Load(object sender, EventArgs e)
        {/// <summary>
         /// Wczytuje zdjecia z pliku
         /// </summary>
            pictureBoxWarrior.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\warrior.jpg");
            pictureBoxMage.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\mage.png");
            pictureBoxAssassin.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\assassin.jpg");
            pictureBoxPalladin.Image = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\palladin.jpg");

            labelChooseCharacter.Text = "Choose your charakter";
        }
        /// <summary>
        /// Pod tymi 4 funkcjami oblugi przyciskow tworze kolejo 4 nowe okna
        /// </summary>
        private void buttonCreateWarrior_Click(object sender, EventArgs e)
        {
            WarriorvsOpponent charactervsopponent = new WarriorvsOpponent();
            charactervsopponent.Show();
             
        }

        private void buttonCreateMage_Click(object sender, EventArgs e)
        {
            MagevsOpponent magevsopponent = new MagevsOpponent();
            magevsopponent.Show();
        }

        private void buttonCreateAssassin_Click(object sender, EventArgs e)
        {
            AssassinvsOpponent assassinvsopponent = new AssassinvsOpponent();
            assassinvsopponent.Show();
        }

        private void buttonCreatePalladin_Click(object sender, EventArgs e)
        {
            PalladinvsOpponent palladinvsopponent = new PalladinvsOpponent();
            palladinvsopponent.Show();
        }
    }
}
