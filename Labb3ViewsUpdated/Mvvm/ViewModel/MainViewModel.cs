using Labb3ViewsUpdated.Core;
using Labb3ViewsUpdated.Mvvm.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{

    class MainViewModel: ObservableObject
    {

        
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
            string FilePath = Path.Combine(docpath, "QuizFile");

            StreamReader streamReader = new StreamReader(FilePath);
            string FileLine = "";

            while ((FileLine = streamReader.ReadLine()) != null)
            {
                string[] properties = FileLine.Split(",").ToArray();
                string quizQuestion = properties[0].Remove(0, 1);
                int correctQuizAnswer = Convert.ToInt32(properties[1]);
                string option1 = properties[2];
                string option2 = properties[3];
                string option3 = properties[4];

                Question question = new Question(quizQuestion, correctQuizAnswer, option1, option2, option3);
                Title.Question.Add(question);
            }
            streamReader.Close();
        }
    }
}
