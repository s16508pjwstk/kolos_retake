using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolos_retake.DTO.Request
{
    public class NewArtistRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int IdCity { get; set; }
        public int IdArtMovement { get; set; }
    }
}
