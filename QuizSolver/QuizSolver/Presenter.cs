using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QuizSolver
{
    class Presenter
    {
        IView view;
        Model model;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;

            this.view.FormLoaded += View_FormLoaded;

            this.view.NextButtonClicked += View_NextButtonClicked;
            this.view.TimeElapsed += View_NextButtonClicked;
            this.view.TimeTick += View_TimeTick;
        }

        private void View_TimeTick()
        {
            view.TimeLeft--;
        }

        private void View_NextButtonClicked()
        {
            if (model.LoadNextQuestion(view.Answers.Values.ToList()))
            {
                view.FullfilFields(FormQuizSolver.ActualQuestionID);
            }
            else
            {
                model.LoadScore();
                view.Exit();
            }
        }

        private void View_FormLoaded()
        {
            model.LoadQuestions();
            view.FullfilFields(FormQuizSolver.ActualQuestionID);
        }
    }
}
