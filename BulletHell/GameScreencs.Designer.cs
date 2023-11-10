namespace BulletHell
{
    partial class GameScreencs
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.colorBox = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.grazeLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.bombLabel = new System.Windows.Forms.Label();
            this.controlLabel = new System.Windows.Forms.Label();
            this.pointsOut = new System.Windows.Forms.Label();
            this.grazeOut = new System.Windows.Forms.Label();
            this.livesOut = new System.Windows.Forms.Label();
            this.bombsOut = new System.Windows.Forms.Label();
            this.control2Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.control3Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Purple;
            this.colorBox.Location = new System.Drawing.Point(451, 0);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(200, 570);
            this.colorBox.TabIndex = 0;
            
            // 
            // pointsLabel
            // 
            this.pointsLabel.BackColor = System.Drawing.Color.Purple;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(458, 52);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(100, 23);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "Points:";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pointsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // grazeLabel
            // 
            this.grazeLabel.BackColor = System.Drawing.Color.Purple;
            this.grazeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grazeLabel.Location = new System.Drawing.Point(458, 117);
            this.grazeLabel.Name = "grazeLabel";
            this.grazeLabel.Size = new System.Drawing.Size(100, 23);
            this.grazeLabel.TabIndex = 2;
            this.grazeLabel.Text = "Graze:";
            this.grazeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // livesLabel
            // 
            this.livesLabel.BackColor = System.Drawing.Color.Purple;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.Location = new System.Drawing.Point(458, 223);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(100, 23);
            this.livesLabel.TabIndex = 3;
            this.livesLabel.Text = "Lives:";
            this.livesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bombLabel
            // 
            this.bombLabel.BackColor = System.Drawing.Color.Purple;
            this.bombLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombLabel.Location = new System.Drawing.Point(458, 313);
            this.bombLabel.Name = "bombLabel";
            this.bombLabel.Size = new System.Drawing.Size(100, 23);
            this.bombLabel.TabIndex = 4;
            this.bombLabel.Text = "Bombs:";
            this.bombLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlLabel
            // 
            this.controlLabel.BackColor = System.Drawing.Color.Purple;
            this.controlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.Location = new System.Drawing.Point(499, 380);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(100, 23);
            this.controlLabel.TabIndex = 5;
            this.controlLabel.Text = "Controls";
            this.controlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // pointsOut
            // 
            this.pointsOut.BackColor = System.Drawing.Color.Purple;
            this.pointsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsOut.Location = new System.Drawing.Point(548, 52);
            this.pointsOut.Name = "pointsOut";
            this.pointsOut.Size = new System.Drawing.Size(99, 23);
            this.pointsOut.TabIndex = 6;
            this.pointsOut.Text = "\"\"";
            this.pointsOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grazeOut
            // 
            this.grazeOut.BackColor = System.Drawing.Color.Purple;
            this.grazeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grazeOut.Location = new System.Drawing.Point(548, 117);
            this.grazeOut.Name = "grazeOut";
            this.grazeOut.Size = new System.Drawing.Size(99, 23);
            this.grazeOut.TabIndex = 7;
            this.grazeOut.Text = "\"\"";
            this.grazeOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // livesOut
            // 
            this.livesOut.BackColor = System.Drawing.Color.Purple;
            this.livesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesOut.Location = new System.Drawing.Point(548, 223);
            this.livesOut.Name = "livesOut";
            this.livesOut.Size = new System.Drawing.Size(99, 23);
            this.livesOut.TabIndex = 8;
            this.livesOut.Text = "\"\"";
            this.livesOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bombsOut
            // 
            this.bombsOut.BackColor = System.Drawing.Color.Purple;
            this.bombsOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombsOut.Location = new System.Drawing.Point(548, 313);
            this.bombsOut.Name = "bombsOut";
            this.bombsOut.Size = new System.Drawing.Size(99, 23);
            this.bombsOut.TabIndex = 9;
            this.bombsOut.Text = "\"\"";
            this.bombsOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // control2Label
            // 
            this.control2Label.BackColor = System.Drawing.Color.Purple;
            this.control2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control2Label.Location = new System.Drawing.Point(454, 413);
            this.control2Label.Name = "control2Label";
            this.control2Label.Size = new System.Drawing.Size(193, 46);
            this.control2Label.TabIndex = 10;
            this.control2Label.Text = "Move: WASD";
            this.control2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // control3Label
            // 
            this.control3Label.BackColor = System.Drawing.Color.Purple;
            this.control3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control3Label.Location = new System.Drawing.Point(454, 459);
            this.control3Label.Name = "control3Label";
            this.control3Label.Size = new System.Drawing.Size(193, 46);
            this.control3Label.TabIndex = 13;
            this.control3Label.Text = "Focus: Shift";
            this.control3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bomb: V";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreencs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.control3Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.control2Label);
            this.Controls.Add(this.bombsOut);
            this.Controls.Add(this.livesOut);
            this.Controls.Add(this.grazeOut);
            this.Controls.Add(this.pointsOut);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.bombLabel);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.grazeLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.colorBox);
            this.DoubleBuffered = true;
            this.Name = "GameScreencs";
            this.Size = new System.Drawing.Size(650, 570);
            
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreencs_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label colorBox;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label grazeLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Label bombLabel;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Label pointsOut;
        private System.Windows.Forms.Label grazeOut;
        private System.Windows.Forms.Label livesOut;
        private System.Windows.Forms.Label bombsOut;
        private System.Windows.Forms.Label control2Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label control3Label;
        private System.Windows.Forms.Label label3;
    }
}
