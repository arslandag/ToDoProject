using Microsoft.AspNetCore.Mvc;
using PetProject.API.Contracts;
using PetProject.Application.Interfaces;
using PetProject.Core.Models;

namespace PetProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TargetController : ControllerBase
    {
        private readonly ITargetsService _targetsService;

        public TargetController(ITargetsService targetsService)
        {
            _targetsService = targetsService;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<TargetResponse>>> GetTarget()
        {
            var target = await _targetsService.GetAllTarget();

            var responce = target.Select(t => new TargetResponse(t.Id, t.Name, t.Description));

            return Ok(responce);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateTarget(TargetRequest request)
        {
            var target = Target.Create(
                Guid.NewGuid(),
                request.Name,
                request.Description
                );

            await _targetsService.CreateTargaet(target);

            return Ok(target);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<Guid>> DeleteTarget(Guid id)
        {
            await _targetsService.DeleteTarget(id);

            return Ok();
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult<Guid>> UpdateTargets(Guid id, TargetRequest request)
        {
            var target = await _targetsService.UpdateTarget(id, request.Name, request.Description);

            return Ok(target);
        }
    }
}
