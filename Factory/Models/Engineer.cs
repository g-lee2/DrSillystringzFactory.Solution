using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "The name can't be empty!")]
    public string EngineerName { get; set; }
    [Required(ErrorMessage = "The contact info can't be empty!")]
    public string ContactInfo { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}