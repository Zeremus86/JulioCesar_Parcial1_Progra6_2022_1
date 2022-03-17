using JulioCesar_Parcial1_Progra6_2022_1.Models;
using JulioCesar_Parcial1_Progra6_2022_1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JulioCesar_Parcial1_Progra6_2022_1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}