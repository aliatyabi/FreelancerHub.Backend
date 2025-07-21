using FreelancerHub.Domain.Entities;

namespace FreelancerHub.Application.Interfaces
{
	public interface IProposalRepository
	{
		Task<List<Proposal>> GetByProjectIdAsync(Guid projectId);
		Task AddAsync(Proposal proposal);
	}
}
