using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public interface ICourseRepository
    {
        public List<Course> GetAll();
        public Course GetDetails(int id);
        public void Insert(Course course);
        public void UpdateCourse(int id, Course course);
        public void DeleteCourse(int id);
    }
}
