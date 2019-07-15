using System.Collections.Generic;
using System.Threading.Tasks;
using DRF.Core.Models;

namespace DRF.Core
{
    public interface IPhotoRepository
    {
         Task<IEnumerable<Photo>> GetPhotos(int vehicleId);
    }
}