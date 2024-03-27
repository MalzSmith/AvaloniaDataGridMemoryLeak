using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.ReactiveUI;
using AvaloniaDataGridMemoryLeak.ViewModels;

namespace AvaloniaDataGridMemoryLeak.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void DestroyButton_OnClick(object? sender, RoutedEventArgs e)
    {
        ContentGrid.Children.Clear();
        ContentPanel.IsVisible = false;
        CreateButton.IsVisible = true;
    }

    private void CreateButton_OnClick(object? sender, RoutedEventArgs e)
    {
        CreateButton.IsVisible = false;
        ContentGrid.Children.Add(new ReusedView());

        ContentPanel.IsVisible = true;
    }
}