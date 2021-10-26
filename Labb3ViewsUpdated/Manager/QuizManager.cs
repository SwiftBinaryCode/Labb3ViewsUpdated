using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.Model
{
    public class QuizManager
    {
        //skapa en lista som lagrar alla skapade quizes
        private List<Quiz> _quizzes = new List<Quiz>();

        //kunstruktor av quiz
        public List<Quiz> Quizzes
        {
            get => _quizzes;
            set { _quizzes = value; }

        }

    }
}
