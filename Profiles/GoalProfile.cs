using AutoMapper;
using BeforeIDie.Models;
using BeforeIDie.ViewModels.Goal.Planned;
using BeforeIDie.ViewModels.Goal.Realized;

namespace BeforeIDie.Profiles
{
    public class GoalProfile : Profile
    {
        public GoalProfile()
        {
            CreateMap<Goal, GoalPlannedReadViewModel>();
            CreateMap<GoalCreateViewModel, Goal>();
            CreateMap<GoalPlannedUpdateViewModel, Goal>();

            CreateMap<Goal, GoalRealizedReadViewModel>();
            CreateMap<GoalRealizedUpdateViewModel, Goal>();
        }
    }
}