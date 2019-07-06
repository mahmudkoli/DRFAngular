using System;
using System.Threading.Tasks;
using DRF.Core.Models;

namespace DRF.Core
{
    public interface IVehicleRepository
    {
         Task<Vehicle> GetVehicle(int id, bool includeRelated = true); 
        void Add(Vehicle vehicle);
        void Remove(Vehicle vehicle);
    }
}