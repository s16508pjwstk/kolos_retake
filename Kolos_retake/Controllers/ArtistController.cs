using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolos_retake.DTO.Request;
using Kolos_retake.DTO.Response;
using Kolos_retake.Models;
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

            var artMovements = _dbService.GetArtMovements(id);

            ArtistResponse artistResponse = new ArtistResponse();
            artistResponse.IdArtist = id;
            artistResponse.ArtMovements = artMovements;
            artistResponse.Paintings = paintings;

            return Ok(artistResponse);

        }

        [HttpGet("{id}")]
        public IActionResult AddArtist(NewArtistRequest newArtistRequest)
        {
            if (_dbService.GetCity(newArtistRequest.IdCity) == null)
            {
                return NotFound("City doesnt exist");
            }

            if (_dbService.GetArtMovement(newArtistRequest.IdArtMovement) == null)
            {
                return NotFound("ArtMovement doesnt exist");
            }

            if (_dbService.GetArtists(newArtistRequest.NickName) != null)
            {
                return BadRequest("NickName is taken");
            }

            Artist artist = new Artist(newArtistRequest.FirstName, newArtistRequest.LastName, newArtistRequest.NickName, newArtistRequest.IdCity, newArtistRequest.IdArtMovement);
            _dbService.Add<Artist>(artist);        
            _dbService.SaveChanges();

            return Ok("Created");

        }
    }
}