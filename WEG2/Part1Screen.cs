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
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush testBrush = new SolidBrush(Color.Orange);

        //Create one list for the enemies 
        List<Entity> enemy = new List<Entity>();

        //Create two lists, one for the map that the player is allowed to travel on and another for the boundaries
        List<Entity> boundaries = new List<Entity>();
        List<Entity> playgroundGreen = new List<Entity>();
        List<Entity> playgroundWhite = new List<Entity>();
        List<Entity> playgroundGray = new List<Entity>();


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
            Entity boundary1 = new Entity(98, 250, 102, 102); //Spawn area
            playgroundGreen.Add(boundary1);
            Entity boundary2 = new Entity(200, 275, 50, 52);  //Bridge from spawn to main play area
            playgroundWhite.Add(boundary2);
            Entity boundary3 = new Entity(250, 200, 475, 75); //Top bar
            playgroundWhite.Add(boundary3);
            Entity boundary4 = new Entity(250, 327, 475, 75); //Bottom bar
            playgroundWhite.Add(boundary4);
            Entity boundary5 = new Entity(250, 275, 75, 52);  //First inside block
            playgroundWhite.Add(boundary5);
            Entity boundary6 = new Entity(375, 275, 75, 52);  //Second inside block
            playgroundWhite.Add(boundary6);
            Entity boundary7 = new Entity(525, 275, 75, 52);  //Third inside block
            playgroundWhite.Add(boundary7);
            Entity boundary8 = new Entity(650, 275, 75, 52);  //Fourth inside block
            playgroundWhite.Add(boundary8);
            Entity boundary9 = new Entity(725, 275, 50, 52);  //Bridge from main play area to barrier
            playgroundGray.Add(boundary9);
            Entity boundary10 = new Entity(775, 250, 72, 102);//White game win zone 
            playgroundWhite.Add(boundary10);
            Entity boundary11 = new Entity(847, 250, this.Width, 102); // Green game win zone
            playgroundGreen.Add(boundary11);
            //TODO - add the top two coin zone coordinates and the bottom coin zone coordinates (REMOVE THIS LINE OF COMMENTS AFTER)

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
            //TODO - Draw the area which the player will be allowed on 
            foreach (Entity p in playgroundGreen)
            {
                e.Graphics.FillRectangle(greenBrush, p.x, p.y, p.sizeX, p.sizeY);
            }

            foreach (Entity w in playgroundWhite)
            {
                e.Graphics.FillRectangle(whiteBrush, w.x, w.y, w.sizeX, w.sizeY);
            }

            foreach (Entity b in playgroundGray)
            {
                e.Graphics.FillRectangle(grayBrush, b.x, b.y, b.sizeX, b.sizeY);
            }

            //TODO - FOR NOW, draw in the boundaries but delete them after because they must not be showing


            //TODO - Draw the enemies
            e.Graphics.FillRectangle(testBrush, 50, 50, 10, 10); // JUST TESTING, DELETE AFTER

            //TODO - Draw the player (which should be a square)
            e.Graphics.FillRectangle(redBrush, player.x, player.y, player.sizeX, player.sizeY);
        }
    }
}
