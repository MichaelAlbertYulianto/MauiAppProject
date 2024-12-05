using CommunityToolkit.Mvvm.Input;
using MauiAppProject.Models;

namespace MauiAppProject.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}