using TechcareerDotnetBootcamp.Models;

namespace TechcareerDotnetBootcamp.Services
{
	public class WebUserService
	{
		private static List<WebUser> webUsers;

		public static List<WebUser> GetWebUsers()
		{
			if (webUsers == null)
			{
				webUsers = new List<WebUser>
				{
					new WebUser(1, "selim@test.com"),
					new WebUser(2, "developer@test.com"),
					new WebUser(3, "admin@test.com")
				};
			}

			return webUsers;
		}
	}
}

