﻿using SignalR.DataAccess.Abstract;
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
	public class EfMoneyCaseDal : GenericRepository<MoneyCase>, IMoneyCaseDal
	{
		public EfMoneyCaseDal(SignalRContext context) : base(context)
		{
		}

		public decimal TotalMoneyCaseAmount()
		{
			using var context = new SignalRContext();
			return context.MoneyCases.Select(x=>x.TotalAmout).FirstOrDefault();
		}
	}
}
