namespace FeijooJLayouts;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void BotonIrAbsolute_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }
}