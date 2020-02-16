using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DependencyInversion
{
    public class Offer
    {
        public string Name { get; set; }
    }

    /* repository */
    public interface IOfferRepository
    {
        void Add(Offer offer);
    }

    public class OfferRepository : IOfferRepository
    {
        public void Add(Offer offer)
        {
            //Add to storage
        }
    }
    /* repository */

    /* service */
    public interface IOfferService
    {
        void Add(Offer offer);
    }

    public class OfferService
    {
        private IOfferRepository _offerRepository;

        public OfferService(IOfferRepository offerRepository)
        {
            _offerRepository = offerRepository;
        }

        public void Add(Offer offer)
        {
            _offerRepository.Add(offer);
        }
    }
    /* service */

    /* controller */
    public class OfferController : ControllerBase
    {
        private IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOffer()
        {
            _offerService.Add(new Offer() { Name = "Awesome offer" });

            return Ok();
        }
    }
    /* controller */
}
