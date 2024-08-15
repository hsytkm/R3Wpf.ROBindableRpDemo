using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace RpDemo;

internal class MainWindowViewModel : BindableBase
{
    private readonly Model _model;

    public IReadOnlyList<string> Items { get; }
    public IReadOnlyReactiveProperty<string?> SelectedItem { get; }

    public MainWindowViewModel()
    {
        _model = new Model();

        Items = _model.Candidates;

        SelectedItem = _model.ObserveProperty(x => x.Item)
            .ToReadOnlyReactivePropertySlim();
    }
}

internal class Model : BindableBase
{
    public IReadOnlyList<string> Candidates { get; }

    public string? Item
    {
        get => _item;
        set => SetProperty(ref _item, value);
    }
    private string? _item;

    public Model()
    {
        Candidates = ["Apple", "Berry", "Cheese"];
        Item = Candidates[0];
    }
}
