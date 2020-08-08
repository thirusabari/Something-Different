using CRUD.Interface;
using CRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Services.IDCard
{
	public class IDCardServiceController : Controller
	{
		private IIDCardRepository iIDCardRepository;
		public IDCardServiceController(IIDCardRepository _iIDCardRepository)
		{
			iIDCardRepository = _iIDCardRepository;
		}

		[HttpGet]
		public List<IDCardListUI> GetIDCardList()
		{
			return iIDCardRepository.GetAllIdCards();
		}

	}
}