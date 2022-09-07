using introASP.Models;
using introASP.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace introASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiBeerController : ControllerBase
    {
        private readonly PubContext _context;

        public ApiBeerController(PubContext context) { 
            _context = context;
        }

        public async Task<List<BeerBrandViewModel>> Get()
        {
            return await _context.Beers.Include(b=>b.Brand)
                .Select(b => new BeerBrandViewModel
                {
                    Id = b.BeerId,
                    Name = b.Name,
                    Brand = b.Brand.Name,
                })
                .ToListAsync();
        }
    }
}
