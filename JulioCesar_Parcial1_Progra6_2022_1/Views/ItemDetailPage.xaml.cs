using JulioCesar_Parcial1_Progra6_2022_1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace JulioCesar_Parcial1_Progra6_2022_1.Views
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