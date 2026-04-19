using SideScroll.Tabs.Settings;

namespace VideoGamesDB.Avalonia;

public static class VideoGamesDBProjectSettings
{
	public static ProjectSettings Settings => new()
	{
		Name = "VideoGamesDB",
		LinkType = "VideoGamesDB",
		Version = ProjectSettings.ProgramVersion(),
		DataVersion = new Version(0, 17),
	};
}
