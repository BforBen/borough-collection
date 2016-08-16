using System.Web.Mvc;
using System.Linq;
using GuildfordBoroughCouncil.BoroughCollection.Models;
using GuildfordBoroughCouncil.Linq;

namespace GuildfordBoroughCouncil.BoroughCollection.Controllers
{
    public class HomeController : Controller
    {
        private CollectionData db = new CollectionData();

        [Route]
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Artists = new SelectList(db.BoroughCollectionArtists.Where(a => a.Works.Count() > 0).OrderBy(a => a.ArtistName), "ArtistID", "ArtistName");

            return View();
        }

        [Route("search")]
        [HttpGet]
        public ActionResult Search()
        {
            ViewBag.Artists = new SelectList(db.BoroughCollectionArtists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName");
            ViewBag.Media = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Media).Select(w => w.Media).Distinct());
            ViewBag.Periods = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Period).Select(w => w.Period).Distinct());
            ViewBag.Subjects = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Subject).Select(w => w.Subject).Distinct());

            return View();
        }

        [Route("search")]
        [HttpPost]
        public ActionResult Search(string q, int? artist, string media, string period, string subject)
        {
            ViewBag.Artists = new SelectList(db.BoroughCollectionArtists.OrderBy(a => a.ArtistName), "ArtistID", "ArtistName");
            ViewBag.Media = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Media).Select(w => w.Media).Distinct());
            ViewBag.Periods = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Period).Select(w => w.Period).Distinct());
            ViewBag.Subjects = new SelectList(db.BoroughCollectionWorks.OrderBy(a => a.Subject).Select(w => w.Subject).Distinct());

            ViewBag.Search = q;
            ViewBag.Searched = true;

            var Works = db.BoroughCollectionWorks
                .WhereIf(!string.IsNullOrEmpty(q), w => w.WorkTitle.Contains(q) || w.Period.Contains(q) || w.Media.Contains(q) || w.Subject.Contains(q) || w.ArtistDetails.ArtistName.Contains(q))
                .WhereIf(artist.HasValue, w => w.Artist == artist)
                .WhereIf(!string.IsNullOrEmpty(media), w => w.Media == media)
                .WhereIf(!string.IsNullOrEmpty(period), w => w.Period == period)
                .WhereIf(!string.IsNullOrEmpty(subject), w => w.Subject == subject)
                .OrderBy(w => w.WorkTitle);

            return View(Works);
        }

        [Route("artist/{id}")]
        [HttpGet]
        public ActionResult Artist(int Id)
        {
            var artist = db.BoroughCollectionArtists.Where(a => a.ArtistID == Id).SingleOrDefault();
            return View(artist);
        }
    }
}