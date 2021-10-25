
using Labb3ViewsUpdated.Mvvm.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.IO;
using System.Linq;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{

    class MainViewModel : ObservableObject
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new HomeViewModel();
        }

    }
       









































        private QuizManager quizManager
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand PlayViewCommand { get; set; }
        public RelayCommand EditViewCommand { get; set; }
        public RelayCommand CreateViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public PlayViewModel PlayVM { get; set; }
        public EditViewModel EditVM { get; set; }
        public CreateViewModel CreateVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                
                _currentView = value;
                OnPropertyChanged();

            }
        }
        public MainViewModel()
        {
           
            HomeVM = new HomeViewModel();
            PlayVM = new PlayViewModel();
            EditVM = new EditViewModel();
            CreateVM = new CreateViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {

                CurrentView = HomeVM;

            });
            PlayViewCommand = new RelayCommand(o =>
            {

                CurrentView = PlayVM;

            });
            CreateViewCommand = new RelayCommand(o =>
            {

                CurrentView = CreateVM;

            });
            EditViewCommand = new RelayCommand(o =>
            {

                CurrentView = EditVM;

            });

        }
        //Skapa en metod för att läsa in fil från datorn. CSV file

        public void ReadQuizFile(Quiz Title)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string FilePath = Path.Combine(docpath, @"C:\Temp\QuizFilereal.csv");

            StreamReader streamReader = new(FilePath);
            string FileLine = "";
            while ((FileLine = streamReader.ReadLine()) != null)
            {
                string[] properties = FileLine.Split(",").ToArray();
                string statement = properties[0].Remove(0, 1);
                int correctAnswer = Convert.ToInt32(properties[1]);
                string option1 = properties[2];
                string option2 = properties[3];
                string option3 = properties[4];

                Question question = new(statement, correctAnswer, option1, option2, option3);
                Title.Question.Add(question);
            }
            streamReader.Close();

            
        }
        
    }
}
