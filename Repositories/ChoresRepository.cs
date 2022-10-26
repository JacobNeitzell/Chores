namespace Chores.Repositories;

public class ChoresRepository : BaseRepository
{

  public ChoresRepository(IDbConnection db) : base(db)
  {

  }

  public List<Chore> GetChores()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();

  }

  public List<Chore> GetChoreId(int id)
  {
    var sql = "SELECT * FROM chores Where @id = id;";
    return _db.Query<Chore>(sql, new { id }).ToList();
  }


  public Chore CreateChore(Chore choreData)
  {
    var sql = @"
  INSERT INTO chores(name,done,amount,type)
  VALUES
  (@Name, @Done, @Amount, @Type);
  SELECT LAST_INSERT_ID();";
    choreData.Id = _db.ExecuteScalar<int>(sql, choreData);
    return choreData;
  }






}