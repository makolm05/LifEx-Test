using Microsoft.EntityFrameworkCore;
using LifEx.Infrastructure.Data.DTOs;
using LifEx.Infrastructure.DbContexts;

namespace LifEx.Infrastructure.Services
{
    public class LifExRepository : ILifExRepository
    {

        private LifExDbContext _lifExDbContext;

        public LifExRepository(LifExDbContext lifExDbContext) 
        {
            _lifExDbContext = lifExDbContext;        
        }

        public async Task<List<PathDTO>> GetPathsAsync()
        {
            var test = await _lifExDbContext.Paths.FirstOrDefaultAsync();

            return await _lifExDbContext.Paths
                .OrderBy(p => p.ID)
                .Select(p => new PathDTO
                {
                    ID = p.ID,
                    Name = p.Name
                })
                .ToListAsync();
        }

        public Task<List<AreaDTO>> GetAreasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<ModuleDTO>> GetModulesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<SkillDTO>> GetSkillsAsync()
        {
            throw new NotImplementedException();
        }
    }
}