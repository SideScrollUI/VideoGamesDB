using SideScroll.Tabs;
using SideScroll.Tabs.Settings;
using SideScroll.UI.Avalonia;
using SideScroll.UI.Avalonia.Charts.LiveCharts;
using SideScroll.UI.Avalonia.ScreenCapture;
using VideoGamesDB.Tabs;

namespace VideoGamesDB.Start.Avalonia;

public class MainWindow : BaseWindow
{
	public MainWindow() : base(new Project(Settings))
	{
		AddTab(new TabVideoGamesDB());

		LiveChartCreator.Register();
		ScreenCapture.AddControlTo(TabViewer);
		TabViewer.Toolbar?.AddVersion();
	}

	public static ProjectSettings Settings => new()
	{
		Name = "VideoGamesDB",
		LinkType = "VideoGamesDB",
		Version = new Version(0, 1),
		DataVersion = new Version(0, 1),
	};
}
