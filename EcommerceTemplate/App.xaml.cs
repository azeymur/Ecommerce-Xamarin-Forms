using EcommerceTemplate.DataStores.MockDataStore;
using EcommerceTemplate.Services;
using Xamarin.Forms;

namespace EcommerceTemplate
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.RegisterSingleton(new BannerDataStore());
            DependencyService.RegisterSingleton(new CategoryDataStore());
            DependencyService.RegisterSingleton(new RatingDataStore());
            DependencyService.RegisterSingleton(new CustomerDataStore());
            DependencyService.RegisterSingleton(new FavoriteDataStore());
            DependencyService.RegisterSingleton(new CartItemDataStore());
            DependencyService.RegisterSingleton(new ProductDataStore());
            DependencyService.RegisterSingleton(new VariantDataStore());

            DependencyService.Register<IService, MockService>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
