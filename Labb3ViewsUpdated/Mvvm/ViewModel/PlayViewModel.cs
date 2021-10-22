using Labb3ViewsUpdated.Core;
using Labb3ViewsUpdated.Mvvm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{
    class PlayViewModel:ObservableObject
    { 
        private string _quizQuestion;
        private int _playerPoint;
        private string _option1 = "";
        private string _option2 = "";
        private string _option3 = "";

        private Model.Quiz _quiz;
        public List<Question> Question { get; }

        public string Title
        {
            get => _quiz.Title;
            set => _quiz.Title = value;
        }
        public string Option1
        {
            get => _option1;
            set {
                _option1 = value;
                OnPropertyChanged(nameof(Option1));
            }
        }
        public string Option2
        {
            get => _option2;
            set
            {
                _option2 = value;
                OnPropertyChanged(nameof(Option2));
            }
        }
        public string Option3
        {
            get => _option3;
           set
            {
                _option3 = value;
                OnPropertyChanged(nameof(Option3));
            }
        }
        public int PlayerPoint
        {
            get => _playerPoint;

            set
            {
                _playerPoint = value;
                OnPropertyChanged(nameof(PlayerPoint));
            }
        }

        public string QuizQuestion
        {
            get => _quizQuestion;
            set
            {
                _quizQuestion = value;
                OnPropertyChanged(nameof(QuizQuestion));
            }
        }

        //Skapa en tom konstruktor

        //Skapa en Icommand för varje fråga och en för att starta programmet
        
        //Skapa en metod som är async som kollar om svaret är korrekt och ge spelaren poäng

        //Skapa en metod som visar frågorna 

        //Skapa en metod som startar spelet och anropar showquestion metoden.

    }
}
