using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiAppProject.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiAppProject.PageModels
{
    public partial class CourseCategoryPageModel : ObservableObject, IProjectTaskPageModel
    {
        private readonly ICourseCategory _courseCategory;

        public IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand => throw new NotImplementedException();

        public bool IsBusy => throw new NotImplementedException();

        public ObservableCollection<CourseCategory> CourseCategories { get; } = new();

        public CourseCategoryPageModel(ICourseCategory courseCategory)
        {
            _courseCategory = courseCategory;
        }

        [RelayCommand]
        async Task LoadCourseCategories()
        {
            try
            {
                CourseCategories.Clear();
                var categories = await _courseCategory.ListAsync();
                foreach (var category in categories)
                {
                    CourseCategories.Add(category);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
