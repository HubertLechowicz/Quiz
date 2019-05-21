namespace QuizSolver
{
    partial class FormScore
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
            this.labelScoreText = new System.Windows.Forms.Label();
            this.labelMaxScoreText = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelMaxScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelScoreText
            // 
            this.labelScoreText.AutoSize = true;
            this.labelScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreText.Location = new System.Drawing.Point(13, 13);
            this.labelScoreText.Name = "labelScoreText";
            this.labelScoreText.Size = new System.Drawing.Size(269, 25);
            this.labelScoreText.TabIndex = 0;
            this.labelScoreText.Text = "Ilość zdobytych punktów";
            // 
            // labelMaxScoreText
            // 
            this.labelMaxScoreText.AutoSize = true;
            this.labelMaxScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxScoreText.Location = new System.Drawing.Point(13, 63);
            this.labelMaxScoreText.Name = "labelMaxScoreText";
            this.labelMaxScoreText.Size = new System.Drawing.Size(293, 25);
            this.labelMaxScoreText.TabIndex = 2;
            this.labelMaxScoreText.Text = "Maksymalna ilość punktów";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(367, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelScore.Size = new System.Drawing.Size(25, 25);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMaxScore
            // 
            this.labelMaxScore.AutoSize = true;
            this.labelMaxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxScore.Location = new System.Drawing.Point(367, 63);
            this.labelMaxScore.Name = "labelMaxScore";
            this.labelMaxScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMaxScore.Size = new System.Drawing.Size(25, 25);
            this.labelMaxScore.TabIndex = 5;
            this.labelMaxScore.Text = "0";
            this.labelMaxScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 96);
            this.Controls.Add(this.labelMaxScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelMaxScoreText);
            this.Controls.Add(this.labelScoreText);
            this.Name = "FormScore";
            this.Text = "Wynik końcowy";
            this.Load += new System.EventHandler(this.FormScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScoreText;
        private System.Windows.Forms.Label labelMaxScoreText;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelMaxScore;
    }
}