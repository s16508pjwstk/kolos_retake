using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_retake.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolos_retake.Controllers
{
    [Route("api/artists/")]
    [ApiController]
    public class ArtistController : ControllerBase
    {

        private readonly ICustomDbService _dbService;

        ArtistController(ICustomDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id}")]
        public IActionResult GetArtist(int id)
        {
            if (_dbService.GetArtist(id) == null)
            {
                return NotFound("Artist doesnt exist");
            }

            var paintings = _dbService.GetPaintings(id);

            return Ok();



            return Ok();
        }
}