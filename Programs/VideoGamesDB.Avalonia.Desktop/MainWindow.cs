using Avalonia.Controls;
using SideScroll.Avalonia.Charts.LiveCharts;
using SideScroll.Avalonia.Controls;
using SideScroll.Avalonia.Controls.ScreenCapture;
using SideScroll.Tabs;
using SideScroll.Tabs.Settings;
using VideoGamesDB.Avalonia.Desktop.Assets;
using VideoGamesDB.Tabs;

namespace VideoGamesDB.Avalonia.Desktop;

public class MainWindow : BaseWindow
{
	public MainWindow() : base(Project.Load(Settings))
	{
		LoadTab(new TabVideoGamesDB());

		LiveChartCreator.Register();
		ScreenCapture.AddControlTo(TabViewer);
		TabViewer.Toolbar?.AddRightControls();

		Icon = new WindowIcon(Icons.Logo.Stream);
	}

	public static ProjectSettings Settings => new()
	{
		Name = "VideoGamesDB",
		LinkType = "VideoGamesDB",
		Version = ProjectSettings.ProgramVersion(),
		DataVersion = new Version(0, 15),
	};
}
