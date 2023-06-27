using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Windows;

namespace wpf9.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        string? _userName;

        [ObservableProperty]
        string? _password;

        [RelayCommand()]
        void Submit()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password)) return;

            MessageBox.Show($"Welcome {UserName}!");
        }
    }
}
