namespace Midterm
{
    public partial class MainPage : ContentPage
    {
        public List<Game> Games = new List<Game>
        {
            new Game { Name = "Assassin's Creed Valhalla", Description = "Explore the Viking world", ImageUrl = "assassins_creed_valhalla.jpg" },
            new Game { Name = "Dragon Age Origins", Description = "Join the party", ImageUrl = "dragon_age_origins.jpg" },
            new Game { Name = "Resident Evil Requiem", Description = "Survive the outbreak", ImageUrl = "resident_evil_requiem.jpg" },
            new Game { Name = "Tales of Xillia", Description = "Embark on a journey", ImageUrl = "tales_of_xillia.jpg" }
        };

        public MainPage()
        {
            InitializeComponent();
            GamesList.ItemsSource = Games;
        }

        private async void OnGameSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                Game selectedGame = (Game)e.CurrentSelection[0];

                GamesList.SelectedItem = null;
                await Shell.Current.GoToAsync($"{selectedGame.Name.Replace("'", "").Replace(" ", "_")}");

            }
        }
    }
}
