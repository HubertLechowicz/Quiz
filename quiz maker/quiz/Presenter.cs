using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Presenter
    {
        IView view;
        Model model;

        QuestionsPanelPresenter QuestionsPresenter;

        public Presenter(IView view, Model model)
        {
            this.view = view;
            this.model = model;
            QuestionsPresenter = new QuestionsPanelPresenter(view.QuestionsView, model);
            this.view.FormLoaded += View_FormLoaded;
        }

        private void View_FormLoaded()
        {
            string json = File.ReadAllText(Constants.fileName);            
            Form1.questions = JsonConvert.DeserializeObject<Questions>(json);
            for (int i = 0; i < Form1.questions.questions.Count; i++)
            {
                Console.WriteLine(Form1.questions.questions[i]);
            }
        }
    }

}
