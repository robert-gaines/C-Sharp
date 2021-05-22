
namespace DateStringApplication
{
    partial class DateStringApplication
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
            this.dayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.nameOfMonth = new System.Windows.Forms.TextBox();
            this.numericDayOfMonth = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.dayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPromptLabel = new System.Windows.Forms.Label();
            this.dayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.yearPromptLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dayOfWeekTextBox
            // 
            this.dayOfWeekTextBox.Location = new System.Drawing.Point(270, 48);
            this.dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            this.dayOfWeekTextBox.Size = new System.Drawing.Size(419, 20);
            this.dayOfWeekTextBox.TabIndex = 12;
            // 
            // nameOfMonth
            // 
            this.nameOfMonth.Location = new System.Drawing.Point(270, 130);
            this.nameOfMonth.Name = "nameOfMonth";
            this.nameOfMonth.Size = new System.Drawing.Size(419, 20);
            this.nameOfMonth.TabIndex = 1;
            // 
            // numericDayOfMonth
            // 
            this.numericDayOfMonth.Location = new System.Drawing.Point(270, 206);
            this.numericDayOfMonth.Name = "numericDayOfMonth";
            this.numericDayOfMonth.Size = new System.Drawing.Size(419, 20);
            this.numericDayOfMonth.TabIndex = 2;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(270, 287);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(419, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // dayOfWeekPromptLabel
            // 
            this.dayOfWeekPromptLabel.AutoSize = true;
            this.dayOfWeekPromptLabel.Location = new System.Drawing.Point(42, 55);
            this.dayOfWeekPromptLabel.Name = "dayOfWeekPromptLabel";
            this.dayOfWeekPromptLabel.Size = new System.Drawing.Size(129, 13);
            this.dayOfWeekPromptLabel.TabIndex = 4;
            this.dayOfWeekPromptLabel.Text = "Enter the day of the week";
            // 
            // monthPromptLabel
            // 
            this.monthPromptLabel.AutoSize = true;
            this.monthPromptLabel.Location = new System.Drawing.Point(42, 137);
            this.monthPromptLabel.Name = "monthPromptLabel";
            this.monthPromptLabel.Size = new System.Drawing.Size(141, 13);
            this.monthPromptLabel.TabIndex = 5;
            this.monthPromptLabel.Text = "Enter the name of the month";
            // 
            // dayOfMonthPromptLabel
            // 
            this.dayOfMonthPromptLabel.AutoSize = true;
            this.dayOfMonthPromptLabel.Location = new System.Drawing.Point(42, 219);
            this.dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            this.dayOfMonthPromptLabel.Size = new System.Drawing.Size(172, 13);
            this.dayOfMonthPromptLabel.TabIndex = 6;
            this.dayOfMonthPromptLabel.Text = "Enter the numeric day of the month";
            // 
            // yearPromptLabel
            // 
            this.yearPromptLabel.AutoSize = true;
            this.yearPromptLabel.Location = new System.Drawing.Point(42, 294);
            this.yearPromptLabel.Name = "yearPromptLabel";
            this.yearPromptLabel.Size = new System.Drawing.Size(73, 13);
            this.yearPromptLabel.TabIndex = 7;
            this.yearPromptLabel.Text = "Enter the year";
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.AutoSize = true;
            this.dateOutputLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dateOutputLabel.Location = new System.Drawing.Point(189, 343);
            this.dateOutputLabel.MinimumSize = new System.Drawing.Size(500, 30);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(500, 30);
            this.dateOutputLabel.TabIndex = 8;
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(270, 403);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButton.TabIndex = 9;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(449, 403);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(614, 403);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DateStringApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.yearPromptLabel);
            this.Controls.Add(this.dayOfMonthPromptLabel);
            this.Controls.Add(this.monthPromptLabel);
            this.Controls.Add(this.dayOfWeekPromptLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.numericDayOfMonth);
            this.Controls.Add(this.nameOfMonth);
            this.Controls.Add(this.dayOfWeekTextBox);
            this.Name = "DateStringApplication";
            this.Text = "DateStringApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dayOfWeekTextBox;
        private System.Windows.Forms.TextBox nameOfMonth;
        private System.Windows.Forms.TextBox numericDayOfMonth;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label dayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPromptLabel;
        private System.Windows.Forms.Label dayOfMonthPromptLabel;
        private System.Windows.Forms.Label yearPromptLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

