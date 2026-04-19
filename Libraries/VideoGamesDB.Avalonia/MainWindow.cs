using SideScroll.Avalonia.Charts.LiveCharts;
using SideScroll.Avalonia.Controls;
using SideScroll.Avalonia.Controls.ScreenCapture;
using SideScroll.Tabs;
using VideoGamesDB.Tabs;

namespace VideoGamesDB.Avalonia;

public class MainWindow : BaseWindow
{
	public MainWindow() : base(Project.Load(VideoGamesDBProjectSettings.Settings))
	{
		LoadTab(new TabVideoGamesDB());

		LiveChartCreator.Register();
		ScreenCapture.AddControlTo(TabViewer);
		TabViewer.Toolbar?.AddRightControls();
	}
}
