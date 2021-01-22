namespace NumbersGame
{
    partial class MainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.namesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.headerLabel.Location = new System.Drawing.Point(213, 26);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(149, 29);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Hall of Fame";
            // 
            // namesLabel
            // 
            this.namesLabel.AutoSize = true;
            this.namesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.namesLabel.Location = new System.Drawing.Point(41, 87);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(60, 24);
            this.namesLabel.TabIndex = 1;
            this.namesLabel.Text = "label2";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.scoreLabel.Location = new System.Drawing.Point(481, 87);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(60, 24);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "label3";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameTextBox.Location = new System.Drawing.Point(353, 298);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(188, 32);
            this.nameTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameLabel.Location = new System.Drawing.Point(40, 304);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(71, 26);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name";
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endButton.Location = new System.Drawing.Point(12, 395);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(560, 43);
            this.endButton.TabIndex = 5;
            this.endButton.Text = "END";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startButton.Location = new System.Drawing.Point(12, 346);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(560, 43);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "MainMenu";
            this.Text = "Number Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button startButton;
    }
}

