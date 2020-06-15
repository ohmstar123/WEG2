using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEG2
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            //end the program
            Application.Exit();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            //add a message in the middle of the screen that says 
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Part1Screen p1 = new Part1Screen();
            f.Controls.Add(p1);
            p1.Location = new Point((f.Width - p1.Width) / 2, (f.Height - p1.Height) / 2);
            p1.Focus();
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            //TODO - add an instructions page and center the screen
        }
    }
}
