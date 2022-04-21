namespace ToolbarAlignmentTester;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartupPage()) { BarBackgroundColor = Colors.DarkGray, BarTextColor = Colors.White };
	}
}
