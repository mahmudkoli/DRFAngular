using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DRF.Controllers.Resources;
using DRF.Core.Models;
using DRF.Persistence;

namespace DRF.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly DRFDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(DRFDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<KeyValuePairResource>>(features); 
    }
  }
}