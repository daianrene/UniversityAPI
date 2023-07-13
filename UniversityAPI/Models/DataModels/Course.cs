using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models.DataModels
{
    public enum Level
    {
        Easy, Medium, Hard, Expert
    }
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(250)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public Level Level { get; set; } = Level.Easy;

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
