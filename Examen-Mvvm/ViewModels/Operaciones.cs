using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

namespace Examen_Mvvm.ViewModels
{
    public partial class Operaciones : ObservableObject
    {
        [ObservableProperty]
        private double a;

        [ObservableProperty]
        private double b;

        [ObservableProperty]
        private double c;

        [ObservableProperty]
        private double subtotal;

        [ObservableProperty]
        private double descuento;

        [ObservableProperty]
        private double total;

        private void Alerta(string titulo, string mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () =>
                await App.Current!.MainPage!.DisplayAlert(titulo, mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            try
            {

                Subtotal = A + B + C;

                if (Subtotal >= 10000)
                {
                    Descuento = Subtotal * 0.30;
                }
                else if (Subtotal >= 5000 && Subtotal < 10000) // 
                {
                    Descuento = Subtotal * 0.20;
                }
                else if (Subtotal >= 1000 && Subtotal < 5000)
                {
                    Descuento = Subtotal * 0.10;
                }
                else
                {
                    Descuento = 0;
                }

                Total = Subtotal - Descuento;

            }
            catch (Exception ex)
            {
                Alerta("Error", $"Ha ocurrido un error: {ex.Message}");
            }








            }







        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            C = 0;
            Subtotal = 0;
            Descuento = 0;
            Total = 0;
        }









    }
}
