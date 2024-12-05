using MauiAppProject.Models;
using System.Text.Json;

namespace MauiAppProject.Data
{
    public class CourseCategoryRepository : ICourseCategory
    {
        private readonly HttpClient _httpClient;

        public CourseCategoryRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<CourseCategory> AddAsync(CourseCategory category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CourseCategory> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CourseCategory>> ListAsync()
        {
            //get data from http
            var response = await _httpClient.GetAsync($"{HttpHelper.BaseUrl}/api/v1/Categories");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var categories = JsonSerializer.Deserialize<List<CourseCategory>>(content,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return categories ?? new List<CourseCategory>();
            }
            else
            {
                throw new ArgumentException("Cannot get data from server");
            }
        }

        public Task<CourseCategory> UpdateAsync(CourseCategory category)
        {
            throw new NotImplementedException();
        }
    }
}
