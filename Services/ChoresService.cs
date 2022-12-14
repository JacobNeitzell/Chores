using Chores.Data;

namespace Chores.Services;

public class ChoresService
{
  private readonly FakeDb _db;

  public List<Chore> GetChores()
  {
    return _db.Chores;
  }

  public Chore GetChore(string id)
  {
    var chore = _choreRepo.get(id);
    if (chore == null)
    {
      throw
    }
  }


  public Chore AddChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }


  public ChoresService(FakeDb db)
  {
    _db = db;
  }
}