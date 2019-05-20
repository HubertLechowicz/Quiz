using System;
using System.Collections.Generic;
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
        }
    }

}
