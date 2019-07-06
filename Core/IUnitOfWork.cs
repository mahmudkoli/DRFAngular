using System;
using System.Threading.Tasks;

namespace DRF.Core
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}