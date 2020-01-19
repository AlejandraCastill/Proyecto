using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabs.Views.Analisis;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabs.Views.Principal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detalles : ContentPage
    {
        public Detalles()
        {
            InitializeComponent();
        }

        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeclinacionPozo());
            
        }
    }
}