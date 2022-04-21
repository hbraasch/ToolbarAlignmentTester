using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolbarAlignmentTester
{
    internal class StartupPage : ContentPage
    {
        public StartupPage()
        {
            Title = "StartupPage";
            ToolbarItems.Add(new ToolbarItem("Next", "", async () => {
                var nextPage = new NavigationPage(new NextPage()) { BarBackgroundColor = Colors.DarkGray, BarTextColor = Colors.White }; 
                await Application.Current.MainPage.Navigation.PushModalAsync(nextPage);
            }, ToolbarItemOrder.Primary));

            Content = new Label { Text = Title };
        }
    }
}
