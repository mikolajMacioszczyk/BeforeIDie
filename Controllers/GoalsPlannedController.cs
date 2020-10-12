using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BeforeIDie.Db.Repository;
using BeforeIDie.Models;
using BeforeIDie.ViewModels.Goal.Planned;
using Microsoft.AspNetCore.Mvc;

namespace BeforeIDie.Controllers
{
    [ApiController]
    [Route("api/planned")]
    public class GoalsPlannedController : Controller
    {
        private readonly GoalPlannedRepository _repository;
        private readonly IMapper _mapper;

        public GoalsPlannedController(GoalPlannedRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<GoalPlannedReadViewModel>>> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<GoalPlannedReadViewModel>>(await _repository.GetAllAsync()));
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GoalPlannedReadViewModel>> GetById([FromRoute] int id)
        {
            var goal = await _repository.GetByIdAsync(id);
            if (goal != null)
            {
                return Ok(_mapper.Map<GoalPlannedReadViewModel>(goal));
            }
            return NotFound();
        }
        
        [HttpPost]
        [Route("")]
        public async Task<ActionResult<GoalPlannedReadViewModel>> Create([FromBody] GoalCreateViewModel created)
        {
            var model = _mapper.Map<Goal>(created);
            if (await _repository.CreateAsync(model))
            {
                await _repository.SaveChangesAsync();
                return Ok(_mapper.Map<GoalPlannedReadViewModel>(model));
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
        public async Task<ActionResult<GoalPlannedReadViewModel>> UpdatePlanned([FromRoute] int id,
            [FromBody] GoalPlannedUpdateViewModel updated)
        {
            var model = _mapper.Map<Goal>(updated);
            if (await _repository.UpdateAsync(id, model))
            {
                await _repository.SaveChangesAsync();
                return _mapper.Map<GoalPlannedReadViewModel>(model);
            }
            return NotFound();
        }
        
        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> ChangeStatus([FromRoute] int id,
            [FromBody] Status status)
        {
            if (await _repository.ChangeStatusAsync(id, status))
            {
                await _repository.SaveChangesAsync();
                return Ok();
            }

            return NotFound();
        }
    }
}