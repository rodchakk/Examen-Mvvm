using Examen_Mvvm.ViewModels;
using Examen_Mvvm.Views;
namespace Examen_Mvvm

{
    public partial class App : Application
    {



        private Operaciones viewmodel;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Interface());
            viewmodel = new Operaciones();
            BindingContext = viewmodel;
        }
    }
}
