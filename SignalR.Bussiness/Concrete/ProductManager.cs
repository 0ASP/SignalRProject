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
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;

		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public int TProductCountByCategoriNameDrink()
		{
			return _productDal.ProductCountByCategoriNameDrink();
		}

		public int TProductCountByCategoriNameHamburger()
		{
			return _productDal.ProductCountByCategoriNameHamburger();
		}

		public void TAdd(Product entity)
		{
			_productDal.Add(entity);
		}

		public void TDelete(Product entity)
		{
			_productDal.Delete(entity);
		}

		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}

		public List<Product> TGetListAll()
		{
			return _productDal.GetListAll();
		}

		public List<Product> TGetProductsWithCategories()
		{
			return _productDal.GetProductsWithCategories();
		}

		public int TProductCount()
		{
			return _productDal.ProductCount();
		}

		public void TUpdate(Product entity)
		{
			_productDal.Update(entity);
		}

		public decimal TProductPriceAvg()
		{
			return _productDal.ProductPriceAvg();
		}

		public string TProductNameByMaxPrice()
		{
			return _productDal.ProductNameByMaxPrice();
		}

		public string TProductNameByMinPrice()
		{
			return _productDal.ProductNameByMinPrice();
		}
		 
		public decimal TProductAvgPriceByHamburger()
		{
			return _productDal.ProductAvgPriceByHamburger();	
		}
	}
}
