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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

		public int ActiveCategoryCount()
		{
			using var context = new SignalRContext();

			return context.Categories.Where(x=>x.Status==true).Count();
		}

		public int CategoriCount()
		{
			using var context = new SignalRContext();

			return context.Categories.Count();

		}

		public int PassiveCategoryCount()
		{
			using var context = new SignalRContext();

			return context.Categories.Where(x => x.Status == false).Count();
		}
	}
}
