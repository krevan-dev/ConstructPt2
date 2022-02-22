using System;
using System.ComponentModel.DataAnnotations;

namespace ConstructPt2.Models
{
  public class Contractor
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Specialty { get; set; }
  }
}