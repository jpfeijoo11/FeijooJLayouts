namespace FeijooJLayouts;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void BotonRegresar_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}