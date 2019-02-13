using SmartShop.Models.POCO;
using System.Threading.Tasks;

namespace SmartShop.Abstraction.Bll.BusinessServices
{
	public interface IUserMangmentService
	{
		Task<UserModel> LogIn(string login, string password);
		void LogOut();
		string UserName { get; set; }
		bool IsInRole(string role);
	}
}
