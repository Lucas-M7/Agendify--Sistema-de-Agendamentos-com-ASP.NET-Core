using Agendify.Domain.Enums;

namespace Agendify.Domain.Entities;

public class Appointment
{
    public int Id { get; set; }
    public Client Client { get; set; } =  new Client();
    public int ClientId { get; set; }
    public Business Business { get; set; }  = new Business();
    public int BusinessId { get; set; }
    public DateTime DateTime{ get; set; }
    public AppointmentStatus Status { get; set; }
}