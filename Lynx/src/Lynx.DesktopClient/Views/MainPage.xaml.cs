using Lynx.DesktopClient.ViewModels;

namespace Lynx.DesktopClient.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel gitViewModel)
    {
        InitializeComponent();
        BindingContext = gitViewModel;
    }
}

