
namespace StopWatch
{
    partial class StopWatch
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
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.TimerBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(55, 146);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 42);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(296, 146);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(188, 42);
            this.StopButton.TabIndex = 1;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(296, 203);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(188, 43);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(55, 203);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(191, 43);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // TimerBox
            // 
            this.TimerBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimerBox.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerBox.Location = new System.Drawing.Point(55, 45);
            this.TimerBox.Multiline = true;
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Size = new System.Drawing.Size(429, 69);
            this.TimerBox.TabIndex = 0;
            this.TimerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elapsed Time";
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimerBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "StopWatch";
            this.Text = "Stopwatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox TimerBox;
        private System.Windows.Forms.Label label1;
    }
}

