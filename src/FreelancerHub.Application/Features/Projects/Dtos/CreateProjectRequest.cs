namespace FreelancerHub.Application.Features.Projects.Dtos
{
	public class CreateProjectRequest
	{
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public decimal Budget { get; set; }
		public DateTime Deadline { get; set; }
		public Guid ClientId { get; set; }
	}
}
