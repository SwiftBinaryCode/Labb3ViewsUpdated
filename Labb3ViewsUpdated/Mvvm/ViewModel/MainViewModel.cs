
using Labb3ViewsUpdated.Commands;
using Labb3ViewsUpdated.Core;
using Labb3ViewsUpdated.Manager;
using Labb3ViewsUpdated.Mvvm.Model;
using System;
using System.IO;
using System.Linq;
using System.Windows.Input;

namespace Labb3ViewsUpdated.Mvvm.ViewModel
{

    class MainViewModel : ObservableObject
    {

        //private QuizManager quizManager;
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

    }
}
