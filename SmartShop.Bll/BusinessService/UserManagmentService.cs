using SmartShop.Abstraction.Bll.BusinessServices;

namespace SmartShop.Bll.BusinessService
{
	public class UserManagmentService : IUserMangmentService
	{
		public string UserName { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

		public bool IsInRole(string role)
		{
			throw new System.NotImplementedException();
		}

		public System.Threading.Tasks.Task<SmartShop.Models.POCO.UserModel> LogIn(string login, string password)
		{
			throw new System.NotImplementedException();
		}

		public void LogOut()
		{
			throw new System.NotImplementedException();
		}
	}
}
