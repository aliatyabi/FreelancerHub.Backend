using FreelancerHub.Domain.Enums;

namespace FreelancerHub.Domain.Entities
{
	public class Project
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public decimal Budget { get; set; }
		public DateTime Deadline { get; set; }
		public ProjectStatus Status { get; set; } = ProjectStatus.Open;
		public Guid ClientId { get; set; }
	}
}
