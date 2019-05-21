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
    public partial class FormQuizSolver : Form, IView
    {
        #region Properties
        public static Questions Questions { get; set; }
        public static int ActualQuestionID { get; set; }

        public int QuestionID
        {
            get
            {
                return int.Parse(labelQuestionNumber.Text);
            }
            set
            {
                labelQuestionNumber.Text = value.ToString();
            }
        }
        public string QuestionTitle
        {
            get
            {
                return textBoxQuestion.Text;
            }
            set
            {
                textBoxQuestion.Text = value;
            }
        }
        public Dictionary<string, bool> Answers
        {
            get
            {
                Dictionary<string, bool> answers = new Dictionary<string, bool>();
                answers.Add(textBoxAnswerA.Text, checkBoxAnswerA.Checked);
                answers.Add(textBoxAnswerB.Text, checkBoxAnswerB.Checked);
                answers.Add(textBoxAnswerC.Text, checkBoxAnswerC.Checked);
                answers.Add(textBoxAnswerD.Text, checkBoxAnswerD.Checked);
                return answers;
            }
            set
            {
                List<string> answersKey = new List<string>();

                foreach(KeyValuePair<string, bool> answers in value)
                {
                    answersKey.Add(answers.Key);
                }

                textBoxAnswerA.Text = answersKey[0];
                checkBoxAnswerA.Checked = false;

                textBoxAnswerB.Text = answersKey[1];
                checkBoxAnswerB.Checked = false;

                textBoxAnswerC.Text = answersKey[2];
                checkBoxAnswerC.Checked = false;

                textBoxAnswerD.Text = answersKey[3];
                checkBoxAnswerD.Checked = false;

            }
        }
        public int PointsCorrect
        {
            get
            {
                return int.Parse(labelCorrect.Text);
            }
            set
            {
                labelCorrect.Text = value.ToString();
            }
        }
        public int PointsWrong
        {
            get
            {
                return int.Parse(labelWrong.Text);
            }
            set
            {
                labelWrong.Text = value.ToString();
            }
        }
        public int TimeLeft
        {
            get
            {
                return int.Parse(labelTime.Text);
            }
            set
            {
                labelTime.Text = value.ToString();
            }
        }

        public bool TimerActivity
        {
            get
            {
                return timerLeft.Enabled;
            }
            set
            {
                timerLeft.Enabled = value;
            }
        }
        #endregion

        #region Events
        public event Action FormLoaded;
        public event Action NextButtonClicked;
        public event Action TimeTick;
        public event Action TimeElapsed;
        #endregion

        public FormQuizSolver()
        {
            InitializeComponent();
        }

        #region Methods
        public void FullfilFields(int questionID)
        {
            Question question = Questions.QuestionsList[questionID];

            QuestionID = (question.ID) + 1; // bo ID sa od 0
            QuestionTitle = question.Text;
            Answers = question.AnswerKey; // tylko odpowiedzi, checkboxy sa na false
            PointsCorrect = question.Correct;
            PointsWrong = question.Wrong;
            TimeLeft = 90;

            TimerActivity = true;
        }
        private void FormQuizSolver_Load(object sender, EventArgs e)
        {
            FormLoaded?.Invoke();
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            TimeTick?.Invoke();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke();
        }

        private void labelTime_TextChanged(object sender, EventArgs e)
        {
            if(TimeLeft == 0)
            {
                TimeElapsed?.Invoke();
            }
        }
        public void Exit()
        {
            Close();
        }
        #endregion
    }
}
