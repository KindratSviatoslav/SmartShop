using System;
using System.Threading.Tasks;

namespace SmartShop.Abstraction.Bll.CommonServices.Loging
{
	public interface ILogger
	{
		void Log(string message, LogLevels level = LogLevels.Info);
		void Log(Exception exception, LogLevels level = LogLevels.Error);

		Task LogAsync(string message, LogLevels level = LogLevels.Info);
		Task LogAsync(Exception exception, LogLevels level = LogLevels.Error);
	}
}
