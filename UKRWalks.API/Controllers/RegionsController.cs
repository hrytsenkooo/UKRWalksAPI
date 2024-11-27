using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UKRWalks.API.Data;
using UKRWalks.API.Models.Domain;
using UKRWalks.API.Models.DTO;

namespace UKRWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly UKRWalksDbContext dbContext;

        public RegionsController(UKRWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await dbContext.Regions.ToListAsync();
            var regionsDto = new List<RegionDto>();
            foreach (var region in regions)
            {
                regionsDto.Add(new RegionDto()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl
                });
            }
            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var region = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);

            if (region == null) return NotFound();

            var regionDto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };
            return Ok(regionDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            var region = new Region
            {
                Code = addRegionRequestDto.Code,
                Name = addRegionRequestDto.Name,
                RegionImageUrl = addRegionRequestDto.RegionImageUrl
            };

            await dbContext.Regions.AddAsync(region);
            await dbContext.SaveChangesAsync();

            var regionDto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return CreatedAtAction(nameof(GetById), new { id = region.Id }, regionDto);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionRequestDto updateRegionRequestDto)
        {
            var region = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (region == null) return NotFound();

            region.Code = updateRegionRequestDto.Code;
            region.Name = updateRegionRequestDto.Name;
            region.RegionImageUrl = updateRegionRequestDto.RegionImageUrl;

            await dbContext.SaveChangesAsync();

            var regionDto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return Ok(regionDto);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var region = await dbContext.Regions.FirstOrDefaultAsync(x => x.Id == id);
            if (region == null) return NotFound();

            dbContext.Regions.Remove(region);
            await dbContext.SaveChangesAsync();

            var regionDto = new RegionDto
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return Ok(regionDto);
        }
    }
}
