using System.Threading.Tasks;
using vega.Core.Models;

namespace vega.Core
{
    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle vehicle);
        Task<Vehicle> GetVehicleAsync(int id, bool includeRelated = true);
        void RemoveVehicle(Vehicle vehicle);
        Task<Model> FindModelAsync(int id);
        Task<QueryResult<Vehicle>> ListVehiclesAsync(VehicleQuery queryObj = null);
    }
}