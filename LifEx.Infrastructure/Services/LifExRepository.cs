using LifEx.Infrastructure.Data.DTOs;

namespace LifEx.Infrastructure.Services
{
    public class LifExRepository : ILifExRepository
    {
        public Task<IEnumerable<AreaDTO>> GetAreasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ModuleDTO>> GetModulesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PathDTO>> GetPathsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SkillDTO>> GetSkillsAsync()
        {
            throw new NotImplementedException();
        }
    }
}