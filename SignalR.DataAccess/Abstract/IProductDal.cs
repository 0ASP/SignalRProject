using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccess.Abstract
{
    public interface IProductDal : IGenerikDal<Product>
    {
        List<Product> GetProductsWithCategories();

        int ProductCount();
        int ProductCountByCategoriNameHamburger();
        int ProductCountByCategoriNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByHamburger();
	}
}
