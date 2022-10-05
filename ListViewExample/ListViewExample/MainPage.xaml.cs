using Xamarin.Forms;

namespace ListViewExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item12.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewDemo());
            };
            Item13.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewCode());
            };
            Item14.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewSource());
            };
            Item15.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ListViewGroup());
            };
        }
    }
}
