using System.Threading.Tasks;
using Vega.Core.Models;

namespace Vega.Core
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