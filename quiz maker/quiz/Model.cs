using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    class Model
    {
        public bool SaveQuestionsToFile()
        {
            string json = JsonConvert.SerializeObject(Form1.questions);

            File.WriteAllText(Constants.fileName, json);
            if (File.ReadAllText(Constants.fileName).Equals(json))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
