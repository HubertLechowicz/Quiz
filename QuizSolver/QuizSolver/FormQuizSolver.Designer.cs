namespace QuizSolver
{
    partial class FormQuizSolver
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
            this.components = new System.ComponentModel.Container();
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswerA = new System.Windows.Forms.TextBox();
            this.textBoxAnswerB = new System.Windows.Forms.TextBox();
            this.textBoxAnswerC = new System.Windows.Forms.TextBox();
            this.textBoxAnswerD = new System.Windows.Forms.TextBox();
            this.checkBoxAnswerA = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerB = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerC = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswerD = new System.Windows.Forms.CheckBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelForTime = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCorrectText = new System.Windows.Forms.Label();
            this.labelWrongText = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumber.Location = new System.Drawing.Point(12, 9);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(25, 25);
            this.labelQuestionNumber.TabIndex = 0;
            this.labelQuestionNumber.Text = "1";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(82, 9);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(155, 25);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Treść pytania";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(244, 13);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.ReadOnly = true;
            this.textBoxQuestion.Size = new System.Drawing.Size(544, 20);
            this.textBoxQuestion.TabIndex = 2;
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.Location = new System.Drawing.Point(87, 87);
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.ReadOnly = true;
            this.textBoxAnswerA.Size = new System.Drawing.Size(701, 20);
            this.textBoxAnswerA.TabIndex = 3;
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.Location = new System.Drawing.Point(87, 113);
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.ReadOnly = true;
            this.textBoxAnswerB.Size = new System.Drawing.Size(701, 20);
            this.textBoxAnswerB.TabIndex = 4;
            // 
            // textBoxAnswerC
            // 
            this.textBoxAnswerC.Location = new System.Drawing.Point(87, 139);
            this.textBoxAnswerC.Name = "textBoxAnswerC";
            this.textBoxAnswerC.ReadOnly = true;
            this.textBoxAnswerC.Size = new System.Drawing.Size(701, 20);
            this.textBoxAnswerC.TabIndex = 5;
            // 
            // textBoxAnswerD
            // 
            this.textBoxAnswerD.Location = new System.Drawing.Point(87, 165);
            this.textBoxAnswerD.Name = "textBoxAnswerD";
            this.textBoxAnswerD.ReadOnly = true;
            this.textBoxAnswerD.Size = new System.Drawing.Size(701, 20);
            this.textBoxAnswerD.TabIndex = 6;
            // 
            // checkBoxAnswerA
            // 
            this.checkBoxAnswerA.AutoSize = true;
            this.checkBoxAnswerA.Location = new System.Drawing.Point(22, 87);
            this.checkBoxAnswerA.Name = "checkBoxAnswerA";
            this.checkBoxAnswerA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswerA.TabIndex = 7;
            this.checkBoxAnswerA.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswerB
            // 
            this.checkBoxAnswerB.AutoSize = true;
            this.checkBoxAnswerB.Location = new System.Drawing.Point(22, 113);
            this.checkBoxAnswerB.Name = "checkBoxAnswerB";
            this.checkBoxAnswerB.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswerB.TabIndex = 8;
            this.checkBoxAnswerB.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswerC
            // 
            this.checkBoxAnswerC.AutoSize = true;
            this.checkBoxAnswerC.Location = new System.Drawing.Point(22, 145);
            this.checkBoxAnswerC.Name = "checkBoxAnswerC";
            this.checkBoxAnswerC.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswerC.TabIndex = 9;
            this.checkBoxAnswerC.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswerD
            // 
            this.checkBoxAnswerD.AutoSize = true;
            this.checkBoxAnswerD.Location = new System.Drawing.Point(22, 171);
            this.checkBoxAnswerD.Name = "checkBoxAnswerD";
            this.checkBoxAnswerD.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswerD.TabIndex = 10;
            this.checkBoxAnswerD.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(607, 192);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(181, 37);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.Text = "Następne";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelForTime
            // 
            this.labelForTime.AutoSize = true;
            this.labelForTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForTime.Location = new System.Drawing.Point(492, 195);
            this.labelForTime.Name = "labelForTime";
            this.labelForTime.Size = new System.Drawing.Size(65, 25);
            this.labelForTime.TabIndex = 12;
            this.labelForTime.Text = "Czas";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(563, 195);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(38, 25);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "90";
            this.labelTime.TextChanged += new System.EventHandler(this.labelTime_TextChanged);
            // 
            // labelCorrectText
            // 
            this.labelCorrectText.AutoSize = true;
            this.labelCorrectText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectText.Location = new System.Drawing.Point(14, 197);
            this.labelCorrectText.Name = "labelCorrectText";
            this.labelCorrectText.Size = new System.Drawing.Size(156, 16);
            this.labelCorrectText.TabIndex = 14;
            this.labelCorrectText.Text = "Poprawna odpowiedź";
            // 
            // labelWrongText
            // 
            this.labelWrongText.AutoSize = true;
            this.labelWrongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrongText.Location = new System.Drawing.Point(14, 213);
            this.labelWrongText.Name = "labelWrongText";
            this.labelWrongText.Size = new System.Drawing.Size(139, 16);
            this.labelWrongText.TabIndex = 15;
            this.labelWrongText.Text = "Błędna odpowiedź";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrect.Location = new System.Drawing.Point(195, 197);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(16, 16);
            this.labelCorrect.TabIndex = 16;
            this.labelCorrect.Text = "0";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWrong.Location = new System.Drawing.Point(195, 213);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(16, 16);
            this.labelWrong.TabIndex = 17;
            this.labelWrong.Text = "0";
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 1000;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // FormQuizSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 245);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelWrongText);
            this.Controls.Add(this.labelCorrectText);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelForTime);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.checkBoxAnswerD);
            this.Controls.Add(this.checkBoxAnswerC);
            this.Controls.Add(this.checkBoxAnswerB);
            this.Controls.Add(this.checkBoxAnswerA);
            this.Controls.Add(this.textBoxAnswerD);
            this.Controls.Add(this.textBoxAnswerC);
            this.Controls.Add(this.textBoxAnswerB);
            this.Controls.Add(this.textBoxAnswerA);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.labelQuestionNumber);
            this.Name = "FormQuizSolver";
            this.Text = "Quiz Solver";
            this.Load += new System.EventHandler(this.FormQuizSolver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswerA;
        private System.Windows.Forms.TextBox textBoxAnswerB;
        private System.Windows.Forms.TextBox textBoxAnswerC;
        private System.Windows.Forms.TextBox textBoxAnswerD;
        private System.Windows.Forms.CheckBox checkBoxAnswerA;
        private System.Windows.Forms.CheckBox checkBoxAnswerB;
        private System.Windows.Forms.CheckBox checkBoxAnswerC;
        private System.Windows.Forms.CheckBox checkBoxAnswerD;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelForTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCorrectText;
        private System.Windows.Forms.Label labelWrongText;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Timer timerLeft;
    }
}

