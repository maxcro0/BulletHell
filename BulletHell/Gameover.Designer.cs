namespace BulletHell
{
    partial class Gameover
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
            this.GameoverLabel = new System.Windows.Forms.Label();
            this.yougotLabel = new System.Windows.Forms.Label();
            this.overpointsOut = new System.Windows.Forms.Label();
            this.tryagainButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameoverLabel
            // 
            this.GameoverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameoverLabel.Location = new System.Drawing.Point(71, 22);
            this.GameoverLabel.Name = "GameoverLabel";
            this.GameoverLabel.Size = new System.Drawing.Size(525, 147);
            this.GameoverLabel.TabIndex = 0;
            this.GameoverLabel.Text = "Game Over!";
            this.GameoverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yougotLabel
            // 
            this.yougotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yougotLabel.Location = new System.Drawing.Point(169, 248);
            this.yougotLabel.Name = "yougotLabel";
            this.yougotLabel.Size = new System.Drawing.Size(294, 40);
            this.yougotLabel.TabIndex = 1;
            this.yougotLabel.Text = "You got ";
            this.yougotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overpointsOut
            // 
            this.overpointsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overpointsOut.Location = new System.Drawing.Point(169, 312);
            this.overpointsOut.Name = "overpointsOut";
            this.overpointsOut.Size = new System.Drawing.Size(294, 40);
            this.overpointsOut.TabIndex = 2;
            this.overpointsOut.Text = "You got ";
            this.overpointsOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // tryagainButton
            // 
            this.tryagainButton.Location = new System.Drawing.Point(0, 436);
            this.tryagainButton.Name = "tryagainButton";
            this.tryagainButton.Size = new System.Drawing.Size(155, 38);
            this.tryagainButton.TabIndex = 3;
            this.tryagainButton.Text = "Try Again?";
            this.tryagainButton.UseVisualStyleBackColor = true;
            this.tryagainButton.Click += new System.EventHandler(this.tryagainButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(492, 436);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 38);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(231, 436);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(155, 38);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // Gameover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tryagainButton);
            this.Controls.Add(this.overpointsOut);
            this.Controls.Add(this.yougotLabel);
            this.Controls.Add(this.GameoverLabel);
            this.Name = "Gameover";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GameoverLabel;
        private System.Windows.Forms.Label yougotLabel;
        private System.Windows.Forms.Label overpointsOut;
        private System.Windows.Forms.Button tryagainButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button menuButton;
    }
}
