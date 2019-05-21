using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolver
{
    interface IView
    {
        #region Properties
        int QuestionID { get; set; }
        string QuestionTitle { get; set; }
        Dictionary<string, bool> Answers { get; set; }
        int PointsCorrect { get; set; }
        int PointsWrong { get; set; }
        int TimeLeft { get; set; }
        bool TimerActivity { get; set; }
        #endregion

        #region Events
        event Action FormLoaded;
        event Action NextButtonClicked;
        event Action TimeTick;
        event Action TimeElapsed;
        #endregion

        #region Methods
        void FullfilFields(int questionID);
        void Exit();
        #endregion
    }
}
