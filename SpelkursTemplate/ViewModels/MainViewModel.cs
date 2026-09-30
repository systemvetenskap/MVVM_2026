namespace SpelkursTemplate.ViewModels;
using System.Windows.Input;


public class MainViewModel
{
    public MainViewModel()
    {
        RegisterScoreCommand = new RelayCommand(
            _ => RegisterScore()
            );
    }
    public int Name { get; set; } = 1;


    public ICommand RegisterScoreCommand { get; }

    public void RegisterScore()
    {

    }
}

