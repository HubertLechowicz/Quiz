namespace quiz
{
    partial class QuestionsPanel
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.numericUpDownWrong = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCorrect = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxAnswerD = new System.Windows.Forms.TextBox();
            this.textBoxAnswerC = new System.Windows.Forms.TextBox();
            this.textBoxAnswerB = new System.Windows.Forms.TextBox();
            this.textBoxAnswerA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(387, 227);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 37);
            this.buttonSave.TabIndex = 32;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // numericUpDownWrong
            // 
            this.numericUpDownWrong.Location = new System.Drawing.Point(322, 91);
            this.numericUpDownWrong.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDownWrong.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownWrong.Name = "numericUpDownWrong";
            this.numericUpDownWrong.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownWrong.TabIndex = 28;
            this.numericUpDownWrong.ValueChanged += new System.EventHandler(this.numericUpDownWrong_ValueChanged);
            // 
            // numericUpDownCorrect
            // 
            this.numericUpDownCorrect.Location = new System.Drawing.Point(322, 58);
            this.numericUpDownCorrect.Name = "numericUpDownCorrect";
            this.numericUpDownCorrect.Size = new System.Drawing.Size(37, 20);
            this.numericUpDownCorrect.TabIndex = 27;
            this.numericUpDownCorrect.ValueChanged += new System.EventHandler(this.numericUpDownCorrect_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ilość pkt za niepoprawną odpowiedź: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ilość pkt za poprawną odpowiedź: ";
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(442, 196);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(34, 17);
            this.checkBoxD.TabIndex = 42;
            this.checkBoxD.Text = "D";
            this.checkBoxD.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(442, 170);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(33, 17);
            this.checkBoxC.TabIndex = 41;
            this.checkBoxC.Text = "C";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(403, 196);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(33, 17);
            this.checkBoxB.TabIndex = 40;
            this.checkBoxB.Text = "B";
            this.checkBoxB.UseVisualStyleBackColor = true;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(403, 170);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(33, 17);
            this.checkBoxA.TabIndex = 39;
            this.checkBoxA.Text = "A";
            this.checkBoxA.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(400, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Poprawna?";
            // 
            // textBoxAnswerD
            // 
            this.textBoxAnswerD.Location = new System.Drawing.Point(110, 248);
            this.textBoxAnswerD.Name = "textBoxAnswerD";
            this.textBoxAnswerD.Size = new System.Drawing.Size(223, 20);
            this.textBoxAnswerD.TabIndex = 37;
            // 
            // textBoxAnswerC
            // 
            this.textBoxAnswerC.Location = new System.Drawing.Point(110, 219);
            this.textBoxAnswerC.Name = "textBoxAnswerC";
            this.textBoxAnswerC.Size = new System.Drawing.Size(223, 20);
            this.textBoxAnswerC.TabIndex = 36;
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.Location = new System.Drawing.Point(110, 193);
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.Size = new System.Drawing.Size(223, 20);
            this.textBoxAnswerB.TabIndex = 35;
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.Location = new System.Drawing.Point(110, 167);
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.Size = new System.Drawing.Size(223, 20);
            this.textBoxAnswerA.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Odpowiedź D:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Odpowiedź C:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Odpowiedź B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Pytanie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Odpowiedź A:";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(110, 124);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(223, 20);
            this.textBoxText.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Treść pytania:";
            // 
            // QuestionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownWrong);
            this.Controls.Add(this.numericUpDownCorrect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxAnswerD);
            this.Controls.Add(this.textBoxAnswerC);
            this.Controls.Add(this.textBoxAnswerB);
            this.Controls.Add(this.textBoxAnswerA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.label10);
            this.Name = "QuestionsPanel";
            this.Size = new System.Drawing.Size(548, 332);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown numericUpDownWrong;
        private System.Windows.Forms.NumericUpDown numericUpDownCorrect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxAnswerD;
        private System.Windows.Forms.TextBox textBoxAnswerC;
        private System.Windows.Forms.TextBox textBoxAnswerB;
        private System.Windows.Forms.TextBox textBoxAnswerA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label10;
    }
}
