using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.Model
{
   public class Question
    {
 
        public string QuizQuestion { get; }
        public int CorrectQuizAnswer { get; }
        public string Option1 { get; }
        public string Option2 { get; }
        public string Option3 { get; }

        public Question(string quizQuestion, int correctQuizAnswer, string option1, string option2, string option3)
        {
            QuizQuestion = quizQuestion;
            CorrectQuizAnswer = correctQuizAnswer;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
        }

    }
}
