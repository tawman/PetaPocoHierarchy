using PetaPoco;

namespace PetaPocoHierarchy.Services
{
	public abstract class Repository
	{
		protected Database SampleDb;

		protected Repository()
		{
			SampleDb = new Database("PetaPocoDB");
		}
	}
}