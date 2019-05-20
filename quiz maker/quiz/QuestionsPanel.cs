using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class QuestionsPanel : UserControl, IQuestionsPanelView
    {
        #region Properties
        public string Text
        {
            get
            {
                return textBoxText.Text;
            }
            set
            {
                textBoxText.Text = value;
            }
        }
        public Dictionary<string, bool> Answers
        {   
            get
            {
                Dictionary<string, bool> answers = new Dictionary<string, bool>();
                answers.Add(textBoxAnswerA.Text, checkBoxA.Checked);
                answers.Add(textBoxAnswerB.Text, checkBoxB.Checked);
                answers.Add(textBoxAnswerC.Text, checkBoxC.Checked);
                answers.Add(textBoxAnswerD.Text, checkBoxD.Checked);
                return answers;
            }

            set
            {
                List<string> keys = new List<string>();
                List<bool> values = new List<bool>();
                foreach(KeyValuePair<string,bool> answers in value)
                {
                    keys.Add(answers.Key);
                    values.Add(answers.Value);
                }
                
                textBoxAnswerA.Text = keys[0];
                checkBoxA.Checked = values[0];

                textBoxAnswerB.Text = keys[0];
                checkBoxB.Checked = values[0];

                textBoxAnswerB.Text = keys[0];
                checkBoxB.Checked = values[0];

                textBoxAnswerB.Text = keys[0];
                checkBoxB.Checked = values[0];


            }
        }

        public int Correct
        {
            get
            {
                return (int)numericUpDownCorrect.Value;
            }

            set
            {
                numericUpDownCorrect.Value = value;
            }
        }
        public int Wrong
        {
            get
            {
                return (int)numericUpDownWrong.Value;
            }

            set
            {
                numericUpDownWrong.Value = value;
            }
        }


        #endregion

        #region Events
        public event Action SaveButtonClicked;
        #endregion
        
        public QuestionsPanel()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveButtonClicked?.Invoke();
        }

        private void numericUpDownCorrect_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownWrong_ValueChanged(object sender, EventArgs e)
        {

        }
    }


}
