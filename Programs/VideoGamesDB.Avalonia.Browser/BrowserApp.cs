using Avalonia.Controls;

namespace VideoGamesDB.Avalonia.Browser;

public class BrowserApp : App
{
	protected override Control CreateSingleView() => new BrowserMainView();
}
