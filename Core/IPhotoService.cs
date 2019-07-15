using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using DRF.Core.Models;

namespace DRF.Core
{
    public interface IPhotoService
    {
        Task<Photo> UploadPhoto(Vehicle vehicle, IFormFile file, string uploadsFolderPath);
    }
}