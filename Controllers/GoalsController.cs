using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BeforeIDie.Db.Repository;
using BeforeIDie.Models;
using BeforeIDie.ViewModels;
using BeforeIDie.ViewModels.Goal.Planned;
using Microsoft.AspNetCore.Mvc;

namespace BeforeIDie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GoalsController : Controller
    {
        private readonly IGoalRepository _repository;
        private readonly IMapper _mapper;
        
        public GoalsController(IGoalRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<GoalReadViewModel>>> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<GoalReadViewModel>>(await _repository.GetAllAsync()));
        }
        
        [HttpGet]
        [Route("planned")]
        public async Task<ActionResult<IEnumerable<GoalReadViewModel>>> GetPlanned()
        {
            return Ok(_mapper.Map<IEnumerable<GoalReadViewModel>>(await _repository.GetAllAsync()));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GoalReadViewModel>> GetById([FromRoute] int id)
        {
            var goal = await _repository.GetByIdAsync(id);
            if (goal != null)
            {
                return Ok(_mapper.Map<GoalReadViewModel>(goal));
            }
            return NotFound();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<GoalReadViewModel>> Create([FromBody] GoalCreateViewModel created)
        {
            var model = _mapper.Map<Goal>(created);
            if (await _repository.CreateAsync(model))
            {
                await _repository.SaveChangesAsync();
                return Ok(_mapper.Map<GoalReadViewModel>(model));
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete([FromRoute] int id)
        {
            if (await _repository.DeleteAsync(id))
            {
                await _repository.SaveChangesAsync();
                return Ok();
            }
            return NotFound();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<GoalReadViewModel>> Update([FromRoute] int id,
            [FromBody] GoalUpdateViewModel updated)
        {
            var model = _mapper.Map<Goal>(updated);
            if (await _repository.UpdateAsync(id, model))
            {
                await _repository.SaveChangesAsync();
                return _mapper.Map<GoalReadViewModel>(model);
            }
            return NotFound();
        }
        
    }
}