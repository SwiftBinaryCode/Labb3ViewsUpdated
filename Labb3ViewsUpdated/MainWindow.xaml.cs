using Labb3ViewsUpdated.Mvvm.ViewModel;
using System.Windows;

namespace Labb3ViewsUpdated
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
