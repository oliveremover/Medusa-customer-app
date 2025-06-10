namespace BlazorHybridApp.Views;

public partial class HomePageView : ContentPage
{
    public HomePageView()
    {
        InitializeComponent();
    }
    private void OnOverviewTabTapped(object sender, System.EventArgs e)
        {
            SelectTab(0);
        }

        private void OnMyTabTapped(object sender, System.EventArgs e)
        {
            SelectTab(1);
        }

        private void OnAllTabTapped(object sender, System.EventArgs e)
        {
            SelectTab(2);
        }

        private void SelectTab(int tabIndex)
        {
            // Reset all tabs
            OverviewIndicator.BackgroundColor = Colors.Transparent;
            MyIndicator.BackgroundColor = Colors.Transparent;
            AllIndicator.BackgroundColor = Colors.Transparent;
            
            // Reset all text colors and fonts
            var unselectedColor = Color.FromArgb("#777777");
            
            Label overviewLabel = (Label)OverviewTab.Children.First(c => c is Label);
            Label myLabel = (Label)MyTab.Children.First(c => c is Label);
            Label allLabel = (Label)AllTab.Children.First(c => c is Label);
            
            overviewLabel.TextColor = unselectedColor;
            overviewLabel.FontFamily = "RobotoRegular";
            
            myLabel.TextColor = unselectedColor;
            myLabel.FontFamily = "RobotoRegular";
            
            allLabel.TextColor = unselectedColor;
            allLabel.FontFamily = "RobotoRegular";
            
            // Hide all content
            OverviewContent.IsVisible = false;
            MyContent.IsVisible = false;
            AllContent.IsVisible = false;
            
            // Highlight the selected tab and show its content
            switch (tabIndex)
            {
                case 0:
                    OverviewIndicator.BackgroundColor = Colors.Black;
                    overviewLabel.TextColor = Colors.Black;
                    overviewLabel.FontFamily = "RobotoMedium";
                    OverviewContent.IsVisible = true;
                    break;
                case 1:
                    MyIndicator.BackgroundColor = Colors.Black;
                    myLabel.TextColor = Colors.Black;
                    myLabel.FontFamily = "RobotoMedium";
                    MyContent.IsVisible = true;
                    break;
                case 2:
                    AllIndicator.BackgroundColor = Colors.Black;
                    allLabel.TextColor = Colors.Black;
                    allLabel.FontFamily = "RobotoMedium";
                    AllContent.IsVisible = true;
                    break;
            }
        }
}