using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolver
{
    public partial class FormScore : Form
    {
        #region Properties
        public int Score
        {
            get
            {
                return int.Parse(labelScore.Text);
            }
            set
            {
                labelScore.Text = value.ToString();
            }
        }
        public int MaxScore
        {
            get
            {
                return int.Parse(labelMaxScore.Text);
            }
            set
            {
                labelMaxScore.Text = value.ToString();
            }
        }
        #endregion

        public FormScore()
        {
            InitializeComponent();
        }

        private void FormScore_Load(object sender, EventArgs e)
        {
            foreach(var question in FormQuizSolver.Questions.QuestionsList)
            {
                for(int i = 0; i < 4; i++)
                {
                    if(question.AnswerKey.Values.ToList()[i] == question.Answers[i]) { Score += question.Correct; }
                    else{ Score += question.Wrong; }
                }
            }
            
            MaxScore = FormQuizSolver.Questions.TotalPoints;
        }
    }
}
