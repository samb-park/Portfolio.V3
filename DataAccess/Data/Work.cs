using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data
{
    public class Work
    {
        [Key] public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required] public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool Current { get; set; } = false;
    }
}