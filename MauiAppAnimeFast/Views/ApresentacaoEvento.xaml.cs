namespace MauiAppAnimeFast.Views;

public partial class ApresentacaoEvento : ContentPage
{
	public ApresentacaoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContratacaoEvento());
		}
		catch (Exception ex) 
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}