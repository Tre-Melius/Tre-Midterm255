namespace Midterm;

public partial class Tales_of_Xillia : ContentPage
{
	public Tales_of_Xillia()
	{
		InitializeComponent();
	}
    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        Game game = new Game
        {
            Name = "Tales of Xillia",
            Description = "Embark on a fantasy adventure",
            ImageUrl = "tales_of_xillia.jpg",
            Price = 19.99
        };
        Cart.Names.Add(game.Name);
        Cart.Quantities.Add(int.Parse(QuantityEntry.Text));
        Cart.Price.Add(game.Price);
        ResultLabel.Text = $"{QuantityEntry.Text} added to cart!";
        ResultLabel.IsVisible = true;
    }
}