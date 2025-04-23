namespace Agendify.Domain.Entities;

public class Client
{
    public int Id { get; set; }
    public string FullName { get; set; } = String.Empty;
    public string Email { get; set; } = String.Empty;
    public string Phone { get; set; } = String.Empty;
    
    private List<Appointment> appointments = [];
}