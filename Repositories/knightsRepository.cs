using System;
using System.Collections.Generic;
using System.Data;
using knights.Models;
using Dapper;


namespace knights.Repositories
{
  public class knightsRepository
  {
    private readonly IDbConnection _db;
    public knightsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Knight> GetAll()
    {
      string sql = "SELECT * FROM knights";
      return _dbQuery<Knight>(sql);
    }

  }
}