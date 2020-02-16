using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViolationExample
{
    public class Offer
    {
        public string Name { get; set; }
    }

    /* repository */
    public class OfferRepository
    {
        public void Add(Offer offer)
        {
            //add to storage
        }
    }
    /* repository */

    /* service */
    public class OfferService
    {
        private OfferRepository _offerRepository = new OfferRepository();

        public void Add(Offer offer)
        {
            _offerRepository.Add(offer);
        }
    }
    /* service */

    /* controller */
    public class OfferController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddOffer()
        {
            OfferService offerService = new OfferService();
            offerService.Add(new Offer() { Name = "Awesome offer" });

            return Ok();
        }
    }
    /* controller */
}
