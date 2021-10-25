
using Labb3ViewsUpdated.Mvvm.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{
    public class PlayViewModel:ObservableObject
    {
        private string _statement;
        private int _playerPoint;
        private string _option1 = "";
        private string _option2 = "";
        private string _option3 = "";

        public int Count = 0;

        //Lista för att slumpa frågorna


        public List<Question> Question = new List<Question>();

        public Model.Quiz _quiz;

        private Question _currentQuestion;

        public Question CurrentQuestion
        {
            get { return _currentQuestion; }
            set { _currentQuestion = value; }
        }
        public string Title
        {
            get => _quiz.Title;
            set => _quiz.Title = value;
        }
     
        public int AmountOfQuestions
        {
            get => _quiz.Question.Count;

        }

        public string Statement
        {
            get => CurrentQuestion.Statement;
        }

        //Något sätt att kolla vilken fråga som är vald
        public string Option1
        {
            get => CurrentQuestion.Answers[0];
            
        }
        public string Option2
        {
            get => CurrentQuestion.Answers[1];
        }
        public string Option3
        {
            get => CurrentQuestion.Answers[2];
        }
        public int PlayerPoint
        {
            get => _playerPoint;

            set
            {
                SetProperty(ref _playerPoint, value);
                
            }
        }

        public PlayViewModel(Model.Quiz quiz)
        {
           
        }

        public void LoadQuestions()
        {
            

        }


        private void Start()
        {

            Count = 1;
            LoadQuestions(Count);

        }



        //Ett sätt att sätta current question

      

        //trycka på next anropa get random question
       

        //Skapa en metod som är async som kollar om svaret är korrekt och ge spelaren poäng
        private async Task PlayerAnswer(int choice)
        {
            Count++;
            await Task.Delay(100);
            if (choice == CurrentQuestion.CorrectAnswer)
            {
                PlayerPoint++;
                

            }
            if (Count == Count)
            {
               
                MessageBox.Show("Congrats you have finsihed the quiz");

            }
            else
            {

                Count++;
                LoadQuestions(Count);

            }

        }

        //Skapa en Icommand för varje fråga
        public RelayCommand Option1Command { get; set; }
        public RelayCommand Option2Command { get; set; }
        public RelayCommand Option3Command { get; set; }

        //Begin command ska starta spelet och randomisa spelet
        public RelayCommand StartCommand { get; set; }


        //Skapa en metod som intitiar en default quiz

        public PlayViewModel()
        {

        }


    }
}
