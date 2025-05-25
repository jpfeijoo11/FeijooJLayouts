namespace FeijooJLayouts;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}
    private async void OnNavigateToGrid(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayout());
    }
}