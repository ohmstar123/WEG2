using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WEG2
{
    /// <summary>
    /// Goal is to obtain all four coins and making your way back to the start without touching the obstacles
    /// </summary>
    public partial class MainScreen : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.SelectSound);
        SoundPlayer playerBackGround = new SoundPlayer(Properties.Resources.backGroundMusic);

        public MainScreen()
        {
            InitializeComponent();
            playerBackGround.PlayLooping();
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            //end the program
            Application.Exit();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            //Add a game screen and center it
            player.PlaySync();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            Part1Screen p1 = new Part1Screen();
            f.Controls.Add(p1);
            p1.Location = new Point((f.Width - p1.Width) / 2, (f.Height - p1.Height) / 2);
            p1.Focus();
        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {
            //Add an instructions page and center the screen
            player.PlaySync();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            InstructionScreen ins = new InstructionScreen();
            f.Controls.Add(ins);
            ins.Location = new Point((f.Width - ins.Width) / 2, (f.Height - ins.Height) / 2);
            ins.Focus();
        }
    }
}
