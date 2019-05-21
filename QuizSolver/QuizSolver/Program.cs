using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSolver
{
    static class Constants
    {
        public const string fileName = "questions.json";
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            IView view = new FormQuizSolver();

            Presenter presenter = new Presenter(view, model);
            Application.Run((Form)view);
            Application.Run(new FormScore());
        }
    }
}
