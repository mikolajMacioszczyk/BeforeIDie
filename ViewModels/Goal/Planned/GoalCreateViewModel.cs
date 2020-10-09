using System.ComponentModel.DataAnnotations;

namespace BeforeIDie.ViewModels.Goal.Planned
{
    public class GoalCreateViewModel
    {
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
    }
}