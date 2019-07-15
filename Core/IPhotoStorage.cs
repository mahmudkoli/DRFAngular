using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DRF.Core
{
    public interface IPhotoStorage
    {
         Task<string> StorePhoto(string uploadsFolderPath, IFormFile file);
    }
}