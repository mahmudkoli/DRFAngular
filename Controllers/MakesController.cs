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
    public class MakesController : Controller
    {
        
        private readonly DRFDbContext context;
        private readonly IMapper mapper;

        public MakesController(DRFDbContext context, IMapper mapper)
        {
        this.mapper = mapper;
        this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

    }
}