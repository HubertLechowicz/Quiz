using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form, IView
    {
        #region Prop
       
        public static Questions questions;

        public IQuestionsPanelView QuestionsView { get { return questions1; } }
        #endregion

        #region Events
        public event Action FormLoaded;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

            FormLoaded?.Invoke();
        }

    }
}
