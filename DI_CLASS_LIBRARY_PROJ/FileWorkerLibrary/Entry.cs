using System;
using Abstractions;

namespace FileWorkerLibrary
{
  public class Entry
  {
    private readonly IRepository _repository;
    public Entry(IRepository repository)
    {
      _repository = repository;
    }
    public void Start(string[] args)
    {
      // some epic logic to start with
      Console.WriteLine($"{_repository.GetContent()} {args[0]}");
    }
  }
}