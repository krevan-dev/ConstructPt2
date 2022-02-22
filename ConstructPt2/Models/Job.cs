namespace ConstructPt2.Models
{
  public class Job
  {
    public int Id { get; set; }
    public int ContractorId { get; set; }
    public int WarehouseId { get; set; }
  }

  public class JobViewModel : Contractor
  { }
}