using Microsoft.AspNetCore.Mvc;
using ServerToAngular.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerToAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Donors : ControllerBase
    {
       
        // GET: api/<Donors>
        [Route("GetDonors")]
        [HttpGet]
        public List<Donor> GetDonors()
        {
            return Data.donors;
        }

        [Route("AddDonor")]
        [HttpPost]
        public int AddDonor([FromBody] Donor donor)
        {
            if (donor.Id <= 0)
            {
                var max = Data.donors.Max(x => x.Id);
                donor.Id = max + 1;
            }
            Data.donors.Add(donor);
            return donor.Id;
        }

        [Route("UpdateDonor")]
        [HttpPut]
        public bool UpdateDonor([FromBody] Donor donor)
        {
            var g = Data.donors.FirstOrDefault(x => x.Id == donor.Id);
            if (g != null)
            {
                g.Name = donor.Name;
                g.Email = donor.Email;

                return true;
            }
            return false;
        }
        
          
        [Route("DeleteDonor/{id} ")]
        [HttpDelete]
        public bool DeleteDonor(int id)
        {
            var d = Data.donors.FirstOrDefault(x => x.Id == id);
            if (d != null)
            {
                Data.donors.Remove(d);
                return true;
            }
            return false;
        }

        [Route("GetDonor/{id}")]
        [HttpGet]
        public Donor GetDonorById(int id)
        {
            return Data.donors.FirstOrDefault(x => x.Id == id);
        }
    }
}
