using SpelkursTemplate.ViewModels.ClimbingScore.ViewModels;
using System.Windows;

namespace SpelkursTemplate
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