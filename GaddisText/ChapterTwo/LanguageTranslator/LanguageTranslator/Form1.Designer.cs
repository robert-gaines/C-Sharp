
namespace LanguageTranslator
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
            this.translateItalian = new System.Windows.Forms.Button();
            this.translateSpanish = new System.Windows.Forms.Button();
            this.translateGerman = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // translateItalian
            // 
            this.translateItalian.Location = new System.Drawing.Point(119, 164);
            this.translateItalian.Name = "translateItalian";
            this.translateItalian.Size = new System.Drawing.Size(75, 23);
            this.translateItalian.TabIndex = 0;
            this.translateItalian.Text = "Italian";
            this.translateItalian.UseVisualStyleBackColor = true;
            this.translateItalian.Click += new System.EventHandler(this.translateItalian_Click);
            // 
            // translateSpanish
            // 
            this.translateSpanish.Location = new System.Drawing.Point(321, 164);
            this.translateSpanish.Name = "translateSpanish";
            this.translateSpanish.Size = new System.Drawing.Size(75, 23);
            this.translateSpanish.TabIndex = 1;
            this.translateSpanish.Text = "Spanish";
            this.translateSpanish.UseVisualStyleBackColor = true;
            this.translateSpanish.Click += new System.EventHandler(this.translateSpanish_Click);
            // 
            // translateGerman
            // 
            this.translateGerman.Location = new System.Drawing.Point(506, 164);
            this.translateGerman.Name = "translateGerman";
            this.translateGerman.Size = new System.Drawing.Size(75, 23);
            this.translateGerman.TabIndex = 2;
            this.translateGerman.Text = "German";
            this.translateGerman.UseVisualStyleBackColor = true;
            this.translateGerman.Click += new System.EventHandler(this.translateGerman_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(251, 28);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(240, 13);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Click a button to translate \'good morning\'";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(241, 65);
            this.resultLabel.MinimumSize = new System.Drawing.Size(250, 35);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(250, 35);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 291);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.translateGerman);
            this.Controls.Add(this.translateSpanish);
            this.Controls.Add(this.translateItalian);
            this.Name = "Form1";
            this.Text = "LanguageTranslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button translateItalian;
        private System.Windows.Forms.Button translateSpanish;
        private System.Windows.Forms.Button translateGerman;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

