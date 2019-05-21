using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace QuizSolver
{
    public class Question
    {
        #region Properties
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Text { get; set; }

        [JsonProperty("answers")]
        public Dictionary<string, bool> AnswerKey { get; set; }

        [JsonProperty("correct")]
        public int Correct { get; set; }

        [JsonProperty("wrong")]
        public int Wrong { get; set; }

        public List<bool> Answers { get; set; }
        #endregion

        public Question(int id, string text, Dictionary<string, bool> answerKey, int correct, int wrong)
        {
            ID = id;
            Text = text;
            AnswerKey = answerKey;
            Correct = correct;
            Wrong = wrong;

            List<bool> answers = new List<bool>();
            for(int i=0; i < 4; i++)
            {
                answers.Add(false);
            }
            Answers = answers;
        }

        #region Mthods
        public override string ToString()
        {
            string str = $"ID: {ID}\n Treść: {Text}\n";
            foreach (KeyValuePair<string, bool> answer in AnswerKey)
            {
                str += $"Odpowiedz: {answer.Key}({answer.Value})\n";
            }
            str += $"Poprawna: {Correct}\n";
            str += $"Niepoprawna: {Wrong}\n";
            return str;
        }
        #endregion
    }
}
