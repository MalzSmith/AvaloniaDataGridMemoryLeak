using System.Collections.ObjectModel;

namespace AvaloniaDataGridMemoryLeak.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Thing> Things { get; } =
    [
        new("Group 1", "Apple", 3),
        new("Group 1", "Banana", 4),
        new("Group 1", "Cherry", 5),
        new("Group 2", "Pear", 6),
        new("Group 2", "Plum", 7),
        new("Group 2", "Cucumber", 9),
        new("Group 2", "Tomato", 10)
    ];
}

public record Thing(string Group, string Name, int Value);