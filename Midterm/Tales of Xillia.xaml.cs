namespace Midterm;

public partial class Tales_of_Xillia : ContentPage
{
	public Tales_of_Xillia()
	{
		InitializeComponent();
	}
    private void OnAddToCartClicked(object sender, EventArgs e)
    {
        ResultLabel.Text = "Added to cart!";
        ResultLabel.IsVisible = true;
    }
}