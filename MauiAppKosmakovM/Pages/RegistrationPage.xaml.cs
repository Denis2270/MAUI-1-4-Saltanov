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
                AppShell.Current.DisplayAlert("������" ,"���� ����� �� ������ ���� ������!", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                AppShell.Current.DisplayAlert("������", "���� ������ �� ������ ���� ������!", "OK");
                return;
            }

            if (password.Length < 8)
            {
                AppShell.Current.DisplayAlert("������", "������ �� ������ ���� ������ 8 ��������", "OK");
                return;
            }

            if (password != repeatPassword)
            {
                AppShell.Current.DisplayAlert("������", "������ ������ ���������!", "OK");
                return;
            }

            UserData.Users.Add(new User(name, password));

            AppShell.Current.DisplayAlert("�����", "�� ����������������", "OK");
            AppShell.Current.GoToAsync("..", true);
        }
    }

}