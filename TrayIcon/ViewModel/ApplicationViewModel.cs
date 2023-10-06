using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Platform;

namespace TrayIcon.ViewModel;

public class ApplicationViewModel : INotifyPropertyChanged
{
    private WindowIcon _icon = new(AssetLoader.Open(new Uri("avares://TrayIcon/Assets/tray.ico")));
    
    public WindowIcon Icon
    {
        get => _icon;
        set
        {
            _icon = value;
            OnPropertyChanged();
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}