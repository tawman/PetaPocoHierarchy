using System;
using System.Linq;
using System.Collections.Generic;
using PetaPoco;

namespace PetaPocoHierarchy.Models
{
	public class Organization
	{
		public Guid Id { get; set; }
		public Guid ParentId { get; set; }
		public string OrganizationCode { get; set; }
		public string Name { get; set; }

		[Ignore]
		public Organization Parent { get; set; }

		[Ignore]
		public string Hierarchy
		{
			get { return string.Join(" › ", GetHierarchy().Select(x => x.Name)); }
		}

		public IEnumerable<Organization> GetHierarchy()
		{
			if (Parent == null)
			{
				yield return this;
			}
			else
			{
				foreach (var ancestor in Parent.GetHierarchy())
				{
					yield return ancestor;
				}

				yield return this;
			}
		}
	}
}