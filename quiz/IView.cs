using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    interface IView
    {
        #region Prop
        IQuestionsPanelView QuestionsView { get; }
        #endregion
    }
}
