using UniversityAPI.Models.DataModels;

namespace UniversityAPI.Services
{
    public interface IStudentService
    {
            IEnumerable<Student> GetStudentsWithCourses();
    }
}
