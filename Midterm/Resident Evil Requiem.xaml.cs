namespace Midterm;

public partial class Resident_Evil_Requiem : ContentPage
{
	public Resident_Evil_Requiem()
	{
		InitializeComponent();
	}
    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        ResultLabel.Text = "Added to cart!";
        ResultLabel.IsVisible = true;
    }
}