using MauiAppAnimeFast.Models;

namespace MauiAppAnimeFast.Views;

public partial class ResumoReserva : ContentPage
{
	public ResumoReserva()
	{
		InitializeComponent();
	

    }

    private async void button1_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopAsync();
        }
        catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void button2_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PopToRootAsync();
        }
        catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
        if (BindingContext is Evento evento && evento.CamarimSelecionado != null)
        {
            // Tudo certo, pode prosseguir
        }
        else 
        {
            await DisplayAlert("Erro", "Camarim não foi selecionado corretamente", "OK");
        }
    }
}