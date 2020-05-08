using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadMyBrainAPI.Models;

namespace ReadMyBrainAPI.Controllers
{
  [Route("api")]
  [ApiController]
  public class TermsController : ControllerBase
  {
      
    private ReadMyBrainAPIContext _db;

    public TermsController(ReadMyBrainAPIContext db)
    {
      _db = db;
    }

    // GET /api
    [HttpGet]
    public ActionResult<IEnumerable<Term>> Get(string name, string definition)
    {
      var query = _db.Terms.AsQueryable();
      if (name != null) 
      {
        query = query.Where(term => term.Name.Equals(name));
      }
      if (definition != null)
      {
        query = query.Where(term => term.Definition.Contains(definition) == true);
      }
      return query.ToList();
    }

    // GET /api
    [HttpGet("{id}")]
    public ActionResult<Term> Get(int id)
    {
      return _db.Terms.FirstOrDefault(term => term.TermID == id);
    }

    // POST /api
    [HttpPost]
    public void Post([FromBody] Term term)
    {
      _db.Terms.Add(term);
      _db.SaveChanges();
    }

    // // POST /api/translate
    [HttpPost("translate")]
    public ActionResult<Array> Post([FromBody] string input)
    {
      string[] words = input.Split(" ");
      for (int i = 0; i < words.Length; i++) {
        var query = _db.Terms.AsQueryable();
        query = query.Where(term => term.Name.Equals(words[i]));
        foreach (var term in query.ToList()) {
          if (term.Name == words[i]) {
            words[i] = term.Definition;
          }
        }
      }
      return words;
    }

    // PUT /api/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Term term)
    {
      term.TermID = id;
      _db.Entry(term).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE /api/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var termToDelete = _db.Terms.FirstOrDefault(term => term.TermID == id);
      _db.Terms.Remove(termToDelete);
      _db.SaveChanges();
    }
  }
}
