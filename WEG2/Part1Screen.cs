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
        SolidBrush yellowBrush = new SolidBrush(Color.Goldenrod);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        SolidBrush greenBrush = new SolidBrush(Color.LimeGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        //Create one list for the enemies 
        List<Entity> enemy = new List<Entity>();

        //Create two lists, one for the map that the player is allowed to travel on and another for the boundaries
        List<Entity> boundaries = new List<Entity>();
        List<Entity> playgroundGreen = new List<Entity>();
        List<Entity> playgroundWhite = new List<Entity>();
        List<Entity> playgroundGray = new List<Entity>();

        //Create a list for the coins
        List<Entity> coinList = new List<Entity>();
        int coinNumber = 0;

        //Player values 
        Entity player;
        int playerSpeed = 5;

        //Gate boolean 
        Boolean gateOpenClose = false;

        //Variable to store number of deaths
        int fails = 0;

        

        public Part1Screen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //Variables used
            int monSpeed = 3;
            int monSize = 14;

            //Get the coordinates for the player area and add them to the playground list
            Entity playArea1 = new Entity(98, 250, 102, 102); //Spawn area
            playgroundGreen.Add(playArea1);
            Entity playArea2 = new Entity(200, 275, 50, 52);  //Bridge from spawn to main play area
            playgroundWhite.Add(playArea2);
            Entity playArea3 = new Entity(250, 200, 475, 75); //Top bar
            playgroundWhite.Add(playArea3);
            Entity playArea4 = new Entity(250, 327, 475, 75); //Bottom bar
            playgroundWhite.Add(playArea4);
            Entity playArea5 = new Entity(250, 275, 75, 52);  //First inside block
            playgroundWhite.Add(playArea5);
            Entity playArea6 = new Entity(375, 275, 75, 52);  //Second inside block
            playgroundWhite.Add(playArea6);
            Entity playArea7 = new Entity(525, 275, 75, 52);  //Third inside block
            playgroundWhite.Add(playArea7);
            Entity playArea8 = new Entity(650, 275, 75, 52);  //Fourth inside block
            playgroundWhite.Add(playArea8);
            Entity playArea9 = new Entity(725, 275, 50, 52);  //Bridge from main play area to barrier
            playgroundGray.Add(playArea9);
            Entity playArea10 = new Entity(775, 250, this.Width, 102);//White game win zone 
            playgroundWhite.Add(playArea10);
            Entity playArea11 = new Entity(325, 179, 50, 21); //Bridge to first coin area
            playgroundWhite.Add(playArea11);
            Entity playArea12 = new Entity(312, 137, 75, 42); //First coin area
            playgroundWhite.Add(playArea12);
            Entity playArea13 = new Entity(600, 179, 50, 21); //Bridge to second coin area
            playgroundWhite.Add(playArea13);
            Entity playArea14 = new Entity(587, 137, 75, 42); //Second coin area
            playgroundWhite.Add(playArea14);
            Entity playArea15 = new Entity(462, 402, 50, 21); //Bridge to thrid coin area
            playgroundWhite.Add(playArea15);
            Entity playArea16 = new Entity(450, 423, 75, 42); //Third coin area
            playgroundWhite.Add(playArea16);


            //Get the coordinates for the boundaries and add them to the boundaries list
            Entity boundary1 = new Entity(0, 0, this.Width, 137); //Top Bar
            boundaries.Add(boundary1);
            Entity boundary2 = new Entity(0, 137, 312, 42); //Right bar on same horizontal plane as first coin area
            boundaries.Add(boundary2);
            Entity boundary3 = new Entity(387, 137, 200, 42); //Middle bar on same horizontal plane as first coin area
            boundaries.Add(boundary3);
            Entity boundary4 = new Entity(662, 137, this.Width, 42);//Right bar on same horizontal plane as first coin area
            boundaries.Add(boundary4);
            Entity boundary5 = new Entity(0, 179, 325, 21); //Left bar on same horizontal plane as bridge to first coin area
            boundaries.Add(boundary5);
            Entity boundary6 = new Entity(375, 179, 225, 21); //Middle bar on same horizontal plane as bridge to first coin area
            boundaries.Add(boundary6);
            Entity boundary7 = new Entity(650, 179, this.Width, 21); //Right bar on same horizontal plane as bridge at first coin area
            boundaries.Add(boundary7);
            Entity boundary8 = new Entity(0, 200, 250, 50); //Left bar on same horizontal plane as the top bar of the playground
            boundaries.Add(boundary8);
            Entity boundary9 = new Entity(725, 200, this.Width, 50); //Right bar on same horizontal plane as the top bar of the playground
            boundaries.Add(boundary9);
            Entity boundary10 = new Entity(0, 250, 98, 102); //Left square boundary of the spawn area
            boundaries.Add(boundary10);
            Entity boundary11 = new Entity(200, 250, 50, 25); //Small boundary above the bridge that connects spawn to main play area
            boundaries.Add(boundary11);
            Entity boundary12 = new Entity(725, 250, 50, 25); //Small boundary above the grey barrier
            boundaries.Add(boundary12);
            Entity boundary13 = new Entity(200, 327, 50, 25); //Small boundary below the bridge that connects spawn to main play area
            boundaries.Add(boundary13);
            Entity boundary14 = new Entity(725, 327, 50, 25); //Small boundary below the barrier
            boundaries.Add(boundary14);
            Entity boundary15 = new Entity(0, 352, 250, 50); //Left bar on same horizontal plane as the bottom bar of the playground
            boundaries.Add(boundary15);
            Entity boundary16 = new Entity(725, 352, this.Width, 50); //Right bar on same horizontal plane as the bottom bar of the playground
            boundaries.Add(boundary16);
            Entity boundary17 = new Entity(0, 402, 462, 21); //Left bar on same horizontal plane as bridge to third coin area
            boundaries.Add(boundary17);
            Entity boundary18 = new Entity(512, 402, this.Width, 21); //Right bar on same horizontal plane as bridge to third coin area
            boundaries.Add(boundary18);
            Entity boundary19 = new Entity(0, 423, 450, 42); //Left bar on same horizontal plane as third coin area
            boundaries.Add(boundary19);
            Entity boundary20 = new Entity(525, 423, this.Width, 42); //Right bar on same horizontal plane as third coin area
            boundaries.Add(boundary20);
            Entity boundary21 = new Entity(0, 465, this.Width, this.Height); //Bottom bar
            boundaries.Add(boundary21);
            Entity boundary22 = new Entity(325, 275, 50, 52); // Inside first block
            boundaries.Add(boundary22);
            Entity boundary23 = new Entity(450, 275, 75, 52); //Inside second block
            boundaries.Add(boundary23);
            Entity boundary24 = new Entity(600, 275, 50, 52); //Inside third block
            boundaries.Add(boundary24);
            Entity boundary25 = new Entity(this.Width, 0, 0, this.Height); //Right wall boundary
            boundaries.Add(boundary25);
            Entity boundary26 = new Entity(725, 275, 50, 52); //Boundary on top of gate infront of 4th coin
            boundaries.Add(boundary26);

            //TODO - Get the coordinates for the monsters 
            Entity monster1 = new Entity(254, 206, monSize, monSize, monSpeed, 1); //Top right monster #1
            enemy.Add(monster1);
            Entity monster2 = new Entity(254, 230, monSize, monSize, monSpeed, 1); //Top right monster #2
            enemy.Add(monster2);
            Entity monster3 = new Entity(254, 254, monSize, monSize, monSpeed, 1); //Top right monster #3
            enemy.Add(monster3);
            Entity monster4 = new Entity(705, 382, monSize, monSize, monSpeed, 2); //Bottom Left monster #1
            enemy.Add(monster4);
            Entity monster5 = new Entity(705, 358, monSize, monSize, monSpeed, 2); //Bottom Left monster #2
            enemy.Add(monster5);
            Entity monster6 = new Entity(705, 334, monSize, monSize, monSpeed, 2); //Bottom Left monster #3
            enemy.Add(monster6);
            Entity monster7 = new Entity(254, 385, monSize, monSize, monSpeed, 3); //Left side going up #1
            enemy.Add(monster7);
            Entity monster8 = new Entity(278, 385, monSize, monSize, monSpeed, 3); //Left side going up #2
            enemy.Add(monster8);
            Entity monster9 = new Entity(302, 385, monSize, monSize, monSpeed, 3); //Left side going up #3
            enemy.Add(monster9);
            Entity monster10 = new Entity(380, 202, monSize, monSize, monSpeed, 4); //Middle left side going down #1
            enemy.Add(monster10);
            Entity monster11 = new Entity(404, 202, monSize, monSize, monSpeed, 4); //Middle left side going down #2
            enemy.Add(monster11);
            Entity monster12 = new Entity(428, 202, monSize, monSize, monSpeed, 4); //Middle left side going down #3
            enemy.Add(monster12);
            Entity monster13 = new Entity(530, 385, monSize, monSize, monSpeed, 3); //Middle right side going up #1
            enemy.Add(monster13);
            Entity monster14 = new Entity(554, 385, monSize, monSize, monSpeed, 3); //Middle right side going up #2
            enemy.Add(monster14);
            Entity monster15 = new Entity(578, 385, monSize, monSize, monSpeed, 3); //Middle right side going up #3
            enemy.Add(monster15);
            Entity monster16 = new Entity(655, 202, monSize, monSize, monSpeed, 4); //Right side going down #1
            enemy.Add(monster16);
            Entity monster17 = new Entity(679, 202, monSize, monSize, monSpeed, 4); //Right side going down #2
            enemy.Add(monster17);
            Entity monster18 = new Entity(703, 202, monSize, monSize, monSpeed, 4); //Right side going down #3
            enemy.Add(monster18);
            

            //Get the coordinates for the player starting location 
            player = new Entity(140, 290, 14, 14, playerSpeed);

            //Get the coordinates for the coins and add them to the coins list
            Entity coin1 = new Entity(341, 153, 14, 14, 0);
            coinList.Add(coin1);
            Entity coin2 = new Entity(617, 153, 14, 14, 0);
            coinList.Add(coin2);
            Entity coin3 = new Entity(480, 435, 14, 14, 0);
            coinList.Add(coin3);
            Entity coin4 = new Entity(830, 293, 14, 14, 0);
            coinList.Add(coin4);
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            gameLoop.Enabled = true;
            pauseBackGround.Visible = false;
            continueButton.Visible = false;
            exitButton.Visible = false;
            upArrowDown = false;
            downArrowDown = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
            ms.Focus();
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
            //Create temp x and y values for the player which will be used in collision method with boundaries
            int tempX = player.x;
            int tempY = player.y;

            //Update number of fails counter and coins counter
            coinLabel.Text = "COINS: " + coinNumber + " / 4";
            failLabel.Text = "FAILS: " + fails;

            //Check to see if the gate should be opened
            if (coinList[0].speed == 1 & coinList[1].speed == 1 & coinList[2].speed == 1)
            {
                gateOpenClose = true;
                boundaries[25].x = 0;
                boundaries[25].y = 0;
                boundaries[25].sizeX = 0;
                boundaries[25].sizeY = 0;
            }
            else
            {
                gateOpenClose = false;
                boundaries[25].x = 725;
                boundaries[25].y = 275;
                boundaries[25].sizeX = 50;
                boundaries[25].sizeY = 52;
            }
           


            //Move the player
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

            //Add a pause menu
            if (escapeDown)
            {
                gameLoop.Enabled = false;
                continueButton.Visible = true;
                exitButton.Visible = true;
                pauseBackGround.Visible = true;
            }



            //Move the enemies
            for (int i = 0; i < enemy.Count; i++)
            {
                if (enemy[i].positionNumber == 1)
                {
                    enemy[i].x = enemy[i].x + enemy[i].speed;
                }
                else if (enemy[i].positionNumber == 2)
                {
                    enemy[i].x = enemy[i].x - enemy[i].speed;
                }
                else if (enemy[i].positionNumber == 3)
                {
                    enemy[i].y = enemy[i].y - enemy[i].speed;
                }
                else if (enemy[i].positionNumber == 4)
                {
                    enemy[i].y = enemy[i].y + enemy[i].speed;
                }

                if (enemy[i].x >= 705 & enemy[i].positionNumber == 1)
                {
                    enemy[i].positionNumber = 2;
                    enemy[i].x = enemy[i].x - enemy[i].speed;
                }
                else if (enemy[i].x <= 254 & enemy[i].positionNumber == 2)
                {
                    enemy[i].positionNumber = 1;
                    enemy[i].x = enemy[i].x + enemy[i].speed;
                }
                else if (enemy[i].y <= 202 & enemy[i].positionNumber == 3)
                {
                    enemy[i].positionNumber = 4;
                    enemy[i].y = enemy[i].y + enemy[i].speed;
                }
                else if (enemy[i].y >= 385 & enemy[i].positionNumber == 4)
                {
                    enemy[i].positionNumber = 3;
                    enemy[i].y = enemy[i].y - enemy[i].speed;
                }
            }

            //Check collision between player and boundaries

            foreach (Entity boundary in boundaries)
            {
                if (boundary.Collision(player))
                {
                    player = new Entity(tempX, tempY, 14, 14, playerSpeed);
                    
                }
            }

            //TODO - Check collision between player and enemies 
            foreach (Entity mons in enemy)
            {
                if (mons.Collision(player))
                {
                    player = new Entity(140, 290, 14, 14, playerSpeed);
                    coinList[0].x = 341; coinList[0].y = 153;
                    coinList[1].x = 617; coinList[1].y = 153;
                    coinList[2].x = 480; coinList[2].y = 435;
                    coinList[3].x = 830; coinList[3].y = 293;
                    coinNumber = 0;
                    gateOpenClose = false;
                    boundaries[25].x = 725; boundaries[25].y = 275;
                    boundaries[25].sizeX = 50; boundaries[25].sizeY = 52;
                    coinList[0].speed = 0;
                    coinList[1].speed = 0;
                    coinList[2].speed = 0; 
                    coinList[3].speed = 0;
                    fails++;

                }
            }

            //TODO - Check collision between player and coins
            foreach (Entity coins in coinList)
            {
                if (coins.Collision(player))
                {
                    coins.x = 0;
                    coins.y = 0;
                    coins.speed = 1;
                    coinNumber++;
                }
            }

            //Check collision between player and win zone
            if (coinList[3].speed == 1)
            {
                foreach (Entity zone in playgroundGreen)
                {
                    if (zone.Collision(player))
                    {
                        coinList[3].speed = 0;
                        Form f = this.FindForm();
                        f.Controls.Remove(this);
                        WinScreen ws = new WinScreen();
                        f.Controls.Add(ws);
                        ws.Location = new Point((f.Width - ws.Width) / 2, (f.Height - ws.Height) / 2);
                        ws.Focus();
                    }
                }
            }

            Refresh();
        }

        private void Part1Screen_Paint(object sender, PaintEventArgs e)
        {
            //Draw the area which the player will be allowed on 
            foreach (Entity p in playgroundGreen)
            {
                if (coinList[3].speed == 1)
                {
                    e.Graphics.FillRectangle(greenBrush, p.x, p.y, p.sizeX, p.sizeY);
                }
                else
                {
                    e.Graphics.FillRectangle(whiteBrush, p.x, p.y, p.sizeX, p.sizeY);
                }
            }

            foreach (Entity w in playgroundWhite)
            {
                e.Graphics.FillRectangle(whiteBrush, w.x, w.y, w.sizeX, w.sizeY);
            }

            foreach (Entity b in playgroundGray)
            {
                if (gateOpenClose)
                {
                    e.Graphics.FillRectangle(whiteBrush, b.x, b.y, b.sizeX, b.sizeY);
                }
                else
                {
                    e.Graphics.FillRectangle(grayBrush, b.x, b.y, b.sizeX, b.sizeY);
                }
                
            }

            //Draw the coins 
            foreach (Entity c in coinList)
            {
                e.Graphics.FillEllipse(yellowBrush, c.x, c.y, c.sizeX, c.sizeY);
            }

            //Draw the enemies
            foreach (Entity m in enemy)
            {
                e.Graphics.FillEllipse(blueBrush, m.x, m.y, m.sizeX, m.sizeY);
            }


            //Draw the player (which should be a square)
            e.Graphics.FillRectangle(redBrush, player.x, player.y, player.sizeX, player.sizeY);
        }
    }
}
