namespace SmartShop.Models.DTO
{
	public class UserDTO
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Login { get; set; }
		public int Age { get; set; }
		public string Mail { get; set; }
		public string[] UserRoles { get; set; }
	}
}
