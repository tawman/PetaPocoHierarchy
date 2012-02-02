using PetaPocoHierarchy.Models;

namespace PetaPocoHierarchy.Services
{
	/// <summary>
	/// Set Organization Parent in the Organization Hierarchy
	/// </summary>
	/// <remarks>
	/// Based on logic for mapping demo: http://www.toptensoftware.com/Articles/115/PetaPoco-Mapping-One-to-Many-and-Many-to-One-Relationships
	/// </remarks>
	public class OrganizationParentRelator
	{
		private Organization _current;

		public Organization BuildHierarchy(Organization organization, Organization parent)
		{
			// Terminating call and prepare for PetaPoco callback with nulls
			if (organization == null)
				return _current;

			if (_current != null && _current.Id == organization.Id)
			{
				// Push Parent Up the Hierarchy if not reference to self
				if (organization.Id != parent.Id)
				{
					parent.Parent = _current.Parent;
					_current.Parent = parent;
				}
				// Return null to indicate not at the top of the Hierarchy
				return null;
			}
			// Save the current Organization
			var prev = _current;
			// Setup the new Organization Parent if not null
			_current = organization;

			if (organization.Id != parent.Id)
				_current.Parent = parent;

			// Return the now populated previous Organization (or null if first time through)
			return prev;
		}
	}
}