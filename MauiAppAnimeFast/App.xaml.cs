
using MauiAppAnimeFast.Models;

namespace MauiAppAnimeFast
{
    public partial class App : Application
    {
        public List<Camarim> lista_camarims = new List<Camarim> 
        {
            new Camarim() 
            {
                Descricao = "Camarote Básico - OTAKU LOUNGE",
                ValorDiariaAdulto = 150.0,
                ValorDiariaCrianca = 145.0
            },
            new Camarim() 
            {
                Descricao = "Premium - CYBER PUNK ANIME",
                ValorDiariaAdulto = 600.0,
                ValorDiariaCrianca = 500.0
            },
            new Camarim()
            {
                Descricao = "Camarote Vip - SAMURAI NINJA ",
                ValorDiariaAdulto = 1120.0,
                ValorDiariaCrianca = 1110.0
            },
            new Camarim()
            {
                Descricao = "Camarote Diamond - MECHA E SCI-FI",
                ValorDiariaAdulto = 2000.0,
                ValorDiariaCrianca = 1500.0
            }

        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ApresentacaoEvento());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
            
    }
}
