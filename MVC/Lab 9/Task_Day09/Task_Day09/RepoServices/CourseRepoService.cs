using Task_Day09.Models;

namespace Task_Day09.RepoServices
{
    public class CourseRepoService : ICourseRepository
    {
        public MainDbContext Context { get;}
        public CourseRepoService(MainDbContext context)
        {
            Context = context; 
        }
        public void DeleteCourse(int id)
        {
            Context.courses.Remove(Context.courses.Find(id));
            Context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return Context.courses.ToList();
        }

        public Course GetDetails(int id)
        {
            return Context.courses.Find(id);
        }

        public void Insert(Course course)
        {
            Context.courses.Add(course);
            Context.SaveChanges();
        }

        public void UpdateCourse(int id, Course course)
        {
            Course UpdatedCrs = Context.courses.Find(id);
            UpdatedCrs.CourseId = course.CourseId;
            UpdatedCrs.Topic = course.Topic;
            UpdatedCrs.Grade = course.Grade;
            Context.SaveChanges();
        }
    }
}
