using JulioCesar_Parcial1_Progra6_2022_1.ViewModels;
using JulioCesar_Parcial1_Progra6_2022_1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace JulioCesar_Parcial1_Progra6_2022_1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
