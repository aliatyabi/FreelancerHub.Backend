using FreelancerHub.Domain.Entities;

namespace FreelancerHub.Application.Interfaces
{
	public interface IUserRepository
	{
		Task<User?> GetByIdAsync(Guid id);
		Task<User?> GetByEmailAsync(string email);
	}
}
