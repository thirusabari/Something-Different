using CRUD.Interface;
using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRUD.Repository
{
	public class AuthorizationRepository : IAuthorizationRepository
	{
		private readonly CRUDContext CRUDContext;
		public AuthorizationRepository(CRUDContext _cRUDContext)
		{
			CRUDContext = _cRUDContext;
		}
		public RequestObject SignIn(LoginUI login)
		{
			var request = new RequestObject();
			var isUserExists = CRUDContext.UserLoginInfo.AsNoTracking()
				.Where(u => u.EmailId == login.EmailId).Any();
			if (!isUserExists)
			{
				using (var scope = CRUDContext.Database.BeginTransaction())
				{
					try
					{
						var userLogin = new UserLoginInfo()
						{
							FirstName = login.FirstName,
							LastName = login.LastName,
							EmailId = login.EmailId,
							Password = login.Password,
							LogInTime = DateTime.Now,
							CreatedBy = login.UserName,
							CreatedDate = DateTime.Now
						};
						CRUDContext.UserLoginInfo.Add(userLogin);
						CRUDContext.SaveChanges();
						request.status = true;
						scope.Commit();
					}
					catch (DbUpdateException ex)
					{
						request.IsDbException = true;
						request.ErrorMessage = ex.Message;
						scope.Rollback();
					}
					catch (Exception Ex)
					{
						request.status = false;
						request.ErrorMessage = Ex.Message;
						scope.Rollback();
					}
				}

			}
			else
			{
				request.status = isUserExists;
			}

			return request;
		}
	}
}
