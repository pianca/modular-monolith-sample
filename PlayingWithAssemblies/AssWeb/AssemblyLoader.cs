using System.Reflection;
using System.Runtime.Loader;

namespace AssWeb;

public class AssemblyLoader : IDisposable
{
	private AssemblyLoadContext _context;

	public Assembly LoadAssembly(string assemblyPath)
	{
		// Create a new AssemblyLoadContext
		_context = new AssemblyLoadContext("DynamicAssemblyContext", isCollectible: true);

		// Load the assembly into the context
		Assembly assembly = _context.LoadFromAssemblyPath(assemblyPath);

		// Optionally, unload the context when done with the assembly
		// context.Unload();
		return assembly;
	}

	public void Dispose()
	{ _context?.Unload(); }

}
