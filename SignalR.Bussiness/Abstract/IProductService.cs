using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.Bussiness.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();

        int TProductCount(); 
        int TProductCountByCategoriNameHamburger();
		int TProductCountByCategoriNameDrink();
		decimal TProductPriceAvg(); 
        string TProductNameByMaxPrice();
		string TProductNameByMinPrice();
		decimal TProductAvgPriceByHamburger();

	}
}
