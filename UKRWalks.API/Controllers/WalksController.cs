using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UKRWalks.API.CustomActionFilters;
using UKRWalks.API.Models.Domain;
using UKRWalks.API.Models.DTO;
using UKRWalks.API.Repositories;

namespace UKRWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> Create([FromBody] AddWalkRequestDto addWalkRequestDto)
        {
            var walk = mapper.Map<Walk>(addWalkRequestDto);

            await walkRepository.CreateAsync(walk);
            return Ok(mapper.Map<WalkDto>(walk));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var walks = await walkRepository.GetAllAsync();

            return Ok(mapper.Map<List<WalkDto>>(walks));
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var walk = await walkRepository.GetByIdAsync(id);
            if (walk == null) return NotFound();

            return Ok(mapper.Map<WalkDto>(walk));
        }

        [HttpPut]
        [Route("{id:guid}")]
        [ValidateModel]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateWalkRequestDto updateWalkRequestDto)
        {
            var walk = mapper.Map<Walk>(updateWalkRequestDto);

            walk = await walkRepository.UpdateAsync(id, walk);
            if (walk == null) return NotFound();

            return Ok(mapper.Map<WalkDto>(walk));
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var walk = await walkRepository.DeleteAsync(id);
            if (walk == null) return NotFound();

            return Ok(mapper.Map<WalkDto>(walk));
        }
    }
}
