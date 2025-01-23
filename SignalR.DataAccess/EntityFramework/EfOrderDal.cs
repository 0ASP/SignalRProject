using SignalR.DataAccess.Abstract;
using SignalR.DataAccess.Concrete;
using SignalR.DataAccess.Repositories;
using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.EntityFramework
{
	public class EfOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EfOrderDal(SignalRContext context) : base(context)
		{
		}

		public int ActiveOrderCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
		}

		public decimal LastOrderPrice()
		{
			using var context = new SignalRContext();
			return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y=>y.TotalPrice).FirstOrDefault();
		}

		public decimal TodayTotalPrice()
		{
			using var context = new SignalRContext();
			return context.Orders.Where(x => x.OrderDate == DateTime.Parse(DateTime.Now.ToShortDateString())).Sum(y=>y.TotalPrice);
		}

		public double TotalOrderCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Count();
		}
	}
}
