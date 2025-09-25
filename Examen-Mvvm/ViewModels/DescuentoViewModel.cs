using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Mvvm.ViewModels
{
    public partial class DescuentoViewModel : ObservableObject
    {
        [ObservableProperty] double precioPan;
        [ObservableProperty] double precioRefresco;
        [ObservableProperty] double precioSpaguethis;

        [ObservableProperty] double subtotal;
        [ObservableProperty] double descuento;
        [ObservableProperty] double total;

        [RelayCommand]
        void Calcular()
        {
            Subtotal = PrecioPan + PrecioRefresco + PrecioSpaguethis;

            if (Subtotal >= 1000 && Subtotal <= 4999.99)
                Descuento = Subtotal * 0.10;
            else if (Subtotal >= 5000 && Subtotal <= 9999.99)
                Descuento = Subtotal * 0.20;
            else if (Subtotal >= 10000 && Subtotal <= 19999.99)
                Descuento = Subtotal * 0.30;
            else
                Descuento = 0;

            Total = Subtotal - Descuento;
        }

        [RelayCommand]
        void Limpiar()
        {
            PrecioPan = 0;
            PrecioRefresco = 0;
            PrecioSpaguethis = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }
    }
}