using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Adivinando
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cumpleaños : ContentPage
    {
        public Cumpleaños()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int num0 = Convert.ToInt32(numero.Text);
            int num1, num2, num3, num4;
            num0 = num0 - 365;
            num1 = (num0 % 10000) / 1000;
            num2 = (num0 % 10000) % 1000 / 100;
            num3 = ((num0 % 10000) % 1000) % 100 / 10;
            num4 = (((num0 % 10000) % 1000) % 100) % 10;
            string dia = ("El día de tu cumpleaños es " + num1 + num2);
            string mes = ("El mes de tu cumpleaños es " + num3 + num4);
            DisplayAlert("Día", dia, "Listo");
            DisplayAlert("Mes", mes, "Listo");
        }
    }
}