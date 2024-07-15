using Avalonia.Controls;
using SideScroll.Tabs;
using SideScroll.Tabs.Settings;
using SideScroll.UI.Avalonia;
using SideScroll.UI.Avalonia.Charts.LiveCharts;
using SideScroll.UI.Avalonia.ScreenCapture;
using VideoGamesDB.Start.Avalonia.Assets;
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

		Icon = new WindowIcon(Icons.Logo.Stream);
	}

	public static ProjectSettings Settings => new()
	{
		Name = "VideoGamesDB",
		LinkType = "VideoGamesDB",
		Version = ProjectSettings.ProgramVersion(),
		DataVersion = new Version(0, 1),
	};
}
