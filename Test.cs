using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCQFormUI
{
    public class Test
    {
        // Class: Test
        // This is the Test engine. Middle tier "business" rules/logic
        // Knows which answer is right and doesn't care about wrong answers
        // Keeps track of the user's answers
        // Provides the user feedback while taking the Test

        // Delegates
        public delegate void AnswerEvaluatedEventHandler(object sender, EvaluationEventArgs e);
        public delegate void TestEndedEventHandler(object sender, TestEndSummaryEventArgs e);
        // Events
        public event AnswerEvaluatedEventHandler AnswerEvaluated;
        public event TestEndedEventHandler TestEnded;

        // Support variables - Encapsulated data
        ArrayList m_answers = null;
        ArrayList m_summary = null;
        private int m_numberOfQuestions = 0;
        private int m_numberOfQuestionsAnswered = 0;
        private int m_numberCorrect = 0;
        private int m_numberIncorrect = 0;
        private decimal m_successPercentage = 0.0m;


        public Test()
        {
            m_answers = new ArrayList();
            m_summary = new ArrayList();
        }

        #region Publisher To Subscriber Announcements

        protected virtual void OnEnd()
        {
            TestEndSummaryEventArgs e = new TestEndSummaryEventArgs(m_summary, GetAnalysis());
            TestEnded(this, e);
        }

        protected virtual void OnEvaluate(int questionNumber, string answer)
        {
            string userFeedBack = string.Empty;
            string summaryFeedBack = string.Empty;

            // go through the answers
            foreach(Answer a in m_answers)
            {
                // find the question, the question has the right answer
                if(questionNumber == a.QuestionNumber)
                {

                    // evalute the user provided answer
                    // with the correct answer
                    if(answer == a.CorrectAnswer)
                    {
                        m_numberCorrect++;
                        userFeedBack = $"{a.CorrectAnswer} is the correct answer";
                        summaryFeedBack = "Correct";
                    }
                    else
                    {
                        m_numberIncorrect++;
                        userFeedBack = $"{answer} is incorrect \n  {a.CorrectAnswer} is the correct answer";
                        summaryFeedBack = "Incorrect";
                    }

                    m_numberOfQuestionsAnswered++;

                    m_successPercentage = Decimal.Divide((decimal) m_numberCorrect, (decimal) m_numberOfQuestionsAnswered) * 100.00m;
                    m_successPercentage = (decimal) Math.Round(m_successPercentage);

                    SummaryItem s = new SummaryItem(a.QuestionNumber, a.CorrectAnswer, answer, summaryFeedBack);
                    m_summary.Add(s);

                    break;
                }
            }


            EvaluationEventArgs e = new EvaluationEventArgs(m_numberCorrect, m_numberIncorrect, m_successPercentage, userFeedBack);
            AnswerEvaluated(this, e);

            if(questionNumber==m_numberOfQuestions)
            {
                OnEnd();
            }
        }

        #endregion

        #region Event Subscriptions
        public void DataBase_AnswerProvided(object sender, AnswerEventArgs e)
        {
            // Method: DataBase_AnswerProvided
            // Test subscriber uses data from publisher DataBase
            // Stores the correct the answer in memory
            m_answers.Add(e.Answer);
        }

        public void DataBase_OnLoad(object sender, DatabaseLoadEventArgs e)
        {
            // Method: DataBase_OnLoad
            // Test subscriber uses data from publisher DataBase
            // Stores the total number of questions
            m_numberOfQuestions = e.NumberOfQuestions;
        }

        #endregion

        #region Supporting Subroutines
        private string GetAnalysis()
        {
            string analysis = string.Empty;

            if(m_numberCorrect==0)
            {
                analysis = "You are astonomically challenged. Stay on Earth!";
            }
            else if(m_numberCorrect > 0 && m_numberCorrect < 6)
            {
                analysis = "There's plenty of jobs to clean, prepare and restock the colony ships";
            }
            else if(m_numberCorrect>5 && m_numberCorrect < 11)
            {
                analysis = "Maybe you can qualify for one of our colonization programs. Maybe...";
            }
            else if(m_numberCorrect > 10 && m_numberCorrect < 15)
            {
                analysis = "You'll make a fine colonist";
            }
            else if(m_numberCorrect > 14 && m_numberCorrect < 20)
            {
                analysis = "We have a slot for you in starfleet academey";
            }
            else if (m_numberCorrect==20)
            {
                analysis = "Wow! Perfect Score! You must be a C# Programmer!";
            }

            return analysis;
        }

        #endregion

        #region Class Members
        public void Evaluate(int questionNumber, string answer)
        {
            // Method: Evaluate
            // Return: None
            // evaulates the user's provided against the correct answer
            OnEvaluate(questionNumber, answer);
        }

        #endregion

    }
}
