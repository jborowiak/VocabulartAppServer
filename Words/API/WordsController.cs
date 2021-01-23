using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VocabularyApp.Common;

namespace VocabularyApp.Words.API
{
  [Route("Words")]
  public class WordsController:BaseController
  {
    [HttpGet]
    public List<WordDto> GetWords()
    {
      return new List<WordDto>();
    }
  }
}
