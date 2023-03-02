using CommunityToolkit.Mvvm.Input;
using Lynx.Domain.Ports;
using System.Windows.Input;

namespace Lynx.DesktopClient.ViewModels;

public class MainPageViewModel
{
    private readonly IGitInteractor _gitInteractor;

    public MainPageViewModel(IGitInteractor gitInteractor)
    {
        _gitInteractor = gitInteractor;
        CloneCommand = new RelayCommand(Clone);
        InitCommand = new RelayCommand(Init);
    }

    public ICommand CloneCommand { get; }
    public ICommand InitCommand { get; }

    public void Clone()
    {

    }

    public void Init()
    {
        Console.WriteLine("Init");
    }
}
