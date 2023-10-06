using System;
using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using TrayIcon.ViewModel;

namespace TrayIcon
{
    public partial class App : Application
    {
        private static ApplicationViewModel? _contex;

        public App()
        {
            DataContext = new ApplicationViewModel();
        }
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                _contex = DataContext as ApplicationViewModel;
                //other code
            }

            base.OnFrameworkInitializationCompleted();
        }

        private void NativeMenuItem_OnClick(object? sender, EventArgs e)
        {
            MainWindow window = new();
            window.Show();
        }
        
        public static void SetIcon(Uri icon)
        {
            try
            {
                if (_contex != null)
                {
                    _contex.Icon = new WindowIcon(AssetLoader.Open(icon));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

    }
}
