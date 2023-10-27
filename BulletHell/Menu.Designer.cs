namespace BulletHell
{
    partial class Menu
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
            this.exitButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.lunaticButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(529, 517);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 27);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // easyButton
            // 
            this.easyButton.Location = new System.Drawing.Point(264, 181);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(126, 32);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            // 
            // mediumButton
            // 
            this.mediumButton.Location = new System.Drawing.Point(264, 268);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(126, 32);
            this.mediumButton.TabIndex = 2;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = true;
            // 
            // hardButton
            // 
            this.hardButton.Location = new System.Drawing.Point(264, 355);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(126, 32);
            this.hardButton.TabIndex = 3;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            // 
            // lunaticButton
            // 
            this.lunaticButton.Location = new System.Drawing.Point(264, 441);
            this.lunaticButton.Name = "lunaticButton";
            this.lunaticButton.Size = new System.Drawing.Size(126, 32);
            this.lunaticButton.TabIndex = 4;
            this.lunaticButton.Text = "Lunatic";
            this.lunaticButton.UseVisualStyleBackColor = true;
            this.lunaticButton.Click += new System.EventHandler(this.lunaticButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lunaticButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(650, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button lunaticButton;
    }
}
