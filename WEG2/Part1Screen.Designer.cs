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
            // Part1Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.bottomBlackLabel);
            this.Controls.Add(this.topBlackLabel);
            this.DoubleBuffered = true;
            this.Name = "Part1Screen";
            this.Size = new System.Drawing.Size(1350, 900);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Part1Screen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Part1Screen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Part1Screen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topBlackLabel;
        private System.Windows.Forms.Label bottomBlackLabel;
        private System.Windows.Forms.Timer gameLoop;
    }
}
