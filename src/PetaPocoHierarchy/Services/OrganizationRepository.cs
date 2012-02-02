using System.Collections.Generic;
using PetaPocoHierarchy.Models;

namespace PetaPocoHierarchy.Services
{
	public class OrganizationRepository : Repository, IOrganizationRepository
	{
		public IEnumerable<Organization> GetAll()
		{
			// SELECT a row of data containing an Organization and Parent Organization
			// Columns: Id, ParentId, OrganizationCode, Name, Id, ParentId, OrganizationCode, Name
			// Mapping:|----------- Organization -----------||------- Parent Organization --------|
			const string sqlQuery = @"
					WITH CTE(Id, ParentId, OrganizationCode, Name, OrganizationLevel, LinkId) AS
					(
						SELECT Id, ParentId, OrganizationCode, Name,
								0 AS OrganizationLevel, Id as LinkId
						FROM Organization
						UNION ALL
						SELECT o.Id, o.ParentId, o.OrganizationCode, o.Name,
								CTE.OrganizationLevel + 1 AS OrganizationLevel, CTE.LinkId
						FROM Organization o INNER JOIN CTE ON CTE.ParentId = o.Id
					)
					SELECT org.Id, org.ParentId, org.OrganizationCode, org.Name,
						   CTE.Id, CTE.ParentId, CTE.OrganizationCode, CTE.Name
					FROM Organization org LEFT OUTER JOIN CTE ON CTE.LinkId = org.Id
					ORDER BY org.Id, OrganizationLevel DESC";

			// PetaPoco Fetch will map the SQL SELECT row into two Organization objects
			// and pass it to the method expecting a new Organization in return
			return SampleDb.Fetch<Organization, Organization, Organization>(
				new OrganizationParentRelator().BuildHierarchy,
				sqlQuery
			);
		}
	}
}