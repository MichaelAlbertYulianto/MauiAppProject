namespace MauiAppProject.Pages;

public partial class CourseCategoryPage : ContentPage
{
    public CourseCategoryPage(CourseCategoryPageModel courseCategoryPageModel)
    {
        InitializeComponent();
        BindingContext = courseCategoryPageModel;
    }
}