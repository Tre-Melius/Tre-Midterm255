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
            Price = 59.99
        };
        Cart.Names.Add(game.Name);
        Cart.Quantities.Add(int.Parse(QuantityEntry.Text));
        Cart.Price.Add(game.Price);
        ResultLabel.Text = $"{QuantityEntry.Text} added to your cart.";
        ResultLabel.IsVisible = true;
    }
}