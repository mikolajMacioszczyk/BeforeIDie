using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BeforeIDie.Db.Repository;
using BeforeIDie.Models;
using BeforeIDie.ViewModels.Goal.Planned;
using BeforeIDie.ViewModels.Goal.Realized;
using Microsoft.AspNetCore.Mvc;

namespace BeforeIDie.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RealizedController : Controller
    {
        private readonly GoalRealizedRepository _repository;
        private readonly IMapper _mapper;

        public RealizedController(GoalRealizedRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<IEnumerable<GoalRealizedReadViewModel>>> GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<GoalRealizedReadViewModel>>(await _repository.GetAllAsync()));
        }
        
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<GoalRealizedReadViewModel>> GetById([FromRoute] int id)
        {
            var goal = await _repository.GetByIdAsync(id);
            if (goal != null)
            {
                return Ok(_mapper.Map<GoalRealizedReadViewModel>(goal));
            }
            return NotFound();
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
            [FromBody] GoalRealizedUpdateViewModel updated)
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