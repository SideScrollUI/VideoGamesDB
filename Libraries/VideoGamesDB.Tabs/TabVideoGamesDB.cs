using SideScroll;
using SideScroll.Avalonia.Tabs;
using SideScroll.Tabs;
using SideScroll.Tabs.Bookmarks.Tabs;
using SideScroll.Tabs.Lists;
using SideScroll.Tabs.Samples;

namespace VideoGamesDB.Tabs;

public class TabVideoGamesDB : ITab
{
	public TabInstance Create() => new Instance();

	private class Instance : TabInstance
	{
		private Database? _database;

		public override void Load(Call call, TabModel model)
		{
			LoadDatabase(call);

			model.Items = new List<ListItem>()
			{
				//new("Platforms", new TabPlatforms()),
				new("Database", new TabDatabase(_database!)),
				new("Charts", new TabVideoGameCharts(_database!)),
				new("Links", new TabLinks()),
				new("Settings", new TabAvaloniaSettings()),
				new("Samples", new TabSamples()),
			};
		}

		private void LoadDatabase(Call call)
		{
			_database = new Database();
			var view = new ReleaseData.View();
			view.Load(call);
			_database.Load(view.Items);
		}
	}
}
