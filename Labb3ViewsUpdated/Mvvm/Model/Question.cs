using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.Model
{
   public class Question
    {

        public string _quizQuestion { get; }
        public int CorrectQuizAnswer { get; }
        public string _option1 { get; }
        public string _option2 { get; }
        public string _option3 { get; }

        public Question(string quizQuestion, int correctQuizAnswer, string option1, string option2, string option3)
        {
            _quizQuestion = quizQuestion;
            CorrectQuizAnswer = correctQuizAnswer;
            _option1 = option1;
            _option2 = option2;
            _option3 = option3;
        }

    }
}
