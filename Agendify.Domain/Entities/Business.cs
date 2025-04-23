namespace Agendify.Domain.Entities;

public class Business
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }  = string.Empty;
    public string Email { get; set; }  = String.Empty;
    public string Phone { get; set; } = String.Empty;
    
    List<Appointment> appointments = [];
}