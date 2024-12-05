using MauiAppProject.Models;
using MauiAppProject.PageModels;

namespace MauiAppProject.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}