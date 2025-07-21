using FreelancerHub.Application.Common;
using FreelancerHub.Application.Features.Projects.Dtos;
using FreelancerHub.Application.Interfaces;
using FreelancerHub.Domain.Entities;
using FreelancerHub.Domain.Enums;

namespace FreelancerHub.Application.Features.Projects.Commands
{
	public class CreateProjectCommand
	{
		private readonly IProjectRepository _projectRepository;
		private readonly IUserRepository _userRepository;
		private readonly IUnitOfWork _unitOfWork;

		public CreateProjectCommand(
			IProjectRepository projectRepository,
			IUserRepository userRepository,
			IUnitOfWork unitOfWork)
		{
			_projectRepository = projectRepository;
			_userRepository = userRepository;
			_unitOfWork = unitOfWork;
		}

		public async Task<ProjectDto> ExecuteAsync(CreateProjectRequest request)
		{
			// بررسی اینکه کارفرما وجود دارد
			var client = await _userRepository.GetByIdAsync(request.ClientId);

			if (client == null || client.Role != UserRole.Client)
				throw new Exception("Invalid client Id");

			var project = new Project
			{
				Title = request.Title,
				Description = request.Description,
				Budget = request.Budget,
				Deadline = request.Deadline,
				ClientId = request.ClientId,
				Status = ProjectStatus.Open
			};

			await _projectRepository.AddAsync(project);
			await _unitOfWork.SaveChangesAsync();

			return new ProjectDto
			{
				Id = project.Id,
				Title = project.Title,
				Description = project.Description,
				Budget = project.Budget,
				Deadline = project.Deadline,
				Status = project.Status
			};
		}
	}
}
