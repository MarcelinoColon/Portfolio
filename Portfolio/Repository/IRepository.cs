using Portfolio.Models;

namespace Portfolio.Repository
{
    public interface IRepository
    {
        List<Project> GetProjects();
    }
}
