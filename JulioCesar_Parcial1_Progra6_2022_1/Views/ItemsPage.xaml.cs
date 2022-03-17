using JulioCesar_Parcial1_Progra6_2022_1.Models;
using JulioCesar_Parcial1_Progra6_2022_1.ViewModels;
using JulioCesar_Parcial1_Progra6_2022_1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JulioCesar_Parcial1_Progra6_2022_1.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}