using System;
using System.ComponentModel.DataAnnotations;
using BeforeIDie.ViewModels.Goal.Planned;

namespace BeforeIDie.ViewModels.Goal.Realized
{
    public class GoalRealizedUpdateViewModel : GoalPlannedUpdateViewModel
    {
        [Required]
        public DateTime DateOfRealization { get; set; }
        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }
        [Required]
        public string Feelings { get; set; }
    }
}