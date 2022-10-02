using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LevelUpDarts.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<String> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        // add our item
        if (!string.IsNullOrWhiteSpace(Text))
        {
            Items.Add(Text);
        }

        // reset text
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    [RelayCommand]
    async Task Tap(string s)
    {
        await Shell.Current.GoToAsync(nameof(DetailPage));
    }
}