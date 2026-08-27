using LifEx.Infrastructure.Data.DTOs;

namespace LifEx.Infrastructure.Services
{
    public interface ILifExRepository
    {
        Task<List<PathDTO>> GetPathsAsync();
        Task<List<AreaDTO>> GetAreasAsync();
        Task<List<ModuleDTO>> GetModulesAsync();
        Task<List<SkillDTO>> GetSkillsAsync();
    }
}
