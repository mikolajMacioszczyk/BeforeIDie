using System;
using System.ComponentModel.DataAnnotations;

namespace BeforeIDie.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Localization { get; set; }
        [Required] 
        public string ImgUrl { get; set; }
        public Status Status { get; set; }
        public DateTime DateOfRealization { get; set; }
        [Range(0, 5)]
        public int Rating { get; set; }
        public string Feelings { get; set; }
    }
}