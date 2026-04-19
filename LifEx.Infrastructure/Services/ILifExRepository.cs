namespace LifEx.Infrastructure.Services
{
    public interface ILifExRepository
    {
        Task<IEnumerable<Country>> GetPathsAsync();
        Task<IEnumerable<Area>> GetAreasAsync();
        Task<IEnumerable<Module>> GetModulesAsync();
        Task<IEnumerable<Skill>> GetSkillsAsync();
    }
}
