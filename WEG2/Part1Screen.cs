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
    public partial class Part1Screen : UserControl
    {
        //Create buttons for the player movement and a button for the pause screen
        Boolean upArrowDown, downArrowDown, leftArrowDown, rightArrowDown, escapeDown;

        //Create brushes to draw with 
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush greenBrush = new SolidBrush(Color.Green);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush testBrush = new SolidBrush(Color.Orange);

        //Create one list for the enemies 
        List<Entity> enemy = new List<Entity>();

        //Create two lists, one for the map that the player is allowed to travel on and another for the boundaries
        List<Entity> boundaries = new List<Entity>();
        List<Entity> playground = new List<Entity>();

        //Create a list for the coins
        List<Entity> coins = new List<Entity>();

        //Player values 
        Entity player;

        //Key values
        Entity key;

        public Part1Screen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //TODO - Get the coordinates for the boundaries and add them to the boundaries list


            //TODO - Get the coordinates for the player area and add them to the playground list


            //TODO - Get the coordinates for the player starting location 
            player = new Entity(140, 290, 14, 14, 3); 

            //TODO - Get the coordinates for the coins and add them to the coins list


            //TODO - Get the coordinates for the key 


        }

        private void Part1Screen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Add the up, down, left, right keys and set them to true
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Escape:
                    escapeDown = true;
                    break;
            }
        }

        private void Part1Screen_KeyUp(object sender, KeyEventArgs e)
        {
            //Add the up, down, left, right keys and set them to false
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Escape:
                    escapeDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            this.Focus();
            //TODO - Move the player
            if (upArrowDown)
            {
                player.Move("Up");
            }

            if (downArrowDown)
            {
                player.Move("Down");
            }

            if (leftArrowDown)
            {
                player.Move("Left");
            }

            if (rightArrowDown)
            {
                player.Move("Right");
            }

            //TODO - Move the enemies


            //TODO - Check collision between player and boundaries


            //TODO - Check collision between player and enemies


            //TODO - Check collision between player and coins


            //TODO - Check collision between player and key 


        }

        private void Part1Screen_Paint(object sender, PaintEventArgs e)
        {
            //TODO - Draw the player (which should be a square)
            e.Graphics.FillRectangle(redBrush, player.x, player.y, player.sizeX, player.sizeY);

            //TODO - Draw the area which the player will be able to allowed on 


            //TODO - FOR NOW, draw in the boundaries but delete them after because they must not be showing


            //TODO - Draw the enemies
            e.Graphics.FillRectangle(testBrush, 50, 50, 10, 10); // JUST TESTING, DELETE AFTER
        }
    }
}
