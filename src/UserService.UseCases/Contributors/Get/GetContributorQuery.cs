using Ardalis.Result;
using Ardalis.SharedKernel;

namespace UserService.UseCases.Contributors.Get;

public record GetContributorQuery(int ContributorId) : IQuery<Result<ContributorDTO>>;
