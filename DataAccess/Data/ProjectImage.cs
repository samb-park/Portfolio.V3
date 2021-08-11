using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Data
{
    public class ProjectImage
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ProjectImageUrl { get; set; }
        [ForeignKey("ProjectId")] public virtual Project Project { get; set; }
    }
}