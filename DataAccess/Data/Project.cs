using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    public class Project
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string ShortDescription { get; set; }
        [Required] public string Description { get; set; }
        public string GithubUrl { get; set; }
        public string ProjectUrl { get; set; }
        public bool Featured { get; set; }
        public virtual ICollection<ProjectImage> ProjectImages { get; set; }
    }
}