namespace UserService.Web.Contributors.CreateContributor;

public class CreateContributorResponse(int id, string name)
{
  public int Id { get; set; } = id;
  public string Name { get; set; } = name;
}
