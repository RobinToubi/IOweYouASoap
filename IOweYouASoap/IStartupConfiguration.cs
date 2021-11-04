using System;

namespace IOweYouASoap
{
	public interface IStartupConfiguration
	{
		Type ServiceType { get; }
	}

	public class StartupConfiguration : IStartupConfiguration
	{
		public StartupConfiguration(Type serviceType)
		{
			ServiceType = serviceType;
		}

		public Type ServiceType { get; }
	}
}
