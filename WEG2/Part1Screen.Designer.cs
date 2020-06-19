namespace WEG2
{
    partial class Part1Screen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topBlackLabel = new System.Windows.Forms.Label();
            this.bottomBlackLabel = new System.Windows.Forms.Label();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.pauseBackGround = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.levelLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.coinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topBlackLabel
            // 
            this.topBlackLabel.BackColor = System.Drawing.Color.Black;
            this.topBlackLabel.Location = new System.Drawing.Point(0, 0);
            this.topBlackLabel.Name = "topBlackLabel";
            this.topBlackLabel.Size = new System.Drawing.Size(1350, 74);
            this.topBlackLabel.TabIndex = 1;
            // 
            // bottomBlackLabel
            // 
            this.bottomBlackLabel.BackColor = System.Drawing.Color.Black;
            this.bottomBlackLabel.Location = new System.Drawing.Point(0, 824);
            this.bottomBlackLabel.Name = "bottomBlackLabel";
            this.bottomBlackLabel.Size = new System.Drawing.Size(1350, 76);
            this.bottomBlackLabel.TabIndex = 2;
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 20;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // pauseBackGround
            // 
            this.pauseBackGround.BackColor = System.Drawing.Color.Black;
            this.pauseBackGround.Location = new System.Drawing.Point(537, 302);
            this.pauseBackGround.Name = "pauseBackGround";
            this.pauseBackGround.Size = new System.Drawing.Size(277, 296);
            this.pauseBackGround.TabIndex = 5;
            this.pauseBackGround.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.continueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.ForeColor = System.Drawing.Color.Maroon;
            this.continueButton.Location = new System.Drawing.Point(606, 343);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(143, 66);
            this.continueButton.TabIndex = 6;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Visible = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Maroon;
            this.exitButton.Location = new System.Drawing.Point(604, 481);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(143, 66);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Main Menu";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Black;
            this.levelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.White;
            this.levelLabel.Location = new System.Drawing.Point(18, 14);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(165, 44);
            this.levelLabel.TabIndex = 21;
            this.levelLabel.Text = "Level: 1";
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.BackColor = System.Drawing.Color.Black;
            this.failLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failLabel.ForeColor = System.Drawing.Color.White;
            this.failLabel.Location = new System.Drawing.Point(1128, 14);
            this.failLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(175, 44);
            this.failLabel.TabIndex = 22;
            this.failLabel.Text = "FAILS: 0";
            // 
            // coinLabel
            // 
            this.coinLabel.AutoSize = true;
            this.coinLabel.BackColor = System.Drawing.Color.Black;
            this.coinLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinLabel.ForeColor = System.Drawing.Color.White;
            this.coinLabel.Location = new System.Drawing.Point(564, 14);
            this.coinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coinLabel.Name = "coinLabel";
            this.coinLabel.Size = new System.Drawing.Size(223, 44);
            this.coinLabel.TabIndex = 23;
            this.coinLabel.Text = "COINS: 0/4";
            // 
            // Part1Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.coinLabel);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.pauseBackGround);
            this.Controls.Add(this.bottomBlackLabel);
            this.Controls.Add(this.topBlackLabel);
            this.DoubleBuffered = true;
            this.Name = "Part1Screen";
            this.Size = new System.Drawing.Size(1350, 900);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Part1Screen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Part1Screen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Part1Screen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topBlackLabel;
        private System.Windows.Forms.Label bottomBlackLabel;
        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label pauseBackGround;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label coinLabel;
    }
}
