using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPropina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            double Total = double.Parse(total.Text);
            double Propina = double.Parse(propina.Text);
            double Numpersonas = double.Parse(numpersonas.Text);

            double ResPropina = Total * Propina / 100;
            double ResTotal = Total + ResPropina;
            double ResPropPers = ResPropina / Numpersonas;
            double ResTotalPersona = ResTotal / Numpersonas;

            txtResPropina.Detail = ResPropina.ToString("C");
            txtResTotal.Detail = ResTotal.ToString("C");
            txtResPropPers.Detail = ResPropPers.ToString("C");
            txtResTotalPersona.Detail = ResTotalPersona.ToString("C");
        }
    }
}
