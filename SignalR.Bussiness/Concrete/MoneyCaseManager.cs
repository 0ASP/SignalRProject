using SignalR.Bussiness.Abstract;
using SignalR.DataAccess.Abstract;
using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Bussiness.Concrete
{
	public class MoneyCaseManager : IMoneyCaseService
	{
		private readonly IMoneyCaseDal _moneyCaseServiceDal;
		public void TAdd(MoneyCase entity)
		{
			_moneyCaseServiceDal.Add(entity);
		}

		public void TDelete(MoneyCase entity)
		{
			_moneyCaseServiceDal.Delete(entity);
		}

		public MoneyCase TGetById(int id)
		{
			return _moneyCaseServiceDal.GetById(id);
		}

		public List<MoneyCase> TGetListAll()
		{
			return _moneyCaseServiceDal.GetListAll();
		}

		public decimal TTotalMoneyCaseAmount()
		{
			return _moneyCaseServiceDal.TotalMoneyCaseAmount();
		}

		public void TUpdate(MoneyCase entity)
		{
			_moneyCaseServiceDal.Update(entity);
		}
	}
}
