using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "The machine name can't be empty!")]
    public string MachineName { get; set; }
    [Required(ErrorMessage = "The machine brand can't be empty!")]
    public string MachineBrand { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}