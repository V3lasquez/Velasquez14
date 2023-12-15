using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Velasquez14.Models;
using Velasquez14.Services;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Velasquez14.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CompraView : ContentPage
    {
        public CompraView()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            CompraService service = new CompraService();
            List<Compra> compras = new List<Compra>();

            compras.Add(new Compra { Date = dpDate.Date, Cliente = txtCliente.Text, Total = txtTotal.Text, Vendedor = txtVendedor.Text });

            service.CreateRange(compras);


        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            CompraService service = new CompraService();
            lvMatriculas.ItemsSource = service.Get();
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            CompraService service = new CompraService();
            lvCompras.ItemsSource = service.GetByText(txtFilter.Text.Trim());
        }
    }
}
