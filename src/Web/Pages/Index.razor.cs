using Microsoft.AspNetCore.Components;
using OL.Core.Contracts.Services;
using OL.Core.Model;

namespace OL.Web.Pages
{
    public partial class Index
    {
        private IEnumerable<Course>? courses;
        [Inject]
        private ICourseService CourseService { get; set; } = default!;

        /// <inheritdoc />
        protected override async Task OnInitializedAsync()
        {
            courses = await CourseService.GetAll();    
            await base.OnInitializedAsync();
        }
    }
}
