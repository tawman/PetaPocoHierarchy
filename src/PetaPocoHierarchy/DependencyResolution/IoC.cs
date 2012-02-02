using PetaPocoHierarchy.Services;
using StructureMap;

namespace PetaPocoHierarchy
{
	public static class IoC
	{
		public static IContainer Initialize()
		{
			ObjectFactory.Initialize(x => x.Scan(scan =>
			                                     	{
			                                     		scan.TheCallingAssembly();
														scan.AssemblyContainingType<OrganizationRepository>();
			                                     		scan.WithDefaultConventions();
			                                     	}));

			return ObjectFactory.Container;
		}
	}
}