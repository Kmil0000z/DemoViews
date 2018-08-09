using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoViews
{
    public partial class CambiarColor : ContentPage
    {
        public CambiarColor()
        {
            InitializeComponent();
        }
        void CambioColor(object sender, Xamarin.Forms.ValueChangedEventArgs e){
            var rojo = sldRojo.Value;
            var azul = sldAzul.Value;
            var verde = sldVerde.Value;
            Color bgcolor = new Color(rojo, azul, verde);
            boxColor.BackgroundColor = bgcolor;
            lbDisplay.Text = ColorToHex(bgcolor);
        }

        private string ColorToHex(Color bgcolor)
        {
            int rojo = (int)(bgcolor.R * 255);
            int verde = (int)(bgcolor.G * 255);
            int azul = (int)(bgcolor.B * 255);
            int alpha = (int)(bgcolor.A * 255);
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";
        }
    }
}
