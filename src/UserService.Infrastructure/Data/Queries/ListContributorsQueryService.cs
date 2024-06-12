using UserService.UseCases.Contributors;
using UserService.UseCases.Contributors.List;
using Microsoft.EntityFrameworkCore;

namespace UserService.Infrastructure.Data.Queries;

public class ListContributorsQueryService(AppDbContext _db) : IListContributorsQueryService
{
  public async Task<IEnumerable<ContributorDTO>> ListAsync()
  {
    var result = await _db.Contributors.ToListAsync();
    
    var dtos = new List<ContributorDTO>();
    foreach (var item in result)
      dtos.Add(new ContributorDTO
      (
        item.Id,
        item.Name, 
        item.PhoneNumber?.Number
      ));

    return dtos;
  }
}
