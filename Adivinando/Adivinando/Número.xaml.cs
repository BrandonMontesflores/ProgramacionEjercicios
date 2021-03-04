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
    public partial class Número : ContentPage
    {
        public Número()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int num0 = Convert.ToInt32(resultado.Text);
            int num1;
            num1 = (num0 / 10) - 4;
            string num = ("El número que piensas es "  + num1);
            DisplayAlert("Número", num, "Listo");
        }
    }
}