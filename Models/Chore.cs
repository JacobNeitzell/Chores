using Chores.Enums;

namespace Chores.Models;

public class Chore
{
  public int Id { get; set; }

  public string Name { get; private set; }

  public bool Done { get; private set; }

  public int Amount { get; private set; }

  public List<string> Area { get; private set; } = new List<string>();
  public ChoreType Type { get; private set; }

  public void ChangeName(string name)
  {
    Name = name;
  }


  public int addAmount()
  {
    Amount++;
    return Amount;
  }
  public Chore(string name, int amount, bool done, ChoreType type)
  {
    Name = name;
    Done = done;
    Amount = amount;
    Type = type;
  }

}