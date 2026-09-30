namespace SpelkursTemplate.ViewModels;

using SpelkursTemplate.Commands;
using System.Windows.Input;


public class MainViewModel
{
    public MainViewModel()
    {
        RegisterScoreCommand = new RelayCommand(
            _ => RegisterScore()
            );
    }
    public string Name { get; set; } = "Erik Öberg"; // nytt namn
    public string GradeColor { get; set; }


    public ICommand RegisterScoreCommand { get; }

    public void RegisterScore()
    {

    }
}

