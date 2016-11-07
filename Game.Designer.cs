namespace GuessingGame
{
    partial class Game
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
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.guessButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(319, 195);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(100, 26);
            this.guessTextBox.TabIndex = 0;
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(105, 195);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(184, 20);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Guess a number 1 to 10:";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(291, 369);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 20);
            this.answerLabel.TabIndex = 2;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(295, 271);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(83, 44);
            this.guessButton.TabIndex = 3;
            this.guessButton.Text = "Guess!!!";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 476);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.guessTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button guessButton;
    }
}

