using Avalonia;

namespace VideoGamesDB.Start.Avalonia;

class Program
{
    [STAThread]
	static int Main(string[] args)
	{
		AppBuilder builder = BuildAvaloniaApp();

		return builder.StartWithClassicDesktopLifetime(args);
	}

	public static AppBuilder BuildAvaloniaApp()
		=> AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.WithInterFont()
			.LogToTrace();
}
