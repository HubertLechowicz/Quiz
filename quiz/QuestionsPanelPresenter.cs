using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}

