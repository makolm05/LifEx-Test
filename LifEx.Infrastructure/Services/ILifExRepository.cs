using LifEx.Infrastructure.Data.DTOs;

namespace LifEx.Infrastructure.Services
{
    public interface ILifExRepository
    {
        Task<IEnumerable<PathDTO>> GetPathsAsync();
        Task<IEnumerable<AreaDTO>> GetAreasAsync();
        Task<IEnumerable<ModuleDTO>> GetModulesAsync();
        Task<IEnumerable<SkillDTO>> GetSkillsAsync();
    }
}
