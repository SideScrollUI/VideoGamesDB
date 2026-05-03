using SideScroll.Tabs.Settings;

namespace VideoGamesDB.Avalonia;

public class VideoGamesDBProjectSettings : ProjectSettings
{
	public static VideoGamesDBProjectSettings Default => new()
	{
		Name = "VideoGamesDB",
		LinkType = "VideoGamesDB",
		Version = ProgramVersion(),
		DataVersion = new Version(0, 17),
	};
}
