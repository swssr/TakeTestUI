using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class Answer
    {
        // Class: Answer
        // Data representing the correct answer to a question

        private int m_questionNumber = 0;
        private string m_correctAnswer = string.Empty;

        public Answer(int questionNumber, string correctAnswer)
        {
            m_questionNumber = questionNumber;
            m_correctAnswer = correctAnswer;
        }

        public int QuestionNumber
        {
            get { return m_questionNumber; }
        }

        public string CorrectAnswer
        {
            get { return m_correctAnswer; }
        }
    }
}
