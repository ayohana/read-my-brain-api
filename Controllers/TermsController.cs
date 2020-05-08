using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReadMyBrainAPI.Models;

namespace ReadMyBrainAPI.Controllers
{
  [Route("api/terms")]
  [ApiController]
  public class TermsController : ControllerBase
  {
      
    private ReadMyBrainAPIContext _db;

    public TermsController(ReadMyBrainAPIContext db)
    {
      _db = db;
    }

    // GET api/terms
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

    // GET api/terms/5
    [HttpGet("{id}")]
    public ActionResult<Term> Get(int id)
    {
      return _db.Terms.FirstOrDefault(term => term.TermID == id);
    }

    // POST api/terms
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/terms/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/terms/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
