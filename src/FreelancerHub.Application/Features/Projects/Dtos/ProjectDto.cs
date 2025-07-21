using FreelancerHub.Domain.Enums;

namespace FreelancerHub.Application.Features.Projects.Dtos
{
	public class ProjectDto
	{
		public Guid Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public decimal Budget { get; set; }
		public DateTime Deadline { get; set; }
		public ProjectStatus Status { get; set; }
	}
}
