using System.ComponentModel.DataAnnotations;

namespace LifEx.Infrastructure.Data.Models
{
    public class Skill
    {
        [Key]
        public long ID { get; set; }
        public int ModuleID_FK { get; set; }
        public string Name {  get; set; } = string.Empty;
        public string? Description { get; set; }
        public int DifficultID_FK { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}