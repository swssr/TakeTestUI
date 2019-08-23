using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Logic
{
    public class TestController
    {
        public TestContext db = new TestContext();

        public void testLoop(string Username)
        {
            var Questions = db.Questions.ToList();
            int questionAt = 0;

            List<int> choices = new List<int>();
            List<int> answers = new List<int>();



            int numQuestions = Questions.Count();
            if (questionAt < numQuestions)
            {

                do
                {
                
                    Question currentQuestion = Questions.ElementAt(questionAt);
                    Console.WriteLine($"{questionAt + 1} of {numQuestions}. {currentQuestion.Text}? \n");
                    int questionNum = 1;
                    foreach (var option in db.Options.Where(o => o.QuestionId == currentQuestion.Id))
                    {
                        Console.WriteLine($"{questionNum}. {option.Text}");
                        questionNum++;
                    }
                    Console.WriteLine($"\n Please enter your choice. between 1 and 4");
                    string choice = Console.ReadLine().Trim().Substring(0, 1);

                    Console.WriteLine("\n");
                    choices.Add(int.Parse(choice));
                    answers.Add(currentQuestion.CorrectAnswer);


                    if (choice != "")
                    {
                        Console.WriteLine($"Your choice {choice}");
                    }
                    else
                    {
                        Console.WriteLine($"You did not enter anything");
                    }

                    questionAt++;
               
            } while (questionAt < numQuestions);

            }
            else if (questionAt == numQuestions - 1)
            {
                Console.WriteLine($"Hooray {Username}! We're all done here. 😁😁");
                for (int i = 0; i < answers.Count - 1; i++)
                {
                    int _choice = choices.ElementAt(i);
                    int _answer = answers.ElementAt(i);

                    Console.WriteLine($"choice: {_choice} || answer: {_answer}");
                }
            }

        }
        public void takeTest(string _name)
        {
            string Username = _name ?? "";
            testLoop(Username);
        }
        public Question AddQuestion(string text, List<string> optStrings, int correctAnswer)
        {
            List<Option> options = new List<Option>();

            optStrings.ForEach(o => options.Add(new Option(o)));
            
            Question newQuestion = new Question(text, options, correctAnswer);

            db.Questions.Add(newQuestion);
            db.SaveChanges();

            return newQuestion;
        }
    }

}
