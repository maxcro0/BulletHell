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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lunaticButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreencs());
        }
    }
}
