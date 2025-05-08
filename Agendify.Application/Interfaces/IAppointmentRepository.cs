namespace Agendify.Application.Interfaces;

public interface IAppointmentRepository
{
    Task<bool> HasConflictAsync(Guid businessId, DateTime startTime, DateTime endTime);
}