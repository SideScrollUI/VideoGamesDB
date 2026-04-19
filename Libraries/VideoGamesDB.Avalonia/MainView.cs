using SideScroll.Avalonia.Charts.LiveCharts;
using SideScroll.Avalonia.Controls;
using SideScroll.Tabs;
using VideoGamesDB.Tabs;

namespace VideoGamesDB.Avalonia;

public class MainView : BaseView
{
	public MainView() : base(Project.Load(VideoGamesDBProjectSettings.Settings))
	{
		LoadTab(new TabVideoGamesDB());

		LiveChartCreator.Register();
		TabViewer.Toolbar?.AddRightControls();
	}
}
