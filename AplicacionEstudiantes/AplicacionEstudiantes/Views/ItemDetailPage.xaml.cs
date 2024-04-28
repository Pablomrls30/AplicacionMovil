using AplicacionEstudiantes.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AplicacionEstudiantes.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}