using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DRF.Core;
using DRF.Core.Models;

namespace DRF.Persistence
{
  public class PhotoRepository : IPhotoRepository
  {
    private readonly DRFDbContext context;
    public PhotoRepository(DRFDbContext context)
    {
      this.context = context;
    }
    public async Task<IEnumerable<Photo>> GetPhotos(int vehicleId)
    {
      return await context.Photos
        .Where(p => p.VehicleId == vehicleId)
        .ToListAsync();
    }
  }
}