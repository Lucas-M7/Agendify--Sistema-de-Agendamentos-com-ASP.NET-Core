using Agendify.Domain.Enums;
using Agendify.Domain.Exceptions;

namespace Agendify.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; }
    public Client Client { get; set; } =  new Client();
    public Guid ClientId { get; set; }
    public Business Business { get; set; }  = new Business();
    public Guid BusinessId { get; set; }
    public DateTime StartTime{ get; set; }
    public DateTime EndTime{ get; set; }
    public AppointmentStatus Status { get; set; }
    
    private Appointment() { }

    private Appointment(Guid clientId, Guid businessId, DateTime starTime, DateTime endTime)
    {
        Id =  Guid.NewGuid();
        ClientId = clientId;
        BusinessId = businessId;
        StartTime = starTime;
        EndTime = endTime;
        Status = AppointmentStatus.Pending;
    }

    public static Appointment Create(Guid clientId, Guid businessId, DateTime startTime, DateTime endTime)
    {
        if (startTime < DateTime.UtcNow)
            throw new DomainException("O agendamento não pode ser feito no passado.");

        if (endTime <= startTime)
            throw new DomainException("O horário de término do compromisso deve ser posterior ao horário de início.");
        
        return new Appointment(clientId, businessId, startTime, endTime);
    }
}