using AssCommon;

namespace AssWeb;

public class GreatingsService(IConfiguration config, ILogger<GreatingsService> logger) : IHello
{
	public string SayHello()
	{
		using (var loader = new AssemblyLoader())
		{
			var path = config["LibPath"];
			var ass = loader.LoadAssembly(path);
			var hello = ass.CreateInstance("AssLibrary.Hello");
			IHello hello1 = hello as IHello;
			var message = hello1?.SayHello() ?? "null";
			logger.LogWarning("{message} from {assembly}", message, path);
			return message;
		}
	}
}
