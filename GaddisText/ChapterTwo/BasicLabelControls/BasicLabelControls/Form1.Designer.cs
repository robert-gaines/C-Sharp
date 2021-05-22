
namespace BasicLabelControls
{
    partial class Form1
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.displayAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(94, 35);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(275, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "What is the meaning of life, the universe and everything?";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerLabel.Location = new System.Drawing.Point(107, 72);
            this.answerLabel.MinimumSize = new System.Drawing.Size(250, 25);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(250, 25);
            this.answerLabel.TabIndex = 1;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayAnswer
            // 
            this.displayAnswer.Location = new System.Drawing.Point(157, 126);
            this.displayAnswer.Name = "displayAnswer";
            this.displayAnswer.Size = new System.Drawing.Size(134, 23);
            this.displayAnswer.TabIndex = 2;
            this.displayAnswer.Text = "Display The Answer";
            this.displayAnswer.UseVisualStyleBackColor = true;
            this.displayAnswer.Click += new System.EventHandler(this.displayAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 300);
            this.Controls.Add(this.displayAnswer);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "Form1";
            this.Text = "Meaning of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button displayAnswer;
    }
}

