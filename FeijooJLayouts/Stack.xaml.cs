namespace FeijooJLayouts;

public partial class Stack : ContentPage
{
	public Stack()
	{
		InitializeComponent();
	}

    private void BotonIrFlex_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new FlexLayout());
    }
}