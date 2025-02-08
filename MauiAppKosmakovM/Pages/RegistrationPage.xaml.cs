using MauiAppSaltanov.Models;

namespace MauiAppSaltanov.Pages;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private void RegistrationClicked(object sender, EventArgs e)
    {
        {
            string name = NameTb.Text;
            string password = PasswordTb.Text;
            string repeatPassword = RepeatPasswordTb.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                AppShell.Current.DisplayAlert("Ошибка" ,"Поле имени не должно быть пустым!", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                AppShell.Current.DisplayAlert("Ошибка", "Поле пароля не должно быть пустым!", "OK");
                return;
            }

            if (password.Length < 8)
            {
                AppShell.Current.DisplayAlert("Ошибка", "Пароль не должен быть меньше 8 символов", "OK");
                return;
            }

            if (password != repeatPassword)
            {
                AppShell.Current.DisplayAlert("Ошибка", "Пароли должны совпадать!", "OK");
                return;
            }

            UserData.Users.Add(new User(name, password));

            AppShell.Current.DisplayAlert("Успех", "Вы зарегистрированы", "OK");
            AppShell.Current.GoToAsync("..", true);
        }
    }

}