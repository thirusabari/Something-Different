using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRUD.Interface
{
	public interface IAuthorizationRepository
	{
		LoginUI SignIn(LoginUI login);
	}
}
