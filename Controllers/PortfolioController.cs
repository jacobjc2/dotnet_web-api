using DotnetWebAPI.Data;
using DotnetWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotnetWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioController : ControllerBase
    {
        
        private readonly ILogger<PortfolioController> _logger;
        private PortfolioDbContext _context;

        public PortfolioController(ILogger<PortfolioController> logger, PortfolioDbContext context)
        {
            _context = context;
            _logger  = logger;
        }

        [HttpGet("experiences")]
        public async Task<ActionResult<IEnumerable<ExperienceDTO>>> Get()
        {
            return await _context.Experience
                .Select(x => ItemToDTO(x))
                .ToListAsync();
        }

        private static ExperienceDTO ItemToDTO(Experience item) =>
        new ExperienceDTO
        {
            exp_id = item.exp_id,
            Title = item.Title,
            Company = item.Company,
            Description = item.Description
        };
    }
}