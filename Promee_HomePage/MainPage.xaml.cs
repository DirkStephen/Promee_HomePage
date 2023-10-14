namespace Promee_HomePage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void Hey(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//NewPage1");
        }
    }
}