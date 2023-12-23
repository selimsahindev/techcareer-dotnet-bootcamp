using System;

namespace TechcareerDotnetBootcamp.Models
{
	public class WebUser
	{
		public int Id { get; private set; }
		public string Email { get; private set; } = string.Empty;

		public WebUser(int id, string email)
		{
			Id = id;
			Email = email;
		}
	}
}

