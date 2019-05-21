using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolver
{
    class Model
    {
        public void LoadQuestions()
        {
            string json = File.ReadAllText(Constants.fileName);
            FormQuizSolver.Questions = JsonConvert.DeserializeObject<Questions>(json);
            FormQuizSolver.ActualQuestionID = FormQuizSolver.Questions.QuestionsList.First().ID;
        }

        public bool LoadNextQuestion(List<bool> answers)
        {
            FormQuizSolver.Questions.QuestionsList[FormQuizSolver.ActualQuestionID].Answers = answers ;

            FormQuizSolver.ActualQuestionID++;

            if (FormQuizSolver.ActualQuestionID == FormQuizSolver.Questions.QuestionsList.Count)
            {
                return false;
            }
            return true;
        }

        public void LoadScore()
        {
            MessageBox.Show("Koniec testu!", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //FormScore formScore = new FormScore();
            //formScore.Show();
        }

    }
}
