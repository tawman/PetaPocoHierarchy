using System.Collections.Generic;
using PetaPocoHierarchy.Models;

namespace PetaPocoHierarchy.Services
{
	public interface IOrganizationRepository
	{
		IEnumerable<Organization> GetAll();
	}
}
