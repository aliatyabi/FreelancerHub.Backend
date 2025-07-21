namespace FreelancerHub.Application.Common
{
	public interface IUnitOfWork
	{
		Task SaveChangesAsync();
	}
}
