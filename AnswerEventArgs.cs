using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class AnswerEventArgs : EventArgs
    {
        private Answer m_answer = null;

        public AnswerEventArgs(Answer answer)
        {
            m_answer = answer;
        }

        public Answer Answer
        {
            get { return m_answer; }
        }
    }
}
