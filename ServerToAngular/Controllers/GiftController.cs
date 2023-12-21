using Microsoft.AspNetCore.Mvc;
using ServerToAngular.Models;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
namespace ServerToAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class GiftController : ControllerBase
    {
       
        
        [Route("GetGifts")]
        [HttpGet]
        public List<Gift> GetGifts()
        {
            return Data.gifts;
        }

        [Route("AddGift")]
        [HttpPost]
        public int AddGift([FromBody] Gift gift)
        {
            if (gift.Id <= 0)
            {
                var max = Data.gifts.Max(x => x.Id);
                gift.Id = max + 1;
            }
            Data.gifts.Add(gift);
            return gift.Id;
        }
        [Route("UpdateGift")]
        [HttpPut]
        public bool UpdateGift([FromBody] Gift gift)
        {
            var g = Data.gifts.FirstOrDefault(x => x.Id == gift.Id);
            if (g != null)
            {
                g.Name = gift.Name;
                g.Donor = gift.Donor;
                g.Cost = gift.Cost;
                g.Description = gift.Description;
                g.Image = gift.Image;
                g.Quentity = gift.Quentity;
                return true;
            }
            return false;
        }
        [Route("DeleteGift/{id}")]
        [HttpDelete]
        public bool DeleteGift(int id)
        {
            var g = Data.gifts.FirstOrDefault(x => x.Id == id);
            if (g != null)
            {
                Data.gifts.Remove(g);
                return true;
            }
            return false;
        }
        [Route("Get/{id}")]
        [HttpGet]
        public Gift GetById(int id)
        {
           return Data.gifts.FirstOrDefault(x => x.Id == id);
          
        }

    ///donor:
       

  }
}
