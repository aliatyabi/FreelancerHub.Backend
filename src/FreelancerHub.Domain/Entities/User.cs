using FreelancerHub.Domain.Enums;

namespace FreelancerHub.Domain.Entities
{
	public class User
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string FullName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public UserRole Role { get; set; }
		// فقط فریلنسرها مهارت دارند
		public List<string>? Skills { get; set; }
	}
}
