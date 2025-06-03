
using MauiAppAnimeFast.Models;

namespace MauiAppAnimeFast
{
    public partial class App : Application
    {
        public List<Camarim> lista_camarims = new List<Camarim> 
        {
            new Camarim() 
            {
                Descricao = "Vip Básico",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 45.0
            },
            new Camarim() 
            {
                Descricao = "Premium",
                ValorDiariaAdulto = 70.0,
                ValorDiariaCrianca = 65.0
            },
            new Camarim()
            {
                Descricao = "Vip/Camarote",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 110.0
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
