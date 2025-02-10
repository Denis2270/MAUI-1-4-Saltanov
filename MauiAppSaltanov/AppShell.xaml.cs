using MauiAppSaltanov.Pages;

namespace MauiAppSaltanov;


public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
    }
}
