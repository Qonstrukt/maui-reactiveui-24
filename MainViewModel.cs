using ReactiveUI.Primitives.Reactive;
using ReactiveUI.Reactive;

namespace maui_reactiveui_24;

public class MainViewModel : ReactiveObject, IActivatableViewModel
{
    public string Name
    {
        get => field;
        set => this.RaiseAndSetIfChanged(ref field, value);
    }
    
    public ViewModelActivator Activator { get; } = new();

    public MainViewModel()
    {
        this.WhenActivated(d =>
        {
            this.WhenAnyValue(x => x.Name)
                .Subscribe(_ => Console.WriteLine("Name changed"))
                .DisposeWith(d);
        });
    }
}