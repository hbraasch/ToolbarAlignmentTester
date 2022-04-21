using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolbarAlignmentTester
{
    internal class NextPage : ContentPage
    {
        public NextPage()
        {
            Title = "NextPage";
            ToolbarItems.Add(new ToolbarItem("Back", "", async () => {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }, ToolbarItemOrder.Primary));

            Content = new Label { Text = Title };
        }
    }
}
