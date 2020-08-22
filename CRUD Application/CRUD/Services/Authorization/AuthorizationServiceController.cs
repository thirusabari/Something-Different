using CRUD.Interface;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Services.Authorization
{
	public class AuthorizationServiceController : Controller
	{
		private IAuthorizationRepository iAuthorizationRepository;
		public AuthorizationServiceController(IAuthorizationRepository _iAuthorizationRepository)
		{
			iAuthorizationRepository = _iAuthorizationRepository;
		}
		[HttpPost]
		public LoginUI UserSignIn(LoginUI loginDetails)
		{
			return iAuthorizationRepository.SignIn(loginDetails);
		}
	}
	
}