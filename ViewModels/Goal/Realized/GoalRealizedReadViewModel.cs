using System;
using BeforeIDie.Models;
using BeforeIDie.ViewModels.Goal.Planned;

namespace BeforeIDie.ViewModels.Goal.Realized
{
    public class GoalRealizedReadViewModel : GoalPlannedReadViewModel
    {
        public Status Status { get; set; }
        public DateTime DateOfRealization { get; set; }
        public int Rating { get; set; }
        public string Feelings { get; set; }
    }
}