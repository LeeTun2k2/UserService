using System.ComponentModel.DataAnnotations;

namespace UserService.Web.Contributors.CreateContributor;

public class CreateContributorRequest
{
  public const string Route = "/Contributors";

  [Required]
  public string? Name { get; set; }
  public string? PhoneNumber { get; set; }
}
