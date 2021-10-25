
using Labb3ViewsUpdated.Mvvm.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{
    class CreateViewModel:ObservableObject
    {
        private string _quizQuestion;
        private int _playerPoint;
        private string _option1 = "";
        private string _option2 = "";
        private string _option3 = "";
        private int _amountOfQuestions;
        public int Count = 0;

        //Hämta titel från quiz klassen 
        private readonly Quiz _quiz;


        public List<Question> Questions { get; }

        public string Title
        {
            get => _quiz.Title;
            set => _quiz.Title = value;
        }



        public int AmountOfQuestions
        {
            get => _amountOfQuestions;
            set
            {
                _amountOfQuestions = value;
                OnPropertyChanged(nameof(AmountOfQuestions));
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
        public string Option1
        {
            get => _option1;
            set
            {
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


        //Skapa en metod som bindas till en button som sparar frågorna och svaren till listan av frågor

        //Skapa en asyn metod för att kolla att frågorna som skapats inte är ett svar och visevarsa

    }
}
