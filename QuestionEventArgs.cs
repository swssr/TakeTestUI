using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class QuestionEventArgs : EventArgs
    {
        // Class: QuestionEventArgs
        // The requested data packaged and delivered to class TestForm

        private string m_Test = "Astronomy Test";
        private Question m_question = null;

        public QuestionEventArgs(Question question)
        {
            m_question = question;
        }

        public string TestName
        {
            get { return m_Test; }
        }

        public Question Question
        {
            get { return m_question; }
        }
    }
}
