namespace MauiAppSaltanov.Pages;

public partial class LoginPage : ContentPage
{

    public LoginPage()
    {
        InitializeComponent();
    }

    private void GoToRegistrationPage(object sender, TappedEventArgs e)
    {
        AppShell.Current.GoToAsync(nameof(RegistrationPage));
    }

    private void SignUpClicked(object sender, EventArgs e)
    {
        string name = NameTb.Text;
        string password = PasswordEntry.Text;

        if (string.IsNullOrWhiteSpace(name))
        {
            AppShell.Current.DisplayAlert("Ошибка", "Поле имени не должно быть пустым!", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            AppShell.Current.DisplayAlert("Ошибка", "Поле пароля не должно быть пустым!", "OK");
            return;
        }

        bool isAuth = UserData.Users.Any(x => x.Name == name && x.Password == password);

        if (!isAuth)
        {
            AppShell.Current.DisplayAlert("Не успех", "Авторизация не пройдена", "OK");
            return;
        }
        AppShell.Current.DisplayAlert("Успех", "Авторизация пройдена", "OK");


        AppShell.Current.GoToAsync("//" + nameof(MenuPage), true);
    }
}
