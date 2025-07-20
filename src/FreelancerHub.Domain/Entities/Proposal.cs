using FreelancerHub.Domain.Enums;

namespace FreelancerHub.Domain.Entities
{
	public class Proposal
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public Guid ProjectId { get; set; }
		public Guid FreelancerId { get; set; }
		public decimal ProposedPrice { get; set; }
		public int EstimatedDays { get; set; }
		public ProposalStatus Status { get; set; } = ProposalStatus.Pending;
	}
}
