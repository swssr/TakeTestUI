using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class DatabaseLoadEventArgs
    {
        private int m_numberOfQuestions = 0;

        public DatabaseLoadEventArgs(int numberOfQuestions)
        {
            m_numberOfQuestions = numberOfQuestions;
        }

        public int NumberOfQuestions
        {
            get { return m_numberOfQuestions; }
        }
    }
}
