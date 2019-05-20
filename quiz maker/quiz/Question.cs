using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace quiz
{
    public class Question
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("title")]
        public string Text { get; set; }

        [JsonProperty("answers")]
        public Dictionary<string,bool> Answers { get; set; }


        [JsonProperty("correct")]
        public int Correct { get; set; }

        [JsonProperty("wrong")]
        public int Wrong { get; set; }




        public Question(int id, string text, Dictionary<string, bool> answers,int correct,int wrong)
        {
            ID = id;
            Text = text;
            Answers = answers;
            Correct = correct;
            Wrong = wrong;
        }
        public override string ToString()
        {
            string str = $"ID: {ID}\n Treść: {Text}\n";
            foreach (KeyValuePair<string, bool> answer in Answers)
            {
                str += $"Odpowiedz: {answer.Key}({answer.Value})\n";
            }
            str += $"Poprawna: {Correct}\n";
            str += $"Niepoprawna: {Wrong}\n";
            return str;
        }
    }
}
