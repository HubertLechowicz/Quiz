using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    class QuestionsPanelPresenter
    {
        IQuestionsPanelView view;
        Model model;



        public QuestionsPanelPresenter(IQuestionsPanelView view, Model model)
        {
            this.view = view;
            this.model = model;
            this.view.SaveButtonClicked += View_SaveButtonClicked; 
        }

        private void View_SaveButtonClicked()
        {
            Form1.questions.questions.Add(new Question(Form1.questions.questions.Count,view.Text,view.Answers,view.Correct,view.Wrong));
            if (model.SaveQuestionsToFile())
            {
                MessageBox.Show("Zrzut pliku na twój lokalny dysk twardy zakończony sukcesem!!!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else MessageBox.Show("Zrzut pliku na twój lokalny dysk twardy zakończony niepowodzeniem :( !!! ", "Fiasko", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}

