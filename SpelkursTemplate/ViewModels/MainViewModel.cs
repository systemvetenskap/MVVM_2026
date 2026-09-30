namespace SpelkursTemplate.ViewModels;

using SpelkursTemplate.Commands;
using System.Windows.Input;

namespace ClimbingScore.ViewModels;

public class MainViewModel
{
    public MainViewModel()
    {
        RegisterScoreCommand = new RelayCommand(
            _ => RegisterScore()
            );
    }
    public string Name { get; set; } = "Erik";


    public ICommand RegisterScoreCommand { get; }

    public void RegisterScore()
    {

    }
}

