using SideScroll.Resources;
using System.Reflection;

namespace VideoGamesDB.Start.Avalonia.Assets;

public static class Icons
{
	public const string IconPath = "VideoGamesDB.Start.Avalonia.Assets";

	public static Assembly Assembly => Assembly.GetExecutingAssembly();

	public static ResourceView Logo => new(Assembly, IconPath, "Logo", "SideScroll", "ico");
}
