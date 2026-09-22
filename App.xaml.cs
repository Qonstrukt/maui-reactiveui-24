using Microsoft.Extensions.DependencyInjection;

namespace maui_reactiveui_24;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new MainPage());
		
		// This completely crashes the app:
		// return new Window(new AppShell());
	}
}