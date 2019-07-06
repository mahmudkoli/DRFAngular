using System.Threading.Tasks;
using DRF.Core; 

namespace DRF.Persistence
{
    public class UnitOfWork : IUnitOfWork
  {
    private readonly DRFDbContext context;

    public UnitOfWork(DRFDbContext context)
    {
      this.context = context;
    }

    public async Task CompleteAsync()
    {
      await context.SaveChangesAsync();
    }
  }
}