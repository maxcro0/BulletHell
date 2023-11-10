using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell
{
    public partial class Gameover : UserControl
    {
        public Gameover()
        {
            InitializeComponent();
            overpointsOut.Text = GameScreencs.points + " Points";
            if (GameScreencs.win == true)
            {
                //Changes to you win if you won
                GameoverLabel.Text = "You Win!";
            }
        }

        private void tryagainButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreencs());
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new Menu());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
