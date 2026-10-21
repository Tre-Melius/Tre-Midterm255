namespace Midterm;

public partial class Checkoutpage : ContentPage
{
	public Checkoutpage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        RefreshCart();
    }

    private void CheckoutClear()
    {
        Cart.Names.Clear();
        Cart.Quantities.Clear();
        Cart.Price.Clear();

        RefreshCart();
    }

    void RefreshCart()
    {
        List<string> lines = new List<string>();

        double totalCost = 0.0;

        for (int i = 0; i < Cart.Names.Count; i++)
        {
            double linetotalCost = Cart.Quantities[i] * Cart.Price[i];

            lines.Add($"{Cart.Names[i]} X {Cart.Quantities[i]} at ${Cart.Price[i]:F2} = ${linetotalCost:F2}");

            totalCost += linetotalCost;

        }

        CartListView.ItemsSource = null;
        CartListView.ItemsSource = lines;

        TotalLabel.Text = $"Total: ${(totalCost):F2}";
    }

    private void CheckoutButton_Clicked(object sender, EventArgs e)
    {
        CheckoutButton.Text = "Thank you for your purchase!";
        CheckoutButton.BackgroundColor = Colors.DarkGoldenrod;
        CheckoutClear();
    }
}