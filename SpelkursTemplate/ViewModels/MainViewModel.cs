namespace SpelkursTemplate.ViewModels;
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
    public int Name { get; set; } = 1;


    public ICommand RegisterScoreCommand { get; }

    public void RegisterScore()
    {

    }

























    public void Test()
    {
        Student erik = new();

        Teacher eva = new();

    }

    public void Greet(ICanGreet member)
    {
        Name = member.SayHello();
    }
}

