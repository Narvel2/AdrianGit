using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdrianPiecyk_Lab2
{
    public partial class FormWindow : Form
    {
        int value = 0;
        
        
        public FormWindow()
        {
            InitializeComponent();
            /// <summary>
            /// startuje moj licznik ktory wykorzystam do progress 
            /// </summary>
            timerLoader.Start();
        }

        private void FormWindow_Load(object sender, EventArgs e)
        {/// <summary>
         /// Wczytyje tlo po sciezce
         /// </summary>
            BackgroundImage = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\tlo.jpg");
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGameDetails_Click(object sender, EventArgs e)
        {/// <summary>
         /// Tworze nowe okno 
         /// </summary>
            Game_Details game_detail = new Game_Details();
            game_detail.Show();
        }

        private void timerLoader_Tick(object sender, EventArgs e)
        {/// <summary>
         /// Zwiekszam wartosc licznika o 1 i ustawiam skok dla progressbara o wartosci 10 jesli progress bar bedzie zaladowany przycisk nowej gry bedzie dostepny
         /// </summary>
            progressBarLoader.Increment(10);
            value++;
            if (value >= 50)
            {
                buttonNewGame.Enabled = true;
            }
            else
            {
                buttonNewGame.Enabled = false;
            }

        }

        private void progressBarLoader_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {/// <summary>
         /// Tworze nowe okno
         /// </summary>
            ChooseCharacter chooseCharacter = new ChooseCharacter();
            chooseCharacter.Show();
            
        }
    }
}
