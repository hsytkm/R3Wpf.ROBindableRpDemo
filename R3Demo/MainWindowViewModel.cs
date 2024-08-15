using R3;

namespace R3Demo;

internal class MainWindowViewModel : BindableBase
{
    private readonly Model _model;

    public IReadOnlyList<string> Items { get; }
    public IReadOnlyBindableReactiveProperty<string?> SelectedItem { get; }

    public MainWindowViewModel()
    {
        _model = new Model();

        Items = _model.Candidates;

        SelectedItem = _model.ObservePropertyChanged(x => x.Item)
            .ToReadOnlyBindableReactiveProperty();
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
