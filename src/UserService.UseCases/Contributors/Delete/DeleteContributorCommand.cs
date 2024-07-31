using Ardalis.Result;
using Ardalis.SharedKernel;

namespace UserService.UseCases.Contributors.Delete;

public record DeleteContributorCommand(int ContributorId) : ICommand<Result>;
