using MauiAppAnimeFast.Models;

namespace MauiAppAnimeFast.Views;

public partial class ContratacaoEvento : ContentPage
{
	App PropriedadesApp;

	public ContratacaoEvento()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pckCamarim.ItemsSource = PropriedadesApp.lista_camarims;

		dtpck_datainicial.MinimumDate = DateTime.Now;
        dtpck_datainicial.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

		dtpck_datafinal.MinimumDate = dtpck_datainicial.Date.AddDays(0);
		dtpck_datafinal.MaximumDate = dtpck_datainicial.Date.AddDays(5);

	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Evento a = new Evento
			{
				CamarimSelecionado = (Camarim)pckCamarim.SelectedItem,
				QntAdulto = Convert.ToInt32(stp_adulto.Value),
				QntCrianca = Convert.ToInt32(stp_crianca.Value),
				Datainicial = dtpck_datainicial.Date,
				Datafinal = dtpck_datafinal.Date,
			};

			await Navigation.PushAsync(new ResumoReserva() 
			{
				BindingContext = a
			});
		}
		catch (Exception ex) 
		{
			await DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_datainicial_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_datainicial = elemento.Date;

		dtpck_datafinal.MinimumDate = data_selecionada_datainicial.AddDays(1);
		dtpck_datafinal.MaximumDate = data_selecionada_datainicial.AddDays(5);
    }
}