using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class Question
    {
        // Class: Question
        // Data repesenting a Test question

        private int m_questionNumber = 0;
        private string m_questionText = string.Empty;
        private string m_answerA = string.Empty;
        private string m_answerB = string.Empty;
        private string m_answerC = string.Empty;
        private string m_answerD = string.Empty;

        public Question(int questionNumber, string questionText, string answerA, string answerB, string answerC, string answerD)
        {
            m_questionNumber = questionNumber;
            m_questionText = questionText;
            m_answerA = answerA;
            m_answerB = answerB;
            m_answerC = answerC;
            m_answerD = answerD;
        }

        public int QuestionNumber
        {
            get { return m_questionNumber; }
        }

        public string QuestionText
        {
            get { return m_questionText; }
        }

        public string AnswerTextA
        {
            get { return m_answerA; }
        }

        public string AnswerTextB
        {
            get { return m_answerB; }
        }

        public string AnswerTextC
        {
            get { return m_answerC; }
        }

        public string AnswerTextD
        {
            get { return m_answerD; }
        }
    }
}
