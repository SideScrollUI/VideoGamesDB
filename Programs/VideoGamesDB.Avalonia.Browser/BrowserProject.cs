using SideScroll.Tabs;
using SideScroll.Tabs.Settings;
using System.Runtime.Versioning;

namespace VideoGamesDB.Avalonia.Browser;

/// <summary>
/// Browser-specific Project that uses localStorage for data persistence
/// </summary>
[SupportedOSPlatform("browser")]
public class BrowserProject(ProjectSettings projectSettings, UserSettings userSettings)
	: Project(projectSettings, userSettings)
{
	/// <summary>
	/// Override Data property to use BrowserProjectDataRepos with localStorage
	/// </summary>
	public override ProjectDataRepos Data => new BrowserProjectDataRepos(ProjectSettings, UserSettings);

	/// <summary>
	/// Loads project with settings restored from localStorage.
	/// </summary>
	public static BrowserProject Load()
	{
		var projectSettings = VideoGamesDBProjectSettings.Settings;
		var defaultUserSettings = new UserSettings();

		// Create a temporary project to access Data.App for loading previously saved UserSettings
		var tempProject = new BrowserProject(projectSettings, defaultUserSettings);
		var userSettings = tempProject.Data.App.Load<UserSettings>() ?? defaultUserSettings;

		return new BrowserProject(projectSettings, userSettings);
	}
}
