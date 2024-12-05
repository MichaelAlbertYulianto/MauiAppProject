using MauiAppProject.Models;

namespace MauiAppProject.Data
{
    public interface ICourseCategory
    {
        Task<List<CourseCategory>> ListAsync();
        Task<CourseCategory> GetAsync(int id);
        Task<CourseCategory> AddAsync(CourseCategory category);
        Task<CourseCategory> UpdateAsync(CourseCategory category);
        Task DeleteAsync(int id);
    }
}
