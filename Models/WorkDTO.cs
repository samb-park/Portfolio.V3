using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class WorkDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter Position")] 
        public string Position { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Today;
        public DateTime? EndDate { get; set; } = DateTime.Today;
        public string Description { get; set; }
        public bool Current { get; set; } = false;
    }
}