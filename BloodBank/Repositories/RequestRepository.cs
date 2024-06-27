using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class RequestRepository : IRequestRepository
{
    private readonly ApplicationDbContext _context;

    public RequestRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public Request? GetRequestById(int requestId)
    {
        return _context.Requests.Find(requestId);
    }

    public IEnumerable<Request> GetRequestsForDonor(int donorId)
    {
        return _context.Requests.Where(r => r.DonorId == donorId).ToList();
    }

    public void AddRequest(Request request)
    {
        _context.Requests.Add(request);
        _context.SaveChanges();
    }

    public void RemoveRequest(int requestId)
    {
        var request = _context.Requests.Find(requestId);
        if (request != null)
        {
            _context.Requests.Remove(request);
            _context.SaveChanges();
        }
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}

