using Abstractions;

namespace Implementations
{
  public class Repository : IRepository
  {
    public string GetContent()
    {
      return "Content";
    }
  }
}