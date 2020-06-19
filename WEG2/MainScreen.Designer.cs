namespace WEG2
{
    partial class MainScreen
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
            this.topBlackLabel = new System.Windows.Forms.Label();
            this.bottomBlackLabel = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playGameButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.MadebyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // topBlackLabel
            // 
            this.topBlackLabel.BackColor = System.Drawing.Color.Black;
            this.topBlackLabel.Location = new System.Drawing.Point(0, 0);
            this.topBlackLabel.Name = "topBlackLabel";
            this.topBlackLabel.Size = new System.Drawing.Size(1350, 74);
            this.topBlackLabel.TabIndex = 0;
            // 
            // bottomBlackLabel
            // 
            this.bottomBlackLabel.BackColor = System.Drawing.Color.Black;
            this.bottomBlackLabel.Location = new System.Drawing.Point(0, 824);
            this.bottomBlackLabel.Name = "bottomBlackLabel";
            this.bottomBlackLabel.Size = new System.Drawing.Size(1350, 76);
            this.bottomBlackLabel.TabIndex = 1;
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.topLabel.Location = new System.Drawing.Point(150, 234);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(73, 32);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "THE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F);
            this.label2.Location = new System.Drawing.Point(140, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1061, 93);
            this.label2.TabIndex = 3;
            this.label2.Text = "WORLD\'S EASIEST GAME ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F);
            this.label1.Location = new System.Drawing.Point(1115, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "2";
            // 
            // playGameButton
            // 
            this.playGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.playGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.ForeColor = System.Drawing.Color.Maroon;
            this.playGameButton.Location = new System.Drawing.Point(359, 428);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(143, 66);
            this.playGameButton.TabIndex = 1;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // instructionsButton
            // 
            this.instructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsButton.ForeColor = System.Drawing.Color.Maroon;
            this.instructionsButton.Location = new System.Drawing.Point(599, 527);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(143, 66);
            this.instructionsButton.TabIndex = 2;
            this.instructionsButton.Text = "Instructions";
            this.instructionsButton.UseVisualStyleBackColor = true;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameButton.ForeColor = System.Drawing.Color.Maroon;
            this.endGameButton.Location = new System.Drawing.Point(839, 428);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(143, 66);
            this.endGameButton.TabIndex = 3;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // MadebyLabel
            // 
            this.MadebyLabel.AutoSize = true;
            this.MadebyLabel.BackColor = System.Drawing.Color.Black;
            this.MadebyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MadebyLabel.ForeColor = System.Drawing.Color.White;
            this.MadebyLabel.Location = new System.Drawing.Point(18, 14);
            this.MadebyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MadebyLabel.Name = "MadebyLabel";
            this.MadebyLabel.Size = new System.Drawing.Size(390, 44);
            this.MadebyLabel.TabIndex = 15;
            this.MadebyLabel.Text = "Made by: Ohm Patel";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.MadebyLabel);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.bottomBlackLabel);
            this.Controls.Add(this.topBlackLabel);
            this.Controls.Add(this.label2);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(1350, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topBlackLabel;
        private System.Windows.Forms.Label bottomBlackLabel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Label MadebyLabel;
    }
}
