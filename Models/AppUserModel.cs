﻿using Microsoft.AspNetCore.Identity;

namespace WEBBANHANG.Models
{
	public class AppUserModel:IdentityUser
	{
		public string Occupation { get; set; }
	}
}
