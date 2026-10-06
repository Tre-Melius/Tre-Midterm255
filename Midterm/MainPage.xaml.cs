namespace Midterm
{
    public partial class MainPage : ContentPage
    {
        private readonly List<string> Games = new List<string>
        {
            "Assassin's Creed Valhalla",
            "Dragon Age Origins",
            "Resident Evil Requiem",
            "Tales of Xillia"
        };

        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGameSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                GamesList.SelectedItem = null;
                
            }
        }
    }
}