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
    public partial class Game_Details : Form
    {
        public Game_Details()
        {
            InitializeComponent();
         
        }

        private void Game_Details_Load(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(@"C:\Users\Adrian\Desktop\c# obraz\szczegoly.jpg");
            labelGameDetails.Text = "Gra stworzona w celach laboratorium na zajęcia koła naukowego KREDEK by Adrian Piecyk";
        }
    }
}
