using CRUD.Interface;
using CRUD.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.Repository
{
	public class IDCardRepository : IIDCardRepository
	{
		private  CRUDContext CRUDContext;

		public IDCardRepository()
		{
			CRUDContext = new CRUDContext();
		}
		//public List<IDCardListUI> GetAllIdCards()
		//{
		//	var IdCardList = CRUDContext.IdCardDetails.AsNoTracking()
		//		.Select(id => new IDCardListUI()
		//		{
		//			Name = id.Name,
		//			Gender = id.Gender,
		//			City = id.City,
		//			PhoneNo = id.PhoneNumber,
		//			ZipCode = id.ZipCode
		//		}).OrderBy(c => c.Name).ToList();
				
		//	return IdCardList;
		//}
	}
}
