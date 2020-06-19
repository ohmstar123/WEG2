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
    public partial class WinScreen : UserControl
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.SelectSound);
        

        public WinScreen()
        {
            InitializeComponent();
            SoundPlayer playerVictory = new SoundPlayer(Properties.Resources.VictoryMusic);
            playerVictory.Play();
        }

        private void playGameButton_Click(object sender, EventArgs e)
        {
            player.PlaySync();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            Part1Screen p1 = new Part1Screen();
            f.Controls.Add(p1);
            p1.Location = new Point((f.Width - p1.Width) / 2, (f.Height - p1.Height) / 2);
            p1.Focus();
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            player.PlaySync();

            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
        }
    }
}
