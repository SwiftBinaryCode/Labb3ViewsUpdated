using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.Model
{
    public class Question
    {

        public string Statement { get; set; }
        public int CorrectAnswer { get; set; }
        public string [] Answers { get; set; }

        

        public Question(string statement, int correctAnswer, params string[] answers)
        {
            Statement = statement;
            CorrectAnswer = correctAnswer;
            Answers = answers;
        }
        public Question()
        {

        }

    }
}
