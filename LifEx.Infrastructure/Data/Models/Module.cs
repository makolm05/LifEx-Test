using System.ComponentModel.DataAnnotations;

namespace LifEx.Infrastructure.Data.Models
{
    public class Module
    {
        [Key]
        public int ID { get; set; }
        public int AreaID_FK { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ImageURI { get; set; }
        public int SortOrder { get; set; }
        public DateTime CreatedOn {  get; set; }
        public DateTime ModifiedOn { get; set;  }
    }
}