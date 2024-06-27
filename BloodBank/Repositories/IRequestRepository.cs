using System.Collections.Generic;

public interface IRequestRepository
{
    Request? GetRequestById(int requestId);
    IEnumerable<Request> GetRequestsForDonor(int donorId);
    void AddRequest(Request request);
    void RemoveRequest(int requestId);
    void SaveChanges();
}
