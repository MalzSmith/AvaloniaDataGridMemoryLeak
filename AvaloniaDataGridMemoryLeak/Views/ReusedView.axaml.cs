using System.Reactive.Disposables;
using System.Reactive.Linq;
using Avalonia.Collections;
using Avalonia.ReactiveUI;
using AvaloniaDataGridMemoryLeak.ViewModels;
using ReactiveUI;

namespace AvaloniaDataGridMemoryLeak.Views;

public partial class ReusedView : ReactiveUserControl<MainWindowViewModel>
{
    public ReusedView()
    {
        InitializeComponent();

        this.WhenActivated(d =>
        {
            ViewModel.WhenAnyValue(vm => vm.Things)
                .Select(c =>
                {
                    var view = new DataGridCollectionView(c);
                    view.GroupDescriptions.Add(new DataGridPathGroupDescription(nameof(Thing.Group)));

                    return view;
                })
                .BindTo(this, v => v.DataGrid.ItemsSource)
                .DisposeWith(d);
        });
    }
}