using System.ComponentModel.DataAnnotations;

namespace LifEx.Infrastructure.Data.Models
{
    public class DifficultyLevel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
    }
}