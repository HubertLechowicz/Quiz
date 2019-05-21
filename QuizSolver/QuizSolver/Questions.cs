using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSolver
{
    public class Questions
    {
        #region Properties
        [JsonProperty("questions")]
        public List<Question> QuestionsList;

        public int TotalPoints { get; set; } = 0;
        #endregion

        public Questions(List<Question> questions)
        {
            QuestionsList = questions;

            foreach(var question in questions)
            {
                TotalPoints += (question.Correct * 4);
            }
        }


        #region Methods
        public override string ToString()
        {
            string str = "";

            foreach(var el in QuestionsList)
            {
                str += el.ToString() + "\n";
            }

            return str;
        }
        #endregion
    }
}
