using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MCQFormUI
{
    public class DataBase
    {
        // Pretend this is SQL Server - Back End
        // The only role this class plays, is to provide data
        // In a real application development this class
        // would serve as a middle tier data layer
        // but for now, we are combining the middle tier with
        // the back end database for academic purposes.

        // encapsulated data
        private DataTable m_questions = null;
        private DataTable m_answers = null;
        // Delegates
        public delegate void OnLoadEventHandler(object sender, DatabaseLoadEventArgs e);
        public delegate void QuestionAcquiredEventHandler(object sender, QuestionEventArgs e);
        public delegate void AnswerProvidedEventHandler(object sender, AnswerEventArgs e);
        // Events
        public event OnLoadEventHandler DatabaseLoaded;
        public event QuestionAcquiredEventHandler QuestionAcquired;
        public event AnswerProvidedEventHandler AnswerProvided;

        public DataBase()
        {
            BuildQuestionTable();
            BuildAnswerTable();
        }

        #region Publisher to Subscriber Announcements
        protected virtual void OnLoad()
        {
            int questionCount = m_questions.Rows.Count;
            DatabaseLoadEventArgs e = new DatabaseLoadEventArgs(questionCount);
            DatabaseLoaded(this, e);
        }

        protected virtual void OnQuestionAcquired(int questionNumber)
        {
            // Method: OnQuestionAcquired
            // Return: None
            // Announces to it subscribers that it just pulled the question.
            // The the question is available for use

            // Support vaiables
            string question = string.Empty;
            string answerA = string.Empty;
            string answerB = string.Empty;
            string answerC = string.Empty;
            string answerD = string.Empty;

            // Pulling the question
            foreach(DataRow dr in m_questions.Rows)
            {
                if(questionNumber == (int) dr["QuestionID"])
                {
                    question = dr["Question"].ToString();
                    break;
                }
            }

            foreach(DataRow dr in m_answers.Rows)
            {
                if(questionNumber == (int) dr["QuestionID"])
                {
                    string answerText = dr["AnswerText"].ToString();

                    switch(dr["Answer"].ToString())
                    {
                        case "A":
                            answerA = answerText;
                            break;
                        case "B":
                            answerB = answerText;
                            break;
                        case "C":
                            answerC = answerText;
                            break;
                        case "D":
                            answerD = answerText;
                            break;
                    }
                }
            }

            Question q = new Question(questionNumber, question, answerA, answerB, answerC, answerD);
            QuestionEventArgs e = new QuestionEventArgs(q);
            QuestionAcquired(this, e);
        }

        protected virtual void OnAnswerProvided(int questionNumber)
        {
            // Method: OnAnswerProvided
            // Return: None
            // Announces to it subscribers that it just pulled the correct answer
            // The the correct answer is available for use.

            string correctAnswer = string.Empty;

            // Pulling the correct answer
            foreach (DataRow dr in m_questions.Rows)
            {
                if (questionNumber == (int)dr["QuestionID"])
                {
                    correctAnswer = dr["Correct"].ToString();
                    break;
                }
            }

            Answer answer = new Answer(questionNumber, correctAnswer);
            AnswerEventArgs e = new AnswerEventArgs(answer);
            AnswerProvided(this, e);
        }

        #endregion

        #region Supporting Subroutines
        private void BuildQuestionTable()
        {
            // Table of 20 Questions
            m_questions = new DataTable("Questions");
            // Columns
            m_questions.Columns.Add("QuestionID", typeof(int));
            m_questions.Columns.Add("Question", typeof(string));
            m_questions.Columns.Add("Correct", typeof(string));
            // Rows
            m_questions.Rows.Add(1, "What name have human being given the Sun?", "C");
            m_questions.Rows.Add(2, "The what kind of system is the sun?", "B");
            m_questions.Rows.Add(3, "How many planets orbit the sun?", "B");
            m_questions.Rows.Add(4, "What are the terrestrial planets?", "A");
            m_questions.Rows.Add(5, "Mercury, Venus, Earth and Mars are terrestrial planets. What kind of planets are Jupiter, Saturn, Uranus and Neptune called?", "C");
            m_questions.Rows.Add(6, "Why is Pluto not considered a member planet?", "D");
            m_questions.Rows.Add(7, "Jupiter and Saturn are referred to as Gas Giants. What are Uranus and Neptune referred to as?", "D");
            m_questions.Rows.Add(8, "The earth is 93 million miles (or 149,597,870.7 km) from the sun. We call that distance what?", "B");
            m_questions.Rows.Add(9, "What is the moon’s real name?", "A");
            m_questions.Rows.Add(10, "A composition of billions of solar systems is called?", "D");
            m_questions.Rows.Add(11, "Between what two planets is the asteroid belt located?", "B");
            m_questions.Rows.Add(12, "Jupiter has 69 moons. The largest 4 of 69 are called?", "D");
            m_questions.Rows.Add(13, "What are names of the Galilean Moons?", "C");
            m_questions.Rows.Add(14, "Ceres is located between Mars and Jupiter. What is Ceres classified as?", "C");
            m_questions.Rows.Add(15, "Where is the minor planet called Sedna located?", "A");
            m_questions.Rows.Add(16, "Sedna’s closest orbit distance to the sun may be at 75 astronomical units is called what?", "D");
            m_questions.Rows.Add(17, "Sedna’s further orbit distance from the sun may be at 937 astronomical units is called what?", "A");
            m_questions.Rows.Add(18, "Astronomers estimated that it takes Sedna how long to complete an entire orbit around the sun?", "B");
            m_questions.Rows.Add(19, "What is a nebula made of?", "C");
            m_questions.Rows.Add(20, "How close is the nearest discovered black hole to earth? 27000 light years?", "D");
        }

        private void BuildAnswerTable()
        {
            // Table of 80 possible answers -- 4 answers per question
            m_answers = new DataTable("Answers");
            // Columns
            m_answers.Columns.Add("AnswerID", typeof(string));
            m_answers.Columns.Add("QuestionID", typeof(int));
            m_answers.Columns.Add("Answer", typeof(string));
            m_answers.Columns.Add("AnswerText", typeof(string));
            // Rows - Question: 1
            m_answers.Rows.Add("1A", 1, "A", "Helios");
            m_answers.Rows.Add("1B", 1, "B", "Sol");
            m_answers.Rows.Add("1C", 1, "C", "The International Astronomical Union has yet to name our sun");
            m_answers.Rows.Add("1D", 1, "D", "Solis");
            // Question: 2
            m_answers.Rows.Add("2A", 2, "A", "An Orbital System");
            m_answers.Rows.Add("2B", 2, "B", "A Solar System");
            m_answers.Rows.Add("2C", 2, "C", "An Astro Circular System");
            m_answers.Rows.Add("2D", 2, "D", "A Gravitational Center Point System");
            // Question: 3
            m_answers.Rows.Add("3A", 3, "A", "7");
            m_answers.Rows.Add("3B", 3, "B", "8");
            m_answers.Rows.Add("3C", 3, "C", "9");
            m_answers.Rows.Add("3D", 3, "D", "10");
            // Question: 4
            m_answers.Rows.Add("4A", 4, "A", "Mercury, Venus, Earth, Mars");
            m_answers.Rows.Add("4B", 4, "B", "Mercury, Earth, Mars, Pluto");
            m_answers.Rows.Add("4C", 4, "C", "Earth, Mars, Ceres, Pluto");
            m_answers.Rows.Add("4D", 4, "D", "Earth, Mars and the Astroid Belt");
            // Question: 5
            m_answers.Rows.Add("5A", 5, "A", "Extra Terrestrial Planets");
            m_answers.Rows.Add("5B", 5, "B", "Gas Giant Planets");
            m_answers.Rows.Add("5C", 5, "C", "Jovian Planets");
            m_answers.Rows.Add("5D", 5, "D", "Hydrogen Planets");
            // Question: 6
            m_answers.Rows.Add("6A", 6, "A", "Pluto is an asteroid in the Kuiper Belt");
            m_answers.Rows.Add("6B", 6, "B", "Pluto is too far away to determine an orbit around the sun");
            m_answers.Rows.Add("6C", 6, "C", "Charon is the planet and Pluto is the moon.");
            m_answers.Rows.Add("6D", 6, "D", "Pluto is a member of the Kuiper Belt and is a dwarf/minor planet");
            // Question: 7
            m_answers.Rows.Add("7A", 7, "A", "Uranus and Neptune are also Gas Giants");
            m_answers.Rows.Add("7B", 7, "B", "Burned out Suns");
            m_answers.Rows.Add("7C", 7, "C", "Ionized Gas Giants");
            m_answers.Rows.Add("7D", 7, "D", "Ice Giants");
            // Question: 8
            m_answers.Rows.Add("8A", 8, "A", "Solar Distance Unit");
            m_answers.Rows.Add("8B", 8, "B", "Astronomical Unit");
            m_answers.Rows.Add("8C", 8, "C", "Earth Unit");
            m_answers.Rows.Add("8D", 8, "D", "Sol-Terra Unit of Measure");
            // Question: 9
            m_answers.Rows.Add("9A", 9, "A", "Moon");
            m_answers.Rows.Add("9B", 9, "B", "The Big-Cheese");
            m_answers.Rows.Add("9C", 9, "C", "Luna");
            m_answers.Rows.Add("9D", 9, "D", "Lua");
            // Question: 10
            m_answers.Rows.Add("10A", 10, "A", "Solar System Array");
            m_answers.Rows.Add("10B", 10, "B", "Universe");
            m_answers.Rows.Add("10C", 10, "C", "Galactic Body");
            m_answers.Rows.Add("10D", 10, "D", "Galaxy");
            // Questions: 11
            m_answers.Rows.Add("11A", 11, "A", "Mars and Ceres");
            m_answers.Rows.Add("11B", 11, "B", "Mars and Jupiter");
            m_answers.Rows.Add("11C", 11, "C", "Earth and Jupiter");
            m_answers.Rows.Add("11D", 11, "D", "Venus and Earth");
            // Questions: 12
            m_answers.Rows.Add("12A", 12, "A", "Big Moon Pies");
            m_answers.Rows.Add("12B", 12, "B", "Newtonian Moons");
            m_answers.Rows.Add("12C", 12, "C", "Einsteinium Moons");
            m_answers.Rows.Add("12D", 12, "D", "Galilean Moons");
            // Questions: 13
            m_answers.Rows.Add("13A", 13, "A", "Almathea, Carpo, Callisto, Leda");
            m_answers.Rows.Add("13B", 13, "B", "Adrastea, Io, Themisto, Himalia");
            m_answers.Rows.Add("13C", 13, "C", "Io, Europa, Ganymede and Callisto");
            m_answers.Rows.Add("13D", 13, "D", "Ganymede, Thebe, Lysithea, Elara");
            // Question: 14
            m_answers.Rows.Add("14A", 14, "A", "Ceres is an asteroid");
            m_answers.Rows.Add("14B", 14, "B", "Ceres is a moon");
            m_answers.Rows.Add("14C", 14, "C", "Ceres is a dwarf/minor planet");
            m_answers.Rows.Add("14D", 14, "D", "Ceres is a comet");
            // Questions: 15
            m_answers.Rows.Add("15A", 15, "A", "Sedna is located in the outer reaches of our solar system");
            m_answers.Rows.Add("15B", 15, "B", "Sedna has an eccentric orbit around Pluto");
            m_answers.Rows.Add("15C", 15, "C", "Sedna is dwarf/minor planet located in the Kuiper Belt");
            m_answers.Rows.Add("15D", 15, "D", "Sedna is located in the asteroid belt");
            // Question: 16
            m_answers.Rows.Add("16A", 16, "A", "Aphelion");
            m_answers.Rows.Add("16B", 16, "B", "Sedhelion");
            m_answers.Rows.Add("16C", 16, "C", "Kupierlion");
            m_answers.Rows.Add("16D", 16, "D", "Perihelion");
            // Question: 17
            m_answers.Rows.Add("17A", 17, "A", "Aphelion");
            m_answers.Rows.Add("17B", 17, "B", "Thetalion");
            m_answers.Rows.Add("17C", 17, "C", "Eplipilion");
            m_answers.Rows.Add("17D", 17, "D", "Perihelion");
            // Question: 18
            m_answers.Rows.Add("18A", 18, "A", "536 years");
            m_answers.Rows.Add("18B", 18, "B", "11,400 years");
            m_answers.Rows.Add("18C", 18, "C", "19 years");
            m_answers.Rows.Add("18D", 18, "D", "3 months");
            // Questions: 19
            m_answers.Rows.Add("19A", 19, "A", "Rocks, debris and space dirt");
            m_answers.Rows.Add("19B", 19, "B", "Celestial decay");
            m_answers.Rows.Add("19C", 19, "C", "Dust, hydrogen, helium and other ionized gases");
            m_answers.Rows.Add("19D", 19, "D", "Nebula has no composition. A nebula is a refraction of light across space");
            // Question: 20
            m_answers.Rows.Add("20A", 20, "A", "Not far away enough!");
            m_answers.Rows.Add("20B", 20, "B", "The distance can't be determined due to the strong gravitational pull");
            m_answers.Rows.Add("20C", 20, "C", "153,000 light years");
            m_answers.Rows.Add("20D", 20, "D", "27,000 light years");
        }

        #endregion

        #region Class Members
        public void GetQuestion(int questionNumber)
        {
            // provide announcements to subscribers that
            // data has been pulled and is available

            OnQuestionAcquired(questionNumber);
            OnAnswerProvided(questionNumber);
        }

        public void QueryDatabase()
        {
            OnLoad();
        }

        #endregion
    }
}
