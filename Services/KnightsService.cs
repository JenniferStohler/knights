using System;
using System.Collections.Generic;
using knights.Models;
using knights.Repositories;

namespace knights.Services
{
  public class KnightsService
  {
    private readonly knightsRepository _repo;

    public KnightsService(knightsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Knight> GetAll()
    {
      return _repo.GetAll();
    }

    //GET BY ID


    //PUT


    //DELETE
  }
}