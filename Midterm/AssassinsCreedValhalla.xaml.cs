namespace Midterm;

public partial class AssassinsCreedValhalla : ContentPage
{
	public AssassinsCreedValhalla()
	{
        InitializeComponent();
	}
	private void OnAddToCartClicked(object sender, EventArgs e)
    {
        Game game = new Game
        {
            Name = "Assassin's Creed Valhalla",
            Description = "Explore the Viking world",
            ImageUrl = "assassins_creed_valhalla.jpg",
            Price = 59.99m
        };
        cart.CartItems.Add(game);
        ResultLabel.Text = $"added to your cart.";
        ResultLabel.IsVisible = true;
    }
}