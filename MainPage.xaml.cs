using ReactiveUI.Primitives.Reactive;
using ReactiveUI.Reactive;

namespace maui_reactiveui_24;

public partial class MainPage
{
	private int _count;

	public MainPage()
	{
		ViewModel = new MainViewModel();
		
		InitializeComponent();

		this.WhenActivated(d =>
		{
			this.WhenAnyValue(x => x.ViewModel.Name)
				.Subscribe(_ => Console.WriteLine("Name changed"))
				.DisposeWith(d);
		
		});
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		_count++;

		CounterBtn.Text = _count == 1 
			? $"Clicked {_count} time" 
			: $"Clicked {_count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
