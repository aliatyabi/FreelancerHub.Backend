using FreelancerHub.Domain.Entities;

namespace FreelancerHub.Application.Interfaces
{
	public interface IProjectRepository
	{
		Task<Project> GetByIdAsync(Guid id);
		Task<List<Project>> GetOpenProjectsAsync();
		Task AddAsync(Project project);
		void Update(Project project);
	}
}
