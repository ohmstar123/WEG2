namespace WEG2
{
    partial class WinScreen
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
            this.bottomBlackLabel = new System.Windows.Forms.Label();
            this.topBlackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playGameButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bottomBlackLabel
            // 
            this.bottomBlackLabel.BackColor = System.Drawing.Color.Black;
            this.bottomBlackLabel.Location = new System.Drawing.Point(0, 824);
            this.bottomBlackLabel.Name = "bottomBlackLabel";
            this.bottomBlackLabel.Size = new System.Drawing.Size(1350, 76);
            this.bottomBlackLabel.TabIndex = 3;
            // 
            // topBlackLabel
            // 
            this.topBlackLabel.BackColor = System.Drawing.Color.Black;
            this.topBlackLabel.Location = new System.Drawing.Point(0, 0);
            this.topBlackLabel.Name = "topBlackLabel";
            this.topBlackLabel.Size = new System.Drawing.Size(1350, 74);
            this.topBlackLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 40F);
            this.label2.Location = new System.Drawing.Point(478, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 93);
            this.label2.TabIndex = 5;
            this.label2.Text = "YOU WIN";
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
            this.playGameButton.Text = "Play Again";
            this.playGameButton.UseVisualStyleBackColor = true;
            this.playGameButton.Click += new System.EventHandler(this.playGameButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameButton.ForeColor = System.Drawing.Color.Maroon;
            this.endGameButton.Location = new System.Drawing.Point(839, 428);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(143, 66);
            this.endGameButton.TabIndex = 2;
            this.endGameButton.Text = "Main Menu";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // WinScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.playGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topBlackLabel);
            this.Controls.Add(this.bottomBlackLabel);
            this.Name = "WinScreen";
            this.Size = new System.Drawing.Size(1350, 900);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bottomBlackLabel;
        private System.Windows.Forms.Label topBlackLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Button endGameButton;
    }
}
