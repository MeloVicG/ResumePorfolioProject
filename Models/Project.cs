using System;
using System.ComponentModel.DataAnnotations;

namespace ResumePorfolio.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}