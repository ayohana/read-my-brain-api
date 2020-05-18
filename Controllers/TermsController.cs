using System;
using System.Text.RegularExpressions;
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
    public ActionResult<string> Post([FromBody] string input)
    {
      Regex searchSpecialCharsAtEnd = new Regex("[^a-zA-Z0-9c̅āp̄↑↓]+$");
      Regex searchForNumbersAtStart = new Regex("^[0-9]+");
      Regex searchForGenderAtEnd = new Regex("(M|F)$");
      string[] words = input.Split(" ");
      for (int i = 0; i < words.Length; i++) 
      {
        string wordToSearch = words[i];
        string startSpecialChar = "";
        string endSpecialChar = "";
        Match endMatch = searchSpecialCharsAtEnd.Match(wordToSearch);
        Match startMatch = searchForNumbersAtStart.Match(wordToSearch);
        Match genderMatch = searchForGenderAtEnd.Match(wordToSearch);
        if (endMatch.Success)
        {
          endSpecialChar = endMatch.Value;
          wordToSearch = wordToSearch.Substring(0, endMatch.Index);
        }
        if (startMatch.Success)
        {
          startSpecialChar = startMatch.Value;
          wordToSearch = wordToSearch.Substring(startSpecialChar.Length);
          if (genderMatch.Success)
          {
            startSpecialChar = startSpecialChar + " year(s) old ";
          }
        }
        var query = _db.Terms.AsQueryable();
        query = query.Where(term => term.Name.Equals(wordToSearch));
        foreach (var term in query.ToList()) {
          if (term.Name == wordToSearch) 
          {
            words[i] = startSpecialChar + term.Definition + endSpecialChar;
          }
        }
      }
      string translatedInput = string.Join(" ", words);
      return translatedInput;
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
