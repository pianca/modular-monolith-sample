namespace AssLibrary;

public class Hello : AssCommon.IHello
{
	const string Version = "4";

	public string SayHello()
	{
		return $"Hello version {Version}";
	}
}
