using System.Linq;
using System.Web.Mvc;
using PetaPocoHierarchy.Services;

namespace PetaPocoHierarchy.Controllers
{
    public class OrganizationController : Controller
    {
    	private readonly IOrganizationRepository _repository;

		public OrganizationController(IOrganizationRepository repository)
		{
			_repository = repository;
		}

        public ActionResult Index()
        {
			var organizations = _repository.GetAll().OrderBy(x => x.Hierarchy);

			return View(organizations);
        }
    }
}
