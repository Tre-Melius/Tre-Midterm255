namespace Midterm;

public partial class Resident_Evil_Requiem : ContentPage
{
	public Resident_Evil_Requiem()
	{
		InitializeComponent();
	}
    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        Game game = new Game
        {
            Name = "Resident Evil Requiem",
            Description = "Face your fears in this horror adventure",
            ImageUrl = "resident_evil_requiem.jpg",
            Price = 29.99
        };
        Cart.Names.Add(game.Name);
        Cart.Quantities.Add(int.Parse(QuantityEntry.Text));
        Cart.Price.Add(game.Price);
        ResultLabel.Text = $"{QuantityEntry.Text} added to cart!";
        ResultLabel.IsVisible = true;
    }
}