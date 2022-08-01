using EcommerceTemplate.Views;
using System;
using Xamarin.Forms;

namespace EcommerceTemplate
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProductDetailPage), typeof(ProductDetailPage));

        }

    }
}
