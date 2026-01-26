using Avalonia;

namespace VideoGamesDB.Start.Avalonia;

internal static class Program
{
    [STAThread]
	static int Main(string[] args)
	{
		AppBuilder builder = BuildAvaloniaApp();

		return builder.StartWithClassicDesktopLifetime(args);
	}

	private static AppBuilder BuildAvaloniaApp()
		=> AppBuilder.Configure<App>()
			.UsePlatformDetect()
			.WithInterFont()
			.LogToTrace();
}
