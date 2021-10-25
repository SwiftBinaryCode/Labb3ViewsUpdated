using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.Model
{
    public class Quiz
    {
        public List<Question> Question { get; }
        public string Title { get; set;}

        public List<Question> Questions = new();

        public Question GetRandomQuestion()
        {



        }
        public void AddQuestion(string statement,int correctAnswer, params string[] answers)
        {


       

            
        }
        public void RemoveQuestion(int index)
        {



        }
    }
}
