using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public enum IdCheckBox { checkBox1, checkBox2, checkBox7, checkBox8 }
    public interface IQuestionsPanelView
    {
        string Text { get; set; }
        Dictionary<string, bool> Answers { get; set; }

        int Correct { get; set; }
        int Wrong { get; set; }


        event Action SaveButtonClicked;
    }
}
