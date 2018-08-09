using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            timPickInicial.Time = new TimeSpan(17,0,0);
        }

        async void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            await DisplayAlert("¡Perfecto!","La página web ha cargado","Aceptar");
        }
    }
}
