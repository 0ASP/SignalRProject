using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.Abstract
{
    public interface ICategoryDal : IGenerikDal<Category>
    {
        int CategoriCount();
        int ActiveCategoryCount();
        int PassiveCategoryCount();
	}
}
