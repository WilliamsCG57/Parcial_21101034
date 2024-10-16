using Competency.DOMAIN.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompetencyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetencyController : ControllerBase
    {
        private readonly ICompetencyRepository _competencyRepository;


        public CompetencyController(ICompetencyRepository competencyRepository)
        {
            _competencyRepository = competencyRepository;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var competencies = await _competencyRepository.GetCompetencies();
            return Ok(competencies);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Competency.DOMAIN.Core.Entities.Competency competency)
        {
            await _competencyRepository.Insert(competency);
            return Ok(competency);
        }

        [HttpPut("Update")]

        public async Task<IActionResult> Update([FromBody] Competency.DOMAIN.Core.Entities.Competency competency)
        {
            bool result = await _competencyRepository.Update(competency);
            if (!result)
                return BadRequest();
            return Ok(competency.Id);
            
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = await (_competencyRepository.Delete(id));
            if (!result)
                return BadRequest();
            return Ok(id);
        }

    }
}
