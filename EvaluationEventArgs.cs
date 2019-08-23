using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class EvaluationEventArgs : EventArgs
    {
        private int m_correctlyAnswered = 0;
        private int m_incorrectlyAnswered = 0;
        private decimal m_successPercentage = 0.0m;
        private string m_feedBack = string.Empty;

        public EvaluationEventArgs(int correctlyAnswered, int incorrectlyAnswered, decimal successPercentage, string feedBack)
        {
            m_correctlyAnswered = correctlyAnswered;
            m_incorrectlyAnswered = incorrectlyAnswered;
            m_successPercentage = successPercentage;
            m_feedBack = feedBack;
        }

        public int CorrectlyAnswered
        {
            get { return m_correctlyAnswered; }
        }

        public int IncorrectlyAnswered
        {
            get { return m_incorrectlyAnswered; }
        }

        public decimal SuccessPercentage
        {
            get { return m_successPercentage; }
        }

        public string Feedback
        {
            get { return m_feedBack; }
        }
    }
}
