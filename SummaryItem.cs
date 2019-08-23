using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class SummaryItem
    {
        private int m_questionNumber = 0;
        private string m_correctAnswer = string.Empty;
        private string m_submittedAnswer = string.Empty;
        private string m_feedBack = string.Empty;

        public SummaryItem(int questionNumber, string correctAnswer, string submittedAnswer, string feedBack)
        {
            m_questionNumber = questionNumber;
            m_correctAnswer = correctAnswer;
            m_submittedAnswer = submittedAnswer;
            m_feedBack = feedBack;
        }

        public int QuestionNumber
        {
            get { return m_questionNumber; }
        }

        public string CorrectAnswer
        {
            get { return m_correctAnswer; }
        }

        public string SubmittedAnswer
        {
            get { return m_submittedAnswer; }
        }

        public string Feedback
        {
            get { return m_feedBack; }
        }
    }
}
