namespace SmartShop.Models.POCO
{
	public class UserModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName => $"{FirstName} {LastName}";
		public string Login { get; set; }
		public int Age { get; set; }
		public string Mail { get; set; }
		public string[] UserRoles { get; set; }
	}
}
