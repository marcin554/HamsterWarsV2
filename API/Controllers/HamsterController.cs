using API.Repository.Contracts;
using Domain.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("Domain/Api/[controller]")]
    [ApiController]
    public class HamsterController : ControllerBase
    {
        private readonly IHamsterRepository hamsterRepository;

        public HamsterController(IHamsterRepository hamsterRepository)
        {
            this.hamsterRepository = hamsterRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamsters()
        {
            try
            {
                var hamsters = await this.hamsterRepository.GetHamsters();

                if(hamsters == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hamsters);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }

     






        [HttpGet("{id:int}")]
        public async Task<ActionResult<Hamster>> GetHamsterById(int id)
        {
            try
            {
                var hamster = await this.hamsterRepository.GetHamsterById(id);

                if (hamster == null)
                {
                    return BadRequest();
                }
                else
                {
                    return Ok(hamster);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }

        [HttpGet("random")]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetRandomTwoHamsters()
        {
            try
            {
                var hamsters = await this.hamsterRepository.GetRandomTwoHamsters();

                if (hamsters == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(hamsters);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }

        [HttpPost]

        public async Task<ActionResult> InsertHamster(Hamster hamster)
        {
           

            try 
            {
                if (hamster == null)
                {
                    return BadRequest();
                }
                else
                {
                    this.hamsterRepository.InsertHamster(hamster);
                    this.hamsterRepository.Save();
                    return Ok();
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Problem with interting of the object.");
            }
           
        }

        [HttpPut]
        public async Task<ActionResult> UpdateHamster(int hamsterId, bool winOrLose)
        {
            try
            {
                var hamster = await this.hamsterRepository.GetHamsterById(hamsterId);

                if (hamster == null)
                {
                    return NotFound();
                }
                else
                {
                    await this.hamsterRepository.UpdateHamster(hamsterId, winOrLose);
                    this.hamsterRepository.Save();
                    return Ok();
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }

        [HttpDelete]

        public async Task<ActionResult> DeleteHamster(int id)
        {
         
            try
            {
                var hamster = await this.hamsterRepository.GetHamsterById(id);

                if (hamster == null)
                {
                    return NotFound();
                }
                else
                {
                    await this.hamsterRepository.DeleteHamster(hamster.HamsterId);
                    this.hamsterRepository.Save();

                    return Ok();
                }



            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from database");
            }
        }



    }
}
