using Chores.Enums;

namespace Chores.Data;


public class FakeDb
{

  public List<Chore> Chores = new List<Chore>()
{
new Chore("Clean House",5,false,ChoreType.Cleaning),
new Chore("Go to Store",12,false,ChoreType.Groceries),
new Chore("Clean Car",6,false,ChoreType.Car),
new Chore("Math",5,false,ChoreType.Homework),
};
}