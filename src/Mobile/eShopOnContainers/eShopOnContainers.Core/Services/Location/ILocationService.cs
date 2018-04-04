using System.Threading.Tasks;

namespace bliztafree.Core.Services.Location
{    
    public interface ILocationService
    {
        Task UpdateUserLocation(bliztafree.Core.Models.Location.Location newLocReq, string token);
    }
}