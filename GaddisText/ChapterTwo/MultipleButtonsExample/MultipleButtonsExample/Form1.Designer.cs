
namespace MultipleButtonsExample
{
    partial class MultipleButtonsExample
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
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(122, 45);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(123, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "FirstButton";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(288, 45);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(119, 23);
            this.SecondButton.TabIndex = 1;
            this.SecondButton.Text = "SecondButton";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(451, 45);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(126, 23);
            this.ThirdButton.TabIndex = 2;
            this.ThirdButton.Text = "ThirdButton";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // MultipleButtonsExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 104);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Name = "MultipleButtonsExample";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Button ThirdButton;
    }
}

