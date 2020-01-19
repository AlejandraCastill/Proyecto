using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Datos : ContentPage
    {
        public Datos()
        {
            InitializeComponent();
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            //await App.Database.InsPROYECTOAsync(new PROYECTO
            //{
            //    Id = 1,
            //    Nombre = "pprue",
            //    Descripcion = "Pruebas"
            //});


            //PROYECTOListView.ItemsSource = await App.Database.GetPROYECTOAsync();
            if (!string.IsNullOrWhiteSpace(Name.Text) && !string.IsNullOrWhiteSpace(LastName.Text) && !string.IsNullOrWhiteSpace(Telephone.Text))
            {
                await App.Database.InsPROYECTOAsync(new PROYECTO
                {
                    Id = Convert.ToInt64(Name.Text),
                    Nombre = LastName.Text,
                    Descripcion = Telephone.Text
                });

                Name.Text = LastName.Text = Telephone.Text = string.Empty;
                ContactListView.ItemsSource = await App.Database.GetPROYECTOAsync();
            }
        }

    }
}