using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TrayIcon
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            //changing the systemTray Icon
            try
            {
                App.SetIcon(new Uri("avares://TrayIcon/Assets/trayChange.ico"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Button2_OnClick(object? sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button1_OnClick(object? sender, RoutedEventArgs e)
        {
            try
            {
                App.SetIcon(new Uri("avares://TrayIcon/Assets/tray.ico"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void Button3_OnClick(object? sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
